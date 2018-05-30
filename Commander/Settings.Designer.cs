namespace Commander
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commInitField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.ListCommByKeyPress = new System.Windows.Forms.DataGridView();
            this.commKeyNamesList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commKeyPressesList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListCommByApps = new System.Windows.Forms.DataGridView();
            this.commAppPathsList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commAppNamesList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.console = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCommByKeyPress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListCommByApps)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.commInitField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.apply, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.close, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.ListCommByKeyPress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ListCommByApps, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.console, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.help, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Location = new System.Drawing.Point(92, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(400, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Before closing this window, make sure to save changes by pressing \"Apply\" button." +
    "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CommInit Symbol:";
            // 
            // commInitField
            // 
            this.commInitField.Location = new System.Drawing.Point(146, 31);
            this.commInitField.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.commInitField.Name = "commInitField";
            this.commInitField.Size = new System.Drawing.Size(100, 20);
            this.commInitField.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(299, 59);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Commands to open apps:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label9, 2);
            this.label9.Location = new System.Drawing.Point(3, 59);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label9.Size = new System.Drawing.Size(126, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Commands by Key Press:";
            // 
            // apply
            // 
            this.apply.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.apply.Location = new System.Drawing.Point(361, 335);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 18;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.SaveCommChanges);
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.close.Location = new System.Drawing.Point(506, 335);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 18;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.CloseForm);
            // 
            // ListCommByKeyPress
            // 
            this.ListCommByKeyPress.AllowUserToResizeColumns = false;
            this.ListCommByKeyPress.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListCommByKeyPress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListCommByKeyPress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCommByKeyPress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commKeyNamesList,
            this.commKeyPressesList});
            this.tableLayoutPanel1.SetColumnSpan(this.ListCommByKeyPress, 2);
            this.ListCommByKeyPress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCommByKeyPress.Location = new System.Drawing.Point(3, 85);
            this.ListCommByKeyPress.MultiSelect = false;
            this.ListCommByKeyPress.Name = "ListCommByKeyPress";
            this.ListCommByKeyPress.RowHeadersWidth = 25;
            this.ListCommByKeyPress.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListCommByKeyPress.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ListCommByKeyPress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCommByKeyPress.Size = new System.Drawing.Size(280, 213);
            this.ListCommByKeyPress.TabIndex = 20;
            // 
            // commKeyNamesList
            // 
            this.commKeyNamesList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.commKeyNamesList.HeaderText = "Command Name";
            this.commKeyNamesList.Name = "commKeyNamesList";
            this.commKeyNamesList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.commKeyNamesList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.commKeyNamesList.Width = 91;
            // 
            // commKeyPressesList
            // 
            this.commKeyPressesList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commKeyPressesList.HeaderText = "Key Presses";
            this.commKeyPressesList.Name = "commKeyPressesList";
            this.commKeyPressesList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.commKeyPressesList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ListCommByApps
            // 
            this.ListCommByApps.AllowUserToResizeColumns = false;
            this.ListCommByApps.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListCommByApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListCommByApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCommByApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commAppPathsList,
            this.commAppNamesList});
            this.tableLayoutPanel1.SetColumnSpan(this.ListCommByApps, 2);
            this.ListCommByApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCommByApps.Location = new System.Drawing.Point(299, 85);
            this.ListCommByApps.MultiSelect = false;
            this.ListCommByApps.Name = "ListCommByApps";
            this.ListCommByApps.RowHeadersWidth = 25;
            this.ListCommByApps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListCommByApps.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ListCommByApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCommByApps.Size = new System.Drawing.Size(282, 213);
            this.ListCommByApps.TabIndex = 21;
            // 
            // commAppPathsList
            // 
            this.commAppPathsList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.commAppPathsList.HeaderText = "Command Name";
            this.commAppPathsList.Name = "commAppPathsList";
            this.commAppPathsList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.commAppPathsList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.commAppPathsList.Width = 91;
            // 
            // commAppNamesList
            // 
            this.commAppNamesList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commAppNamesList.HeaderText = "App path or command";
            this.commAppNamesList.Name = "commAppNamesList";
            this.commAppNamesList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.commAppNamesList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // console
            // 
            this.console.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.console.Location = new System.Drawing.Point(34, 335);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(75, 23);
            this.console.TabIndex = 19;
            this.console.Text = "console print";
            this.console.UseVisualStyleBackColor = true;
            this.console.Click += new System.EventHandler(this.printLists);
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.help.Location = new System.Drawing.Point(208, 335);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 22;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.OpenButtonsHelp);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 5);
            this.label3.Location = new System.Drawing.Point(3, 301);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 15);
            this.label3.Size = new System.Drawing.Size(196, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Press DEL to delete selected command.";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCommByKeyPress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListCommByApps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox commInitField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button console;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ListCommByKeyPress;
        private System.Windows.Forms.DataGridView ListCommByApps;
        private System.Windows.Forms.DataGridViewTextBoxColumn commKeyNamesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn commKeyPressesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn commAppPathsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn commAppNamesList;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label3;
    }
}