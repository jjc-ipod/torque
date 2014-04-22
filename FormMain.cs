using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Linq;

namespace TorControl
{
    public partial class FormMain : Form
    {
        Socket serv = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Thread cThread, rThread; // cThread for console updates (triggered on connect), rThread for relay updates (user triggered)
        settings s = new settings();
        struct settings
        {
            public IPAddress ip;
            public int port;
            public string password;
        }
        Commands commands = new Commands();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadSettings();
            Console.WriteLine("Login:'" + commands.Login + "'");
        }

        private void networkConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display the settings window
            FormSettings f = new FormSettings();
            f.txtAddress.Text = s.ip.ToString();
            f.txtPort.Text = s.port.ToString();
            f.txtPassword.Text = s.password;
            f.ShowDialog();
            // if the user has hit 'apply' then reload the configs
            if (f.DialogResult == DialogResult.OK)
                loadSettings(true);
        }

        /// <summary>
        /// Can be used to update the config as well as start from scratch
        /// </summary>
        /// <param name="ip">IP Address of the tor client</param>
        /// <param name="port">Control port number</param>
        /// <param name="password">Password for logging in via the control port</param>
        public void createSettings(string ip = null, int port = 0, string password = null)
        {
            // use default values if none are supplied
            if (ip == null) ip = "127.0.0.1";
            if (port == 0) port = 9051;
            if (password == null) password = "blank";
            using (StreamWriter sw = new StreamWriter("config.cfg"))
                {
                    sw.Write("# This is the configuration file for Torque\n" +
                             "# Only modify this is you know what you're doing\n" +
                             "#\n" +
                             "# Parameter: ip\n" +
                             "# Default: 127.0.0.1" +
                             "# Advice: This is the address of your tor client. This is almost always 127.0.0.1, however if you are using Torque to control tor on another computer, change this to the computer's ip address\n" +
                             "ip=" + ip + "\n" +
                             "# Parameter: port\n" +
                             "# Default: 9051\n" +
                             "# Advice: This is the control port that tor uses. This can be changed in the torrc file. See the tor website for more info and also how to enable the control port.\n" +
                             "port=" + port.ToString() + "\n" +
                             "# Parameter: password\n" +
                             "# Default: blank\n" +
                             "# Advice: This is the password used to 'login' to tor via the control port. Use the actual word 'blank' if there is no password set. This tells Torque that the password field is empty\n" +
                             "password=" + password
                             );
                }
        }

        private void loadSettings(bool reload = false)
        {
            // check if config file exists
            if (!File.Exists("config.cfg"))
                // file does not exist, create it
                createSettings();
            else // file exists, loading
                using (StreamReader sr = new StreamReader("config.cfg"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split('=');
                        if (line[0][0] == '#')
                        {
                            Console.WriteLine("Continuing");
                            continue; // check for comments and skip if # is detected
                        }
                        Console.WriteLine("Switch");
                        switch (line[0])
                        {
                            case "ip":
                                Console.WriteLine("case IP");
                                // validate IP address
                                if (!IPAddress.TryParse(line[1], out s.ip))
                                {
                                    Console.WriteLine("MEEP");
                                    MessageBox.Show("The supplied IP address in the config file is invalid. Using default address: 127.0.0.1", "Config error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    s.ip = IPAddress.Parse("127.0.0.1");
                                }
                                else
                                    s.ip = IPAddress.Parse(line[1]);
                                break;
                            case "port":
                                Console.WriteLine("case PORT");
                                // validate port
                                try
                                { s.port = Convert.ToInt32(line[1]); } // attempt to convert & set. If it explodes then notify user and set default value
                                catch
                                {
                                    MessageBox.Show("The supplied port number in the config file is invalid. Using the default port of 9051", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    s.port = 9051;
                                }
                                break;
                            case "password":
                                Console.WriteLine("case PASSWORD");
                                // nothing to validate here...
                                if (line[1] == "blank")
                                {
                                    s.password = null;
                                    commands.Login = null;
                                }
                                else
                                {
                                    commands.Login = line[1];
                                    s.password = line[1];
                                }
                                break;
                            default:
                                // someone's been messing with the config file again...
                                MessageBox.Show("An unrecognised parameter has been found in the config file. This isn't an error but it is reccomended to check the configuration file and only keep the necessary parameters", "Unrecognised Parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                }
            lblSummary_ip.Text = s.ip.ToString();
            lblSummary_port.Text = s.port.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServTools st = new ServTools();
            st.ShutdownServer(serv, cThread);
            Application.Exit();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Attempt to connect
            IPEndPoint ip = new IPEndPoint(s.ip, s.port);
            try
            {
                serv.Connect(ip);
            }
            catch (Exception ex) // connect failed
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to tor client on " + s.ip.ToString() + ":" + s.port.ToString() + ". Please ensure that the tor client is running", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // authenticate
            ServTools servTools = new ServTools();
            servTools.Send(serv, commands.Login);
            
            // start the console update thread
            cThread = new Thread(new ThreadStart(cUpdate));
            cThread.Name = "cThread";
            cThread.Start();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            // Check for changes in connectivity and apply the relevant UI changes
            disconnectToolStripMenuItem.Enabled = (serv.Connected) ? true : false;
            connectToolStripMenuItem.Enabled = (serv.Connected) ? false : true;
            lblSummary_status.ForeColor = (serv.Connected) ? Color.Green : Color.Red;
            lblSummary_status.Text = (serv.Connected) ? "Connected" : "Disconnected";
            torToolStripMenuItem.Enabled = (serv.Connected) ? true : false;
            btnConsoleSend.Enabled = (serv.Connected) ? true : false;

            // If connected run the update commands
            if (serv.Connected)
            {
                ServTools st = new ServTools();
                //st.Send("
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServTools st = new ServTools();
            st.ShutdownServer(serv, cThread);
        }

        private void btnRefreshRelays_Click(object sender, EventArgs e)
        {
            lvGlobal.Items.Clear();
            panLoading.Visible = true;
            
            // all this crap is just so the loading bar can appear...
            rThread = new Thread(new ThreadStart(rUpdater));
            rThread.Name = "rThread";
            rThread.Start();
        }

        private void newIdentityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServTools st = new ServTools();
            st.Send(serv, commands.NewIdentity);
            if (st.ReceiveData(serv).Contains("250 OK"))
                MessageBox.Show("New identity successfully requested", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to request new identity", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConsoleSend_Click(object sender = null, EventArgs e = null)
        {
            ServTools st = new ServTools();
            string cmd = txtConsoleCommand.Text;
            // write to command to console
            updateConsole("\r\n> " + cmd + "\r\n");
            st.Send(serv, cmd + "\r\n");
            if (cmd == "quit") st.ShutdownServer(serv, cThread);
            // results will be automatically displayed. all we need to do is clear the command buffer
            txtConsoleCommand.Text = null;
        }

        private void txtConsoleCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                if (serv.Connected)
                    btnConsoleSend_Click();
                else
                    MessageBox.Show("Torque is not connected to a tor client. You need to connect to a tor client to use the console", "Not connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            txtConsole.SelectionStart = txtConsole.Text.Length;
            txtConsole.ScrollToCaret();
        }

        private void rUpdater()
        {
            Thread.Sleep(200); // allow UI to update
            rUpdate(panLoading, lvGlobal);
        }

        delegate void Rupdate(Panel p, ListView l);

        private void rUpdate(Panel p, ListView l)
        {
            if (InvokeRequired)
                Invoke(new Rupdate(rUpdate), new object[] { p, l });
            else
            {
                using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Tor/cached-microdesc-consensus"))
                {
                    ListViewItem i = new ListViewItem();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine(); // read line 1 of batch
                        string[] splitLine = line.Split(' ');
                        
                        switch (splitLine[0])
                        {
                            case "r":
                                Console.WriteLine("TRIGGER: R");
                                i.Name = splitLine[1]; // name
                                i.SubItems.Add(splitLine[5]); // ip address
                                break;
                            case "s":
                                Console.WriteLine("TRIGGER: S");
                                string flags = string.Empty;
                                foreach (string flag in splitLine)
                                {
                                    if (flag == "s") continue; // skip the flag line identifier
                                    flags += flag + " "; // append flags to one variable
                                }
                                i.SubItems.Add(flags);
                                break;
                            case "v":
                                Console.WriteLine("TRIGGER: V");
                                i.SubItems.Add(splitLine[1] + " " + splitLine[2]); // version
                                break;
                            case "w":
                                Console.WriteLine("TRIGGER: W");
                                // looks complicated but just gets B/s and converts to KB/s
                                i.SubItems.Add((Convert.ToInt32(splitLine[1].Split('=')[1]) / 1000).ToString());
                                break;
                        }
                        Console.WriteLine("Case: " + splitLine[0]);
                        Console.WriteLine("Subitems: " + i.SubItems.Count.ToString());
                        Console.WriteLine("N: " + i.Name);
                        Console.WriteLine("---");
                        if (i.SubItems.Count == 4)
                        {
                            lvGlobal.Items.Add(i);
                            i.SubItems.Clear();
                        }
                    }
                    panLoading.Visible = false;
                }
            }
        }

        private void cUpdate()
        {
            while (serv.Connected)
            {
                byte[] data = new byte[1024];
                int receivedDataLength = serv.Receive(data);
                string dataString = Encoding.ASCII.GetString(data, 0, receivedDataLength);
                Console.WriteLine("Received data");
                updateConsole(dataString);
            }
        }

        delegate void UpdateConsole(string data);
        private void updateConsole(string data)
        {
            if (txtConsole.InvokeRequired)
                txtConsole.Invoke(new UpdateConsole(updateConsole),
                    new object[] { data });
            else
                txtConsole.Text += data;
        }


    }

    public class Commands
    {
        private string newIdentity = "SIGNAL NEWNYM\r\n";
        public string NewIdentity
        {
            get { return newIdentity; }
        }
        private string login = "AUTHENTICATE \"\"";
        public string Login
        {
            get { return login; }
            set { login = "AUTHENTICATE \"" + value + "\"\r\n"; }
        }
    }

    public class ServTools
    {
        
        public bool Send(Socket s, string message)
        {
            try
            {
                s.Send(Encoding.ASCII.GetBytes(message));
            }
            catch
            {
                return false;
            }
            return true;
        }

        public string ReceiveData(Socket s)
        {
            byte[] data = new byte[1024];
            int receivedDataLength = s.Receive(data);
            string dataString = Encoding.ASCII.GetString(data, 0, receivedDataLength);
            Console.WriteLine(dataString);
            return dataString;
        }

        public void ShutdownServer(Socket s, Thread c)
        {
            c.Abort();
            s.Disconnect(true); // currently problematic with reconnecting
        }
    }
}
