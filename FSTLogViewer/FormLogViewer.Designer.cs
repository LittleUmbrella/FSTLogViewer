namespace FSTLogViewer
{
    public partial class FormLogViewer
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
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSetFolder = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshLogs = new System.Windows.Forms.ToolStripButton();
            this.tbxRefreshInterval = new System.Windows.Forms.ToolStripTextBox();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.tbxPositions = new System.Windows.Forms.TextBox();
            this.tbxOrders = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusUpdatedText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusUpdatedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxAccount
            // 
            this.tbxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAccount.Location = new System.Drawing.Point(3, 28);
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.ReadOnly = true;
            this.tbxAccount.Size = new System.Drawing.Size(644, 22);
            this.tbxAccount.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetFolder,
            this.btnRefreshLogs,
            this.tbxRefreshInterval,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(650, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSetFolder
            // 
            this.btnSetFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetFolder.Name = "btnSetFolder";
            this.btnSetFolder.Size = new System.Drawing.Size(63, 22);
            this.btnSetFolder.Text = "Set Folder";
            this.btnSetFolder.Click += new System.EventHandler(this.BtnSetFolderClick);
            // 
            // btnRefreshLogs
            // 
            this.btnRefreshLogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefreshLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshLogs.Name = "btnRefreshLogs";
            this.btnRefreshLogs.Size = new System.Drawing.Size(78, 22);
            this.btnRefreshLogs.Text = "Refresh Logs";
            this.btnRefreshLogs.Click += new System.EventHandler(this.BtnRefreshLogsClick);
            // 
            // tbxRefreshInterval
            // 
            this.tbxRefreshInterval.AutoToolTip = true;
            this.tbxRefreshInterval.Name = "tbxRefreshInterval";
            this.tbxRefreshInterval.Size = new System.Drawing.Size(50, 25);
            this.tbxRefreshInterval.Text = "30";
            this.tbxRefreshInterval.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxRefreshInterval.ToolTipText = "Refresh interval in seconds [5-60].";
            this.tbxRefreshInterval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbxRefreshIntervalKeyUp);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(44, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.BtnAboutClick);
            // 
            // tbxPositions
            // 
            this.tbxPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPositions.Location = new System.Drawing.Point(3, 3);
            this.tbxPositions.Multiline = true;
            this.tbxPositions.Name = "tbxPositions";
            this.tbxPositions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxPositions.Size = new System.Drawing.Size(644, 129);
            this.tbxPositions.TabIndex = 2;
            this.tbxPositions.WordWrap = false;
            // 
            // tbxOrders
            // 
            this.tbxOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOrders.Location = new System.Drawing.Point(3, 138);
            this.tbxOrders.Multiline = true;
            this.tbxOrders.Name = "tbxOrders";
            this.tbxOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOrders.Size = new System.Drawing.Size(644, 130);
            this.tbxOrders.TabIndex = 3;
            this.tbxOrders.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.44828F));
            this.tableLayoutPanel1.Controls.Add(this.tbxPositions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxOrders, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 271);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusPath,
            this.lblStatusUpdatedText,
            this.lblStatusUpdatedTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(650, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusPath
            // 
            this.lblStatusPath.Name = "lblStatusPath";
            this.lblStatusPath.Size = new System.Drawing.Size(515, 17);
            this.lblStatusPath.Spring = true;
            this.lblStatusPath.Text = "Logs folder: ";
            this.lblStatusPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusUpdatedText
            // 
            this.lblStatusUpdatedText.Name = "lblStatusUpdatedText";
            this.lblStatusUpdatedText.Size = new System.Drawing.Size(95, 17);
            this.lblStatusUpdatedText.Text = "Updated before: ";
            // 
            // lblStatusUpdatedTime
            // 
            this.lblStatusUpdatedTime.AutoSize = false;
            this.lblStatusUpdatedTime.Name = "lblStatusUpdatedTime";
            this.lblStatusUpdatedTime.Size = new System.Drawing.Size(25, 17);
            // 
            // FormLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 352);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbxAccount);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormLogViewer";
            this.Text = "FST Log Viewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefreshLogs;
        public System.Windows.Forms.ToolStripTextBox tbxRefreshInterval;
        public System.Windows.Forms.TextBox tbxPositions;
        public System.Windows.Forms.TextBox tbxOrders;
        private System.Windows.Forms.ToolStripButton btnSetFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUpdatedText;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUpdatedTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusPath;
        private System.Windows.Forms.ToolStripButton btnAbout;
    }
}

