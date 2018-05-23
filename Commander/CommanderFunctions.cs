using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace Commander
{
    class CommanderFunctions
    {
        public static String commInit;
        public static String commExit = "exit";
        public static String[] commNamesByKeyPress;
        public static String[] commKeyPress;
        public static String[] commNamesByApps;
        public static String[] commAppsPath;

        public static void InitCheck()
        {
            CheckComms();
            CheckXMLFile();
        }

        public static void CheckComms()
        {
            String txtCommNamesByKeyPress = "CommNamesByKeyPress.txt";
            String txtCommKeyPress = "CommKeyPress.txt";
            String txtCommNamesByApps = "CommNamesByApps.txt";
            String txtCommAppsPath = "CommAppsPath.txt";
            try
            {
                if (File.Exists(txtCommNamesByKeyPress) && File.Exists(txtCommKeyPress))
                {
                    int linesCount1 = 0;
                    StreamReader sr = new StreamReader(txtCommNamesByKeyPress);

                    while (sr.ReadLine() != null)
                    {
                        linesCount1++;
                    }
                    sr.Close();

                    int linesCount2 = 0;
                    StreamReader sr2 = new StreamReader(txtCommKeyPress);
                    while (sr2.ReadLine() != null)
                    {
                        linesCount2++;
                    }
                    sr2.Close();

                    if (linesCount1 == linesCount2)
                    {
                        Console.WriteLine("Commands by key press files found...");
                        ReadCommKeyPress();
                        ReadCommNamesByKeyPress();
                    }
                    else
                    {
                        Console.WriteLine("Commands by key press files pair don't match, creating files...");
                        CreateCommKeyPress();
                        CreateCommNamesByKeyPress();
                    }
                }
                else
                {
                    Console.WriteLine("Commands by key press files pair not found, creating files...");
                    CreateCommKeyPress();
                    CreateCommNamesByKeyPress();
                }

                if (File.Exists(txtCommNamesByApps) && File.Exists(txtCommAppsPath))
                {
                    int linesCount1 = 0;
                    StreamReader sr = new StreamReader(txtCommNamesByApps);

                    while (sr.ReadLine() != null)
                    {
                        linesCount1++;
                    }
                    sr.Close();

                    int linesCount2 = 0;
                    StreamReader sr2 = new StreamReader(txtCommAppsPath);
                    while (sr2.ReadLine() != null)
                    {
                        linesCount2++;
                    }
                    sr2.Close();

                    if (linesCount1 == linesCount2)
                    {
                        Console.WriteLine("Commands for apps execution files found...");
                        ReadCommAppsPath();
                        ReadCommNamesByApps();
                    }
                    else
                    {
                        Console.WriteLine("Commands for apps execution files pair don't match, creating files...");
                        CreateCommAppsPath();
                        CreateCommNamesByApps();
                    }
                }
                else
                {
                    Console.WriteLine("Commands for apps execution files pair not found, creating files...");
                    CreateCommAppsPath();
                    CreateCommNamesByApps();
                }
            }
            catch (Exception e)
            {
                if (e is IOException || e is OutOfMemoryException)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        private static void CreateCommNamesByKeyPress()
        {
            String txtCommNamesByKeyPress = AppDomain.CurrentDomain.BaseDirectory + "CommNamesByKeyPress.txt";
            commNamesByKeyPress = new String[] { "whome", "taskmgr" };
            foreach (var item in commNamesByKeyPress)
                Console.WriteLine(item);
            Console.WriteLine(txtCommNamesByKeyPress);
            File.WriteAllLines(txtCommNamesByKeyPress, commNamesByKeyPress);
        }

        private static void ReadCommNamesByKeyPress()
        {
            String line;
            String[] commNames;
            int linesCount = 0;

            try
            {
                StreamReader sr = new StreamReader("CommNamesByKeyPress.txt");
                while (sr.ReadLine() != null)
                {
                    linesCount++;
                }

                commNames = new String[linesCount];
                Console.WriteLine(commNames.Length);
                commNamesByKeyPress = new String[linesCount];

                sr = new StreamReader("CommNamesByKeyPress.txt");

                for (int i = 0; (line = sr.ReadLine()) != null; i++)
                {
                    commNames[i] = line;
                    Console.WriteLine(line);
                    commNamesByKeyPress[i] = line;
                }

                sr.Close();

                Console.WriteLine("File closed.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void CreateCommKeyPress()
        {
            String txtCommKeyPress = AppDomain.CurrentDomain.BaseDirectory + "CommKeyPress.txt";
            commKeyPress = new String[] { "windows", "ctrl+shift+esc" };
            foreach (var item in commKeyPress)
                Console.WriteLine(item);
            Console.WriteLine(txtCommKeyPress);
            File.WriteAllLines(txtCommKeyPress, commKeyPress);
        }

        private static void ReadCommKeyPress()
        {
            String line;
            String[] comms;
            int linesCount = 0;

            try
            {
                StreamReader sr = new StreamReader("CommKeyPress.txt");
                while (sr.ReadLine() != null)
                {
                    linesCount++;
                }

                comms = new String[linesCount];
                Console.WriteLine(comms.Length);
                commKeyPress = new String[linesCount];

                sr = new StreamReader("CommKeyPress.txt");

                for (int i = 0; (line = sr.ReadLine()) != null; i++)
                {
                    comms[i] = line;
                    Console.WriteLine(line);
                    commKeyPress[i] = line;
                }

                sr.Close();

                Console.WriteLine("File closed.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void CreateCommNamesByApps()
        {
            String txtCommNamesByApps = AppDomain.CurrentDomain.BaseDirectory + "CommNamesByApps.txt";
            commNamesByApps = new String[] { "notepad", "calculator" };
            foreach (var item in commNamesByApps)
                Console.WriteLine(item);
            Console.WriteLine(txtCommNamesByApps);
            File.WriteAllLines(txtCommNamesByApps, commNamesByApps);
        }

        private static void ReadCommNamesByApps()
        {
            String line;
            String[] commNames;
            int linesCount = 0;

            try
            {
                StreamReader sr = new StreamReader("CommNamesByApps.txt");
                while (sr.ReadLine() != null)
                {
                    linesCount++;
                }

                commNames = new String[linesCount];
                Console.WriteLine(commNames.Length);
                commNamesByApps = new String[linesCount];

                sr = new StreamReader("CommNamesByApps.txt");

                for (int i = 0; (line = sr.ReadLine()) != null; i++)
                {
                    commNames[i] = line;
                    Console.WriteLine(line);
                    commNamesByApps[i] = line;
                }

                sr.Close();

                Console.WriteLine("File closed.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void CreateCommAppsPath()
        {
            String txtCommAppsPath = AppDomain.CurrentDomain.BaseDirectory + "CommAppsPath.txt";
            commAppsPath = new String[] { "notepad", "calc" };
            foreach (var item in commAppsPath)
                Console.WriteLine(item);
            Console.WriteLine(txtCommAppsPath);
            File.WriteAllLines(txtCommAppsPath, commAppsPath);
        }

        private static void ReadCommAppsPath()
        {
            String line;
            String[] comms;
            int linesCount = 0;

            try
            {
                StreamReader sr = new StreamReader("CommAppsPath.txt");
                while (sr.ReadLine() != null)
                {
                    linesCount++;
                }

                comms = new String[linesCount];
                Console.WriteLine(comms.Length);
                commAppsPath = new String[linesCount];

                sr = new StreamReader("CommAppsPath.txt");

                for (int i = 0; (line = sr.ReadLine()) != null; i++)
                {
                    comms[i] = line;
                    Console.WriteLine(line);
                    commAppsPath[i] = line;
                }

                sr.Close();

                Console.WriteLine("File closed.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void CheckXMLFile()
        {
            String xmlpath = AppDomain.CurrentDomain.BaseDirectory + "commander.xml";
            if (File.Exists(xmlpath))
            {
                Console.WriteLine("XML file found...");
                XMLRead();
            }
            else
            {
                Console.WriteLine("XML file not found, creating new one...");
                XMLCreate();
            }
        }

        private static void XMLRead()
        {
            String xmlpath = AppDomain.CurrentDomain.BaseDirectory + "commander.xml";
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(xmlpath);
                XmlNode xnode = xml.SelectSingleNode("/settings/commInit");

                commInit = xnode.InnerText;
                if (commInit == null || commInit == "")
                {
                    Console.WriteLine("Fatal error: commInit setting is missing.\nGenerating new XML.");
                    File.Delete(xmlpath);
                    XMLCreate();
                }
                else
                {
                    Console.WriteLine(commInit);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Fatal error: couldn't read XML file.\nGenerating new XML.");
                File.Delete(xmlpath);
                XMLCreate();
            }
        }

        private static void XMLCreate()
        {
            String xmlpath = AppDomain.CurrentDomain.BaseDirectory + "commander.xml";

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("\t");

            XmlWriter xwriter = XmlWriter.Create(xmlpath, settings);
            xwriter.WriteStartDocument();
            xwriter.WriteStartElement("settings");
            xwriter.WriteStartElement("commInit");
            xwriter.WriteString("!_");
            xwriter.WriteEndElement();
            xwriter.WriteEndDocument();
            xwriter.Close();

            XmlDocument xml = new XmlDocument();
            xml.Load(xmlpath);
            XmlNode xnode = xml.SelectSingleNode("/settings/commInit");

            commInit = xnode.InnerText;
            Console.WriteLine(commInit);
        }

        public static Boolean CommandCheck(String command)
        {
            if(command.Equals(commExit) || commNamesByKeyPress.Contains(command) || commNamesByApps.Contains(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ExecuteCommand(string command)
        {
            Console.WriteLine("ExecuteCommand method initializing...");
            if (command.Equals(commExit))
            {
                Console.WriteLine("Call to exit program.");
                Application.Exit();
            }

            if (commNamesByKeyPress.Contains(command))
            {
                int index = Array.IndexOf(commNamesByKeyPress, command);
                String[] keyPresses;
                keyPresses = commKeyPress[index].Split('+');
                for(int i = 0; keyPresses.Length > i; i++)
                {
                    Console.WriteLine(keyPresses[i]);
                    CommanderRobot.RobotKeyPress(keyPresses[i]);
                }
                for (int i = 0; keyPresses.Length > i; i++)
                {
                    CommanderRobot.RobotKeyRelease(keyPresses[i]);
                }
            }

            if (commNamesByApps.Contains(command))
            {
                CommanderRobot.RobotExecApp(command);
            }
        }
    }
}
