namespace makler_qlav
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elanıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menzilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butunMelumatlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Axtarish = new System.Windows.Forms.Button();
            this.Sondur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.EtrafliAxtaris = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Sil = new System.Windows.Forms.Button();
            this.AxtarisPanel = new System.Windows.Forms.Button();
            this.Elave = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.elanıSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editToolStripMenuItem.Text = "Düzəliş et";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.DuzelishEt);
            // 
            // elanıSilToolStripMenuItem
            // 
            this.elanıSilToolStripMenuItem.Name = "elanıSilToolStripMenuItem";
            this.elanıSilToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.elanıSilToolStripMenuItem.Text = "Elanı sil";
            this.elanıSilToolStripMenuItem.Click += new System.EventHandler(this.ElaniSil);
            // 
            // menzilToolStripMenuItem
            // 
            this.menzilToolStripMenuItem.Name = "menzilToolStripMenuItem";
            this.menzilToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.menzilToolStripMenuItem.Text = "menzil";
            this.menzilToolStripMenuItem.Click += new System.EventHandler(this.menzilToolStripMenuItem_Click);
            // 
            // butunMelumatlarToolStripMenuItem
            // 
            this.butunMelumatlarToolStripMenuItem.Name = "butunMelumatlarToolStripMenuItem";
            this.butunMelumatlarToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.butunMelumatlarToolStripMenuItem.Text = "Butun melumatlar";
            this.butunMelumatlarToolStripMenuItem.Click += new System.EventHandler(this.ButunMelumatlar);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(502, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 42;
            this.textBox3.Text = "max";
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(396, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.Text = "min";
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butunMelumatlarToolStripMenuItem,
            this.menzilToolStripMenuItem,
            this.bagToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bagToolStripMenuItem
            // 
            this.bagToolStripMenuItem.Name = "bagToolStripMenuItem";
            this.bagToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.bagToolStripMenuItem.Text = "bag";
            this.bagToolStripMenuItem.Click += new System.EventHandler(this.bagToolStripMenuItem_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(393, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 28);
            this.label12.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Axtarish);
            this.groupBox1.Controls.Add(this.Sondur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkedListBox2);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(25, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 98);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // Axtarish
            // 
            this.Axtarish.Location = new System.Drawing.Point(235, 69);
            this.Axtarish.Name = "Axtarish";
            this.Axtarish.Size = new System.Drawing.Size(49, 23);
            this.Axtarish.TabIndex = 64;
            this.Axtarish.Text = "Axtarış";
            this.Axtarish.UseVisualStyleBackColor = true;
            this.Axtarish.Click += new System.EventHandler(this.Axtaris);
            // 
            // Sondur
            // 
            this.Sondur.BackColor = System.Drawing.Color.Red;
            this.Sondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sondur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sondur.Location = new System.Drawing.Point(251, 8);
            this.Sondur.Name = "Sondur";
            this.Sondur.Size = new System.Drawing.Size(33, 25);
            this.Sondur.TabIndex = 64;
            this.Sondur.Text = "X";
            this.Sondur.UseVisualStyleBackColor = false;
            this.Sondur.Click += new System.EventHandler(this.Sondur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Otaq sayı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Əmlakın növü";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.checkedListBox2.Location = new System.Drawing.Point(156, 24);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(72, 49);
            this.checkedListBox2.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Mənzil",
            "Ofis",
            "Ev / villa",
            "Bağ",
            "Qaraj",
            "Torpaq",
            "Obyekt"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(143, 47);
            this.checkedListBox1.TabIndex = 55;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // EtrafliAxtaris
            // 
            this.EtrafliAxtaris.Location = new System.Drawing.Point(159, 29);
            this.EtrafliAxtaris.Name = "EtrafliAxtaris";
            this.EtrafliAxtaris.Size = new System.Drawing.Size(94, 23);
            this.EtrafliAxtaris.TabIndex = 63;
            this.EtrafliAxtaris.Text = "Ətrafli Axtarış";
            this.EtrafliAxtaris.UseVisualStyleBackColor = true;
            this.EtrafliAxtaris.Click += new System.EventHandler(this.EtrafliAxtarish);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.kryptonNumericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.EtrafliAxtaris);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Sil);
            this.splitContainer1.Panel1.Controls.Add(this.AxtarisPanel);
            this.splitContainer1.Panel1.Controls.Add(this.Elave);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(809, 390);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(502, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(608, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.Red;
            this.Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sil.Location = new System.Drawing.Point(61, 29);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(33, 27);
            this.Sil.TabIndex = 11;
            this.Sil.Text = "X";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.ButunMelumatlariSil);
            // 
            // AxtarisPanel
            // 
            this.AxtarisPanel.Location = new System.Drawing.Point(100, 29);
            this.AxtarisPanel.Name = "AxtarisPanel";
            this.AxtarisPanel.Size = new System.Drawing.Size(49, 23);
            this.AxtarisPanel.TabIndex = 10;
            this.AxtarisPanel.Text = "Axtarış";
            this.AxtarisPanel.UseVisualStyleBackColor = true;
            this.AxtarisPanel.Click += new System.EventHandler(this.AxtarisPanell);
            // 
            // Elave
            // 
            this.Elave.BackColor = System.Drawing.Color.Blue;
            this.Elave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Elave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Elave.Location = new System.Drawing.Point(11, 27);
            this.Elave.Name = "Elave";
            this.Elave.Size = new System.Drawing.Size(43, 29);
            this.Elave.TabIndex = 8;
            this.Elave.Text = "+";
            this.Elave.UseVisualStyleBackColor = false;
            this.Elave.Click += new System.EventHandler(this.Elave_et);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(809, 176);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(386, 135);
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.kryptonNumericUpDown1.TabIndex = 64;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(809, 390);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Esasseyfe);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elanıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menzilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butunMelumatlarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bagToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Axtarish;
        private System.Windows.Forms.Button Sondur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button EtrafliAxtaris;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button AxtarisPanel;
        public System.Windows.Forms.Button Elave;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
    }
}

