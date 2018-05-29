using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Commander
{
    public partial class Settings : Form
    {
        private static String[] commListNamesByKeyPress;
        private static String[] commListKeyPress;
        private static String[] commListNamesByApps;
        private static String[] commListAppsPath;

        public Settings()
        {
            InitializeComponent();
            setCommField();
            FillLists();
        }

        private static String getCommInit()
        {
            String xmlpath = Directory.GetCurrentDirectory() + "\\commander.xml";
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlpath);
            XmlNode xnode = xml.SelectSingleNode("/settings/commInit");

            String commInit = null;
            commInit = xnode.InnerText;
            return commInit;
        }

        private void setCommField()
        {
            Console.WriteLine("Setting values in UI...");
            String commInit = getCommInit();
            Console.WriteLine(commInit);
            commInitField.Text = commInit;
        }

        private void FillLists()
        {
            commListNamesByKeyPress = new String[CommanderFunctions.commNamesByKeyPress.Length];
            commListKeyPress = new String[CommanderFunctions.commKeyPress.Length];
            commListNamesByApps = new String[CommanderFunctions.commNamesByApps.Length];
            commListAppsPath = new String[CommanderFunctions.commAppsPath.Length];

            for (int i = 0; CommanderFunctions.commNamesByKeyPress.Length > i; i++)
            {
                commListNamesByKeyPress[i] = CommanderFunctions.commNamesByKeyPress[i];
                commListKeyPress[i] = CommanderFunctions.commKeyPress[i];
                ListCommByKeyPress.Rows.Add(CommanderFunctions.commNamesByKeyPress[i], CommanderFunctions.commKeyPress[i]);
            }

            for (int i = 0; CommanderFunctions.commNamesByApps.Length > i; i++)
            {
                commListNamesByApps[i] = CommanderFunctions.commNamesByApps[i];
                commListAppsPath[i] = CommanderFunctions.commAppsPath[i];
                ListCommByApps.Rows.Add(CommanderFunctions.commNamesByApps[i], CommanderFunctions.commAppsPath[i]);
            }

            Console.WriteLine("ListCommByKeyPress count: " + ListCommByKeyPress.RowCount);
            Console.WriteLine("ListCommByApps count: " + ListCommByApps.RowCount);
        }

        private void SaveCommChanges(object sender, EventArgs e)
        {
            String[] commNamesByKeyPress = new String[ListCommByKeyPress.RowCount - 1];
            String[] commByKeyPress = new String[ListCommByKeyPress.RowCount - 1];
            String[] commNamesByApp = new String[ListCommByApps.RowCount - 1];
            String[] commAppsPath = new String[ListCommByApps.RowCount - 1];
            String commInit = commInitField.Text;

            /* Validation Start */
            if(string.IsNullOrEmpty(commInit) || string.IsNullOrWhiteSpace(commInit))
            {
                Console.WriteLine("commInitField triggered an error...");
                MessageBox.Show("CommInit symbol cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                commInitField.Text = CommanderFunctions.commInit;
                commInitField.Focus();
                return;
            }

            for (int i = 0; ListCommByKeyPress.Rows.Count - 1 > i; i++)
            {
                var validateName = ListCommByKeyPress.Rows[i].Cells[0].Value;
                var validateComm = ListCommByKeyPress.Rows[i].Cells[1].Value;

                if (validateName == null || string.IsNullOrWhiteSpace(validateName.ToString()) || validateComm == null || string.IsNullOrWhiteSpace(validateComm.ToString()))
                {
                    Console.WriteLine("commListKeyPress triggered an error...");
                    MessageBox.Show("One of the fields are empty.\nMake sure that no field are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ListCommByKeyPress.CurrentCell = ListCommByKeyPress.Rows[i].Cells[0];
                    return;
                }

                if (CommanderRobot.KeysCheck(validateComm))
                {
                    Console.WriteLine("Keys entered correctly");
                }
                else
                {
                    Console.WriteLine("At least one unrecognized key found.");
                    MessageBox.Show("Found an unsupported key press. Please verify highlighted command instruction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ListCommByKeyPress.CurrentCell = ListCommByKeyPress.Rows[i].Cells[0];
                    return;
                }
            }

            for (int i = 0; ListCommByApps.Rows.Count - 1 > i; i++)
            {
                var validateName = ListCommByApps.Rows[i].Cells[0].Value;
                var validateComm = ListCommByApps.Rows[i].Cells[1].Value;

                if (validateName == null || string.IsNullOrWhiteSpace(validateName.ToString()) || validateComm == null || string.IsNullOrWhiteSpace(validateComm.ToString()))
                {
                    Console.WriteLine("commListKeyPress triggered an error...");
                    MessageBox.Show("One of the fields are empty.\nMake sure that no field are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ListCommByApps.CurrentCell = ListCommByApps.Rows[i].Cells[0];
                    return;
                }
            }

            for (int i = 0; ListCommByKeyPress.Rows.Count - 1 > i; i++)
            {
                if (ListCommByKeyPress.Rows.Count > i + 1)
                {
                    Console.WriteLine(i);

                    for (int j = i + 1; ListCommByKeyPress.Rows.Count - 1 > j; j++)
                    {
                        Console.Write(ListCommByKeyPress.Rows[i].Cells[0].Value.ToString() + " - " + ListCommByKeyPress.Rows[j].Cells[0].Value.ToString());

                        if (!string.Equals(ListCommByKeyPress.Rows[i].Cells[0].Value.ToString(), ListCommByKeyPress.Rows[j].Cells[0].Value.ToString(), StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine(" : Accept");
                        }
                        else
                        {
                            Console.WriteLine(" : False");
                            Console.WriteLine("Found repeated entry. Canceling method.");
                            MessageBox.Show("Found two commands with the same name (ignoring case).\nPlease verify selected item and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ListCommByKeyPress.CurrentCell = ListCommByKeyPress.Rows[i].Cells[0];
                            return;
                        }
                    }

                    for (int k = 0; ListCommByApps.Rows.Count - 1 > k; k++)
                    {
                        Console.Write(ListCommByKeyPress.Rows[i].Cells[0].Value.ToString() + " - " + ListCommByApps.Rows[k].Cells[0].Value.ToString());

                        if (!string.Equals(ListCommByKeyPress.Rows[i].Cells[0].Value.ToString(), ListCommByApps.Rows[k].Cells[0].Value.ToString(), StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine(" : Accept");
                        }
                        else
                        {
                            Console.WriteLine(" : False");
                            Console.WriteLine("Found repeated entry. Canceling method.");
                            MessageBox.Show("Found two commands with the same name (ignoring case).\nPlease verify selected item and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ListCommByKeyPress.CurrentCell = ListCommByKeyPress.Rows[i].Cells[0];
                            ListCommByApps.CurrentCell = ListCommByApps.Rows[k].Cells[0];
                            return;
                        }
                    } 
                }
            }

            for (int i = 0; ListCommByApps.Rows.Count - 1 > i; i++)
            {
                Console.WriteLine("new : " + i);
                for (int j = i + 1; ListCommByApps.Rows.Count - 1 > j; j++)
                {
                    Console.Write(ListCommByApps.Rows[i].Cells[0].Value.ToString() + " - " + ListCommByApps.Rows[j].Cells[0].Value.ToString());
                    if (!string.Equals(ListCommByApps.Rows[i].Cells[0].Value.ToString(), ListCommByApps.Rows[j].Cells[0].Value.ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine(" : Accept");
                    }
                    else
                    {
                        Console.WriteLine(" : False");
                        Console.WriteLine("Found repeated entry. Canceling method.");
                        MessageBox.Show("Found two commands with the same name (ignoring case).\nPlease verify selected item and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ListCommByApps.CurrentCell = ListCommByApps.Rows[i].Cells[0];
                        return;
                    }
                }
            }
            /* Validation End*/

            CommanderFunctions.commInit = commInit;

            CommanderFunctions.commNamesByKeyPress = new String[ListCommByKeyPress.Rows.Count - 1];
            CommanderFunctions.commKeyPress = new String[ListCommByKeyPress.Rows.Count - 1];
            CommanderFunctions.commNamesByApps = new String[ListCommByApps.Rows.Count - 1];
            CommanderFunctions.commAppsPath = new String[ListCommByApps.Rows.Count - 1];

            commNamesByKeyPress = new String[ListCommByKeyPress.Rows.Count - 1];
            commByKeyPress = new String[ListCommByKeyPress.Rows.Count - 1];

            for (int i = 0; ListCommByKeyPress.Rows.Count - 1 > i; i++)
            {
                CommanderFunctions.commNamesByKeyPress[i] = ListCommByKeyPress.Rows[i].Cells[0].Value.ToString();
                CommanderFunctions.commKeyPress[i] = ListCommByKeyPress.Rows[i].Cells[1].Value.ToString();
            }

            Console.WriteLine("KeyPress command names: " + string.Join(", ", CommanderFunctions.commNamesByKeyPress));
            Console.WriteLine("KeyPress commands: " + string.Join(", ", CommanderFunctions.commKeyPress));

            commNamesByApp = new String[ListCommByApps.Rows.Count - 1];
            commAppsPath = new String[ListCommByApps.Rows.Count - 1];

            for (int i = 0; ListCommByApps.Rows.Count - 1 > i; i++)
            {
                CommanderFunctions.commNamesByApps[i] = ListCommByApps.Rows[i].Cells[0].Value.ToString();
                CommanderFunctions.commAppsPath[i] = ListCommByApps.Rows[i].Cells[1].Value.ToString();
            }

            Console.WriteLine("App command names: " + string.Join(", ", CommanderFunctions.commNamesByApps));
            Console.WriteLine("App commands: " + string.Join(", ", CommanderFunctions.commAppsPath));

            SaveCommFiles();
        }

        private void SaveCommFiles()
        {
            String xmlpath = Directory.GetCurrentDirectory() + "\\commander.xml";
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(xmlpath);
                XmlNode xnode = xml.SelectSingleNode("/settings/commInit");
                xnode.InnerText = commInitField.Text;
                xml.Save(xmlpath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error trying to save XML.");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Creating new XML.");

                File.Delete(xmlpath);

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = ("\t");

                XmlWriter xwriter = XmlWriter.Create(xmlpath, settings);
                xwriter.WriteStartDocument();
                xwriter.WriteStartElement("settings");
                xwriter.WriteStartElement("commInit");
                xwriter.WriteString(commInitField.Text);
                xwriter.WriteEndElement();
                xwriter.WriteEndDocument();
                xwriter.Close();
            }

            String txtCommNamesByKeyPress = Directory.GetCurrentDirectory() + "\\CommNamesByKeyPress.txt";
            String txtCommKeyPress = Directory.GetCurrentDirectory() + "\\CommKeyPress.txt";
            String txtCommNamesByApps = Directory.GetCurrentDirectory() + "\\CommNamesByApps.txt";
            String txtCommAppsPath = Directory.GetCurrentDirectory() + "\\CommAppsPath.txt";
            Console.WriteLine(txtCommNamesByKeyPress);
            Console.WriteLine(txtCommKeyPress);
            Console.WriteLine(txtCommNamesByApps);
            Console.WriteLine(txtCommAppsPath);

            for (int i = 0; CommanderFunctions.commNamesByKeyPress.Length > i; i++)
            {
                Console.WriteLine(CommanderFunctions.commNamesByKeyPress[i]);
            }
            File.WriteAllLines(txtCommNamesByKeyPress, CommanderFunctions.commNamesByKeyPress);
            Console.WriteLine("CommNamesByKeyPress file saved.");

            for (int i = 0; CommanderFunctions.commKeyPress.Length > i; i++)
            {
                Console.WriteLine(CommanderFunctions.commKeyPress[i]);
            }
            File.WriteAllLines(txtCommKeyPress, CommanderFunctions.commKeyPress);
            Console.WriteLine("CommKeyPress file saved.");

            for (int i = 0; CommanderFunctions.commNamesByApps.Length > i; i++)
            {
                Console.WriteLine(CommanderFunctions.commNamesByApps[i]);
            }
            File.WriteAllLines(txtCommNamesByApps, CommanderFunctions.commNamesByApps);
            Console.WriteLine("CommNamesByApps file saved.");

            for (int i = 0; CommanderFunctions.commAppsPath.Length > i; i++)
            {
                Console.WriteLine(CommanderFunctions.commAppsPath[i]);
            }
            File.WriteAllLines(txtCommAppsPath, CommanderFunctions.commAppsPath);
            Console.WriteLine("CommAppsPath file saved.");

            Console.WriteLine("Files update completed.");
            MessageBox.Show("Commands save successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenButtonsHelp(object sender, EventArgs e)
        {

        }

        private void printLists(object sender, EventArgs e)
        {
            String[] keyCommNames = new String[ListCommByKeyPress.RowCount - 1];
            String[] keyComms = new String[ListCommByKeyPress.RowCount - 1];

            for (int i = 0; ListCommByKeyPress.Rows.Count - 1 > i; i++)
            {
                String t = ListCommByKeyPress.Rows[i].Cells[0].Value.ToString();
                keyCommNames[i] = ListCommByKeyPress.Rows[i].Cells[0].Value.ToString();
                keyComms[i] = ListCommByKeyPress.Rows[i].Cells[1].Value.ToString();
            }

            Console.WriteLine(string.Join(", ", keyCommNames));
            Console.WriteLine(string.Join(", ", keyComms));
        }
    }
}
