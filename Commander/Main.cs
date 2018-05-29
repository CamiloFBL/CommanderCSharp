using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commander
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CommanderFunctions.InitCheck();
            AcceptButton = btnSubmit;
        }

        private void Submit(object sender, KeyEventArgs e)
        {
            String text;
            text = command.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if(!string.IsNullOrEmpty(text) && !string.IsNullOrWhiteSpace(text))
                {
                    log.AppendText(text + "\n");
                    command.Text = "";

                    if (text.Length >= CommanderFunctions.commInit.Length)
                    {
                        Console.WriteLine(text.Substring(0, CommanderFunctions.commInit.Length));
                        Console.WriteLine(text.Substring(CommanderFunctions.commInit.Length, text.Length - CommanderFunctions.commInit.Length));

                        String commSymbolCheck = text.Substring(0, CommanderFunctions.commInit.Length);
                        String commName = text.Substring(CommanderFunctions.commInit.Length, text.Length - CommanderFunctions.commInit.Length);

                        if (commSymbolCheck.Equals(CommanderFunctions.commInit))
                        {
                            if (CommanderFunctions.CommandCheck(commName.ToLower()))
                            {
                                Console.WriteLine("Command found.");
                                CommanderFunctions.ExecuteCommand(commName.ToLower());
                                log.AppendText("Command executed.\n");
                            }
                            else
                            {
                                Console.WriteLine("Unrecognized command.");
                                log.AppendText("Unrecognized command.\n");
                            }
                        }
                    }
                }
                else
                {
                    command.Text = "";
                }
            }
        }

        private void LogAutoScroll(object sender, EventArgs e)
        {
            log.SelectionStart = log.Text.Length;
            log.ScrollToCaret();
        }

        private void MenuExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Settings m = new Settings();
            m.Show();
        }
    }
}
