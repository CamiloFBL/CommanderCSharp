namespace Commander
{
    partial class SettingsButtonsHelp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.allowedBtnList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allowedBtnList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.allowedBtnList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allowed buttons list.\r\nFor multiple button press, place a \'+\' character between k" +
    "ey names.";
            // 
            // allowedBtnList
            // 
            this.allowedBtnList.AllowUserToAddRows = false;
            this.allowedBtnList.AllowUserToDeleteRows = false;
            this.allowedBtnList.AllowUserToResizeColumns = false;
            this.allowedBtnList.AllowUserToResizeRows = false;
            this.allowedBtnList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allowedBtnList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.allowedBtnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allowedBtnList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnName,
            this.btnDesc});
            this.tableLayoutPanel1.SetColumnSpan(this.allowedBtnList, 2);
            this.allowedBtnList.Location = new System.Drawing.Point(6, 35);
            this.allowedBtnList.MultiSelect = false;
            this.allowedBtnList.Name = "allowedBtnList";
            this.allowedBtnList.ReadOnly = true;
            this.allowedBtnList.RowHeadersVisible = false;
            this.allowedBtnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allowedBtnList.Size = new System.Drawing.Size(372, 304);
            this.allowedBtnList.TabIndex = 4;
            this.allowedBtnList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CtrlCListener);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(6, 342);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label5.Size = new System.Drawing.Size(254, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Press CTR+C on selected item to copy button name.";
            // 
            // btnName
            // 
            this.btnName.HeaderText = "Button Name";
            this.btnName.MinimumWidth = 100;
            this.btnName.Name = "btnName";
            this.btnName.ReadOnly = true;
            this.btnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnDesc
            // 
            this.btnDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnDesc.HeaderText = "Description";
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.ReadOnly = true;
            this.btnDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SettingsButtonsHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsButtonsHelp";
            this.Text = "SettingsButtonsHelp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allowedBtnList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView allowedBtnList;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnDesc;
        private System.Windows.Forms.Label label5;
    }
}