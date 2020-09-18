namespace Segregacja
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SegregacjaPrintPreviewControl = new System.Windows.Forms.PrintPreviewControl();
            this.BootleType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoQueryShiftNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.YesQueryShiftNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.DateComboBox = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SegregacjaRestoreDate = new System.Windows.Forms.Button();
            this.SegregacjaImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxShiftNumber = new System.Windows.Forms.GroupBox();
            this.ShiftNumber = new System.Windows.Forms.ComboBox();
            this.SegregacjaPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.zoomin = new System.Windows.Forms.Button();
            this.zoomout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SegregacjaNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SegregacjaMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuNotifyAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNotifyPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuNotifyClose = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ballonTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxShiftNumber.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SegregacjaMenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // SegregacjaPrintPreviewControl
            // 
            this.SegregacjaPrintPreviewControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.SegregacjaPrintPreviewControl.Location = new System.Drawing.Point(519, 0);
            this.SegregacjaPrintPreviewControl.MinimumSize = new System.Drawing.Size(281, 450);
            this.SegregacjaPrintPreviewControl.Name = "SegregacjaPrintPreviewControl";
            this.SegregacjaPrintPreviewControl.Size = new System.Drawing.Size(281, 450);
            this.SegregacjaPrintPreviewControl.TabIndex = 0;
            // 
            // BootleType
            // 
            this.BootleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BootleType.FormattingEnabled = true;
            this.BootleType.Items.AddRange(new object[] {
            "ALASKA",
            "CROWN",
            "GOLD",
            "LIKWIDACJA",
            "MIX",
            "NOWY ŻYWIEC",
            "OBCE",
            "OKOCIM",
            "STARY ŻYWIEC"});
            this.BootleType.Location = new System.Drawing.Point(15, 36);
            this.BootleType.Name = "BootleType";
            this.BootleType.Size = new System.Drawing.Size(194, 28);
            this.BootleType.Sorted = true;
            this.BootleType.TabIndex = 1;
            this.BootleType.Text = "Wybierz typ butelki...";
            this.BootleType.SelectedIndexChanged += new System.EventHandler(this.BootleType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoQueryShiftNumberRadioButton);
            this.groupBox1.Controls.Add(this.YesQueryShiftNumberRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(38, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Czy drukować nr zmiany?";
            // 
            // NoQueryShiftNumberRadioButton
            // 
            this.NoQueryShiftNumberRadioButton.AutoSize = true;
            this.NoQueryShiftNumberRadioButton.Checked = true;
            this.NoQueryShiftNumberRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoQueryShiftNumberRadioButton.Location = new System.Drawing.Point(118, 31);
            this.NoQueryShiftNumberRadioButton.Name = "NoQueryShiftNumberRadioButton";
            this.NoQueryShiftNumberRadioButton.Size = new System.Drawing.Size(50, 24);
            this.NoQueryShiftNumberRadioButton.TabIndex = 2;
            this.NoQueryShiftNumberRadioButton.TabStop = true;
            this.NoQueryShiftNumberRadioButton.Text = "Nie";
            this.NoQueryShiftNumberRadioButton.UseVisualStyleBackColor = true;
            this.NoQueryShiftNumberRadioButton.CheckedChanged += new System.EventHandler(this.NoQueryShiftNumberRadioButton_CheckedChanged);
            // 
            // YesQueryShiftNumberRadioButton
            // 
            this.YesQueryShiftNumberRadioButton.AutoSize = true;
            this.YesQueryShiftNumberRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YesQueryShiftNumberRadioButton.Location = new System.Drawing.Point(56, 31);
            this.YesQueryShiftNumberRadioButton.Name = "YesQueryShiftNumberRadioButton";
            this.YesQueryShiftNumberRadioButton.Size = new System.Drawing.Size(53, 24);
            this.YesQueryShiftNumberRadioButton.TabIndex = 3;
            this.YesQueryShiftNumberRadioButton.Text = "Tak";
            this.YesQueryShiftNumberRadioButton.UseVisualStyleBackColor = true;
            this.YesQueryShiftNumberRadioButton.CheckedChanged += new System.EventHandler(this.YesQueryShiftNumberRadioButton_CheckedChanged);
            // 
            // DateComboBox
            // 
            this.DateComboBox.CustomFormat = "dd.mm.yyyy";
            this.DateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateComboBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateComboBox.Location = new System.Drawing.Point(29, 34);
            this.DateComboBox.Name = "DateComboBox";
            this.DateComboBox.Size = new System.Drawing.Size(142, 26);
            this.DateComboBox.TabIndex = 5;
            this.DateComboBox.Value = new System.DateTime(2019, 11, 16, 0, 0, 0, 0);
            this.DateComboBox.ValueChanged += new System.EventHandler(this.DateComboBox_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BootleType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(38, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Typ butelek:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SegregacjaRestoreDate);
            this.groupBox3.Controls.Add(this.DateComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(38, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wybierz datę:";
            // 
            // SegregacjaRestoreDate
            // 
            this.SegregacjaRestoreDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SegregacjaRestoreDate.ImageIndex = 2;
            this.SegregacjaRestoreDate.ImageList = this.SegregacjaImageList;
            this.SegregacjaRestoreDate.Location = new System.Drawing.Point(185, 20);
            this.SegregacjaRestoreDate.Name = "SegregacjaRestoreDate";
            this.SegregacjaRestoreDate.Size = new System.Drawing.Size(51, 50);
            this.SegregacjaRestoreDate.TabIndex = 11;
            this.SegregacjaRestoreDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ballonTip.SetToolTip(this.SegregacjaRestoreDate, "Resetuj do aktualnej daty");
            this.SegregacjaRestoreDate.UseVisualStyleBackColor = true;
            this.SegregacjaRestoreDate.Click += new System.EventHandler(this.SegregacjaRestoreDate_Click);
            // 
            // SegregacjaImageList
            // 
            this.SegregacjaImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SegregacjaImageList.ImageStream")));
            this.SegregacjaImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.SegregacjaImageList.Images.SetKeyName(0, "lens (1).png");
            this.SegregacjaImageList.Images.SetKeyName(1, "zoom.png");
            this.SegregacjaImageList.Images.SetKeyName(2, "RestoreDate.ico");
            this.SegregacjaImageList.Images.SetKeyName(3, "print.png");
            // 
            // groupBoxShiftNumber
            // 
            this.groupBoxShiftNumber.Controls.Add(this.ShiftNumber);
            this.groupBoxShiftNumber.Enabled = false;
            this.groupBoxShiftNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxShiftNumber.Location = new System.Drawing.Point(38, 240);
            this.groupBoxShiftNumber.Name = "groupBoxShiftNumber";
            this.groupBoxShiftNumber.Size = new System.Drawing.Size(200, 84);
            this.groupBoxShiftNumber.TabIndex = 7;
            this.groupBoxShiftNumber.TabStop = false;
            this.groupBoxShiftNumber.Text = "Nr zmiany:";
            // 
            // ShiftNumber
            // 
            this.ShiftNumber.DisplayMember = "0";
            this.ShiftNumber.FormattingEnabled = true;
            this.ShiftNumber.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.ShiftNumber.Location = new System.Drawing.Point(66, 35);
            this.ShiftNumber.Name = "ShiftNumber";
            this.ShiftNumber.Size = new System.Drawing.Size(69, 28);
            this.ShiftNumber.Sorted = true;
            this.ShiftNumber.TabIndex = 4;
            this.ShiftNumber.Tag = "";
            this.ShiftNumber.SelectedIndexChanged += new System.EventHandler(this.ShiftNumber_SelectedIndexChanged);
            // 
            // SegregacjaPrintDocument
            // 
            this.SegregacjaPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.SegregacjaPrintDocument_PrintPage);
            // 
            // zoomin
            // 
            this.zoomin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomin.ImageIndex = 0;
            this.zoomin.ImageList = this.SegregacjaImageList;
            this.zoomin.Location = new System.Drawing.Point(3, 172);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(51, 48);
            this.zoomin.TabIndex = 8;
            this.zoomin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ballonTip.SetToolTip(this.zoomin, "Powiększ podgląd");
            this.zoomin.UseVisualStyleBackColor = true;
            this.zoomin.Click += new System.EventHandler(this.Zoomin_Click);
            // 
            // zoomout
            // 
            this.zoomout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomout.ImageIndex = 1;
            this.zoomout.ImageList = this.SegregacjaImageList;
            this.zoomout.Location = new System.Drawing.Point(3, 225);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(51, 50);
            this.zoomout.TabIndex = 9;
            this.zoomout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ballonTip.SetToolTip(this.zoomout, "Pomniejsz podgląd");
            this.zoomout.UseVisualStyleBackColor = true;
            this.zoomout.Click += new System.EventHandler(this.Zoomout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.zoomin);
            this.panel1.Controls.Add(this.zoomout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(460, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 450);
            this.panel1.TabIndex = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.ImageIndex = 3;
            this.btnPrint.ImageList = this.SegregacjaImageList;
            this.btnPrint.Location = new System.Drawing.Point(3, 281);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(51, 50);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ballonTip.SetToolTip(this.btnPrint, "Wydrukuj stronę");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // SegregacjaNotifyIcon
            // 
            this.SegregacjaNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SegregacjaNotifyIcon.BalloonTipText = "Segregacja v.1.0";
            this.SegregacjaNotifyIcon.BalloonTipTitle = "Info";
            this.SegregacjaNotifyIcon.ContextMenuStrip = this.SegregacjaMenuNotify;
            this.SegregacjaNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SegregacjaNotifyIcon.Icon")));
            this.SegregacjaNotifyIcon.Text = "Segregacja";
            this.SegregacjaNotifyIcon.Visible = true;
            // 
            // SegregacjaMenuNotify
            // 
            this.SegregacjaMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNotifyAbout,
            this.MenuNotifyPrint,
            this.toolStripSeparator1,
            this.MenuNotifyClose});
            this.SegregacjaMenuNotify.Name = "SegregacjaMenuNotify";
            this.SegregacjaMenuNotify.Size = new System.Drawing.Size(151, 76);
            // 
            // MenuNotifyAbout
            // 
            this.MenuNotifyAbout.Name = "MenuNotifyAbout";
            this.MenuNotifyAbout.Size = new System.Drawing.Size(150, 22);
            this.MenuNotifyAbout.Text = "&O programie...";
            this.MenuNotifyAbout.Click += new System.EventHandler(this.MenuNotifyAbout_Click);
            // 
            // MenuNotifyPrint
            // 
            this.MenuNotifyPrint.Name = "MenuNotifyPrint";
            this.MenuNotifyPrint.Size = new System.Drawing.Size(150, 22);
            this.MenuNotifyPrint.Text = "&Drukuj";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // MenuNotifyClose
            // 
            this.MenuNotifyClose.Name = "MenuNotifyClose";
            this.MenuNotifyClose.Size = new System.Drawing.Size(150, 22);
            this.MenuNotifyClose.Tag = "0";
            this.MenuNotifyClose.Text = "&Zamknij";
            this.MenuNotifyClose.Click += new System.EventHandler(this.MenuNotifyClose_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ballonTip
            // 
            this.ballonTip.IsBalloon = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxShiftNumber);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SegregacjaPrintPreviewControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Segregacja v.1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxShiftNumber.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SegregacjaMenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl SegregacjaPrintPreviewControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NoQueryShiftNumberRadioButton;
        private System.Windows.Forms.RadioButton YesQueryShiftNumberRadioButton;
        private System.Windows.Forms.ComboBox BootleType;
        private System.Windows.Forms.DateTimePicker DateComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxShiftNumber;
        private System.Windows.Forms.ComboBox ShiftNumber;
        private System.Drawing.Printing.PrintDocument SegregacjaPrintDocument;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Button zoomout;
        private System.Windows.Forms.ImageList SegregacjaImageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon SegregacjaNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip SegregacjaMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem MenuNotifyAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuNotifyPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuNotifyClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button SegregacjaRestoreDate;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolTip ballonTip;
    }
}

