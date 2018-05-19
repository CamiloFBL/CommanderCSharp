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
        }

        private void Submit(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String text;
                text = command.Text;
                if(!string.IsNullOrEmpty(text) && !string.IsNullOrWhiteSpace(text))
                {
                    log.AppendText(text + "\n");
                    command.Text = "";
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
    }
}
