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
    public partial class SettingsButtonsHelp : Form
    {
        public SettingsButtonsHelp()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            for(int i = 0; CommanderRobot.allowedKeys.Length > i; i++)
            {
                allowedBtnList.Rows.Add(CommanderRobot.allowedKeys[i], CommanderRobot.allowedKeysDesc[i]);
            }
            allowedBtnList.BackgroundColor = System.Drawing.SystemColors.Control;
        }

        private void CtrlCListener(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.C)
            {
                Console.WriteLine("CTRL+C pressed");
                CopyToClipboard();
            }
        }

        private void CopyToClipboard()
        {
            int rowIndex = allowedBtnList.CurrentCell.RowIndex;
            String btn = allowedBtnList.Rows[rowIndex].Cells[0].Value.ToString();
            Console.WriteLine(btn);

            Clipboard.SetText(btn);
        }
    }
}
