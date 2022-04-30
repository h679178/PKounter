namespace PokemonCounter
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.PNL_CONTENT = new System.Windows.Forms.Panel();
            this.PNL_DISPLAY = new System.Windows.Forms.Panel();
            this.PNL_DISPLAY_UNDERLINE = new System.Windows.Forms.Panel();
            this.TBL_DISPLAY = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_VERTICAL = new System.Windows.Forms.Label();
            this.CKB_AOT = new System.Windows.Forms.CheckBox();
            this.CKB_OOF = new System.Windows.Forms.CheckBox();
            this.LBL_COLOR_ACCENT = new System.Windows.Forms.Label();
            this.PNL_ACCENTCOLOR = new System.Windows.Forms.Panel();
            this.PNL_MAINCOLOR = new System.Windows.Forms.Panel();
            this.LBL_COLOR_MAIN = new System.Windows.Forms.Label();
            this.CB_VERTICAL = new System.Windows.Forms.ComboBox();
            this.LBL_DISPLAY = new System.Windows.Forms.Label();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.BT_APPLY = new System.Windows.Forms.Button();
            this.PNL_MENU = new System.Windows.Forms.Panel();
            this.BT_MINIMIZE = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.CDG_BACKGROUND = new System.Windows.Forms.ColorDialog();
            this.PNL_CONTENT.SuspendLayout();
            this.PNL_DISPLAY.SuspendLayout();
            this.TBL_DISPLAY.SuspendLayout();
            this.PNL_MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_CONTENT
            // 
            this.PNL_CONTENT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNL_CONTENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CONTENT.Controls.Add(this.PNL_DISPLAY);
            this.PNL_CONTENT.Controls.Add(this.BT_CANCEL);
            this.PNL_CONTENT.Controls.Add(this.BT_APPLY);
            this.PNL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CONTENT.Location = new System.Drawing.Point(0, 35);
            this.PNL_CONTENT.Name = "PNL_CONTENT";
            this.PNL_CONTENT.Size = new System.Drawing.Size(283, 231);
            this.PNL_CONTENT.TabIndex = 31;
            // 
            // PNL_DISPLAY
            // 
            this.PNL_DISPLAY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_DISPLAY.Controls.Add(this.PNL_DISPLAY_UNDERLINE);
            this.PNL_DISPLAY.Controls.Add(this.CKB_AOT);
            this.PNL_DISPLAY.Controls.Add(this.CKB_OOF);
            this.PNL_DISPLAY.Controls.Add(this.TBL_DISPLAY);
            this.PNL_DISPLAY.Controls.Add(this.LBL_DISPLAY);
            this.PNL_DISPLAY.Location = new System.Drawing.Point(6, 5);
            this.PNL_DISPLAY.Name = "PNL_DISPLAY";
            this.PNL_DISPLAY.Size = new System.Drawing.Size(270, 179);
            this.PNL_DISPLAY.TabIndex = 33;
            // 
            // PNL_DISPLAY_UNDERLINE
            // 
            this.PNL_DISPLAY_UNDERLINE.BackColor = System.Drawing.Color.Black;
            this.PNL_DISPLAY_UNDERLINE.Location = new System.Drawing.Point(8, 27);
            this.PNL_DISPLAY_UNDERLINE.Name = "PNL_DISPLAY_UNDERLINE";
            this.PNL_DISPLAY_UNDERLINE.Size = new System.Drawing.Size(150, 2);
            this.PNL_DISPLAY_UNDERLINE.TabIndex = 32;
            // 
            // TBL_DISPLAY
            // 
            this.TBL_DISPLAY.AutoSize = true;
            this.TBL_DISPLAY.ColumnCount = 2;
            this.TBL_DISPLAY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TBL_DISPLAY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBL_DISPLAY.Controls.Add(this.LBL_VERTICAL, 0, 0);
            this.TBL_DISPLAY.Controls.Add(this.CB_VERTICAL, 1, 0);
            this.TBL_DISPLAY.Controls.Add(this.LBL_COLOR_MAIN, 0, 1);
            this.TBL_DISPLAY.Controls.Add(this.PNL_MAINCOLOR, 1, 1);
            this.TBL_DISPLAY.Controls.Add(this.LBL_COLOR_ACCENT, 0, 2);
            this.TBL_DISPLAY.Controls.Add(this.PNL_ACCENTCOLOR, 1, 2);
            this.TBL_DISPLAY.Location = new System.Drawing.Point(10, 90);
            this.TBL_DISPLAY.Name = "TBL_DISPLAY";
            this.TBL_DISPLAY.RowCount = 3;
            this.TBL_DISPLAY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_DISPLAY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_DISPLAY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_DISPLAY.Size = new System.Drawing.Size(249, 81);
            this.TBL_DISPLAY.TabIndex = 32;
            // 
            // LBL_VERTICAL
            // 
            this.LBL_VERTICAL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_VERTICAL.AutoSize = true;
            this.LBL_VERTICAL.Location = new System.Drawing.Point(3, 7);
            this.LBL_VERTICAL.Name = "LBL_VERTICAL";
            this.LBL_VERTICAL.Size = new System.Drawing.Size(41, 13);
            this.LBL_VERTICAL.TabIndex = 37;
            this.LBL_VERTICAL.Text = "Display";
            // 
            // CKB_AOT
            // 
            this.CKB_AOT.AutoSize = true;
            this.CKB_AOT.Checked = true;
            this.CKB_AOT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_AOT.Location = new System.Drawing.Point(16, 42);
            this.CKB_AOT.Name = "CKB_AOT";
            this.CKB_AOT.Size = new System.Drawing.Size(92, 17);
            this.CKB_AOT.TabIndex = 35;
            this.CKB_AOT.Text = "Always on top";
            this.CKB_AOT.UseVisualStyleBackColor = true;
            // 
            // CKB_OOF
            // 
            this.CKB_OOF.Checked = true;
            this.CKB_OOF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_OOF.Location = new System.Drawing.Point(16, 64);
            this.CKB_OOF.Name = "CKB_OOF";
            this.CKB_OOF.Size = new System.Drawing.Size(142, 23);
            this.CKB_OOF.TabIndex = 36;
            this.CKB_OOF.Text = "Catch input out of focus";
            this.CKB_OOF.UseVisualStyleBackColor = true;
            // 
            // LBL_COLOR_ACCENT
            // 
            this.LBL_COLOR_ACCENT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_COLOR_ACCENT.AutoSize = true;
            this.LBL_COLOR_ACCENT.Location = new System.Drawing.Point(3, 61);
            this.LBL_COLOR_ACCENT.Name = "LBL_COLOR_ACCENT";
            this.LBL_COLOR_ACCENT.Size = new System.Drawing.Size(67, 13);
            this.LBL_COLOR_ACCENT.TabIndex = 38;
            this.LBL_COLOR_ACCENT.Text = "Accent color";
            // 
            // PNL_ACCENTCOLOR
            // 
            this.PNL_ACCENTCOLOR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PNL_ACCENTCOLOR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNL_ACCENTCOLOR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PNL_ACCENTCOLOR.Location = new System.Drawing.Point(103, 57);
            this.PNL_ACCENTCOLOR.Name = "PNL_ACCENTCOLOR";
            this.PNL_ACCENTCOLOR.Size = new System.Drawing.Size(21, 20);
            this.PNL_ACCENTCOLOR.TabIndex = 40;
            this.PNL_ACCENTCOLOR.Click += new System.EventHandler(this.PNL_ACCENTCOLOR_Click);
            // 
            // PNL_MAINCOLOR
            // 
            this.PNL_MAINCOLOR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PNL_MAINCOLOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_MAINCOLOR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PNL_MAINCOLOR.Location = new System.Drawing.Point(103, 30);
            this.PNL_MAINCOLOR.Name = "PNL_MAINCOLOR";
            this.PNL_MAINCOLOR.Size = new System.Drawing.Size(21, 20);
            this.PNL_MAINCOLOR.TabIndex = 39;
            this.PNL_MAINCOLOR.Click += new System.EventHandler(this.PNL_MAINCOLOR_Click);
            // 
            // LBL_COLOR_MAIN
            // 
            this.LBL_COLOR_MAIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_COLOR_MAIN.AutoSize = true;
            this.LBL_COLOR_MAIN.Location = new System.Drawing.Point(3, 34);
            this.LBL_COLOR_MAIN.Name = "LBL_COLOR_MAIN";
            this.LBL_COLOR_MAIN.Size = new System.Drawing.Size(56, 13);
            this.LBL_COLOR_MAIN.TabIndex = 36;
            this.LBL_COLOR_MAIN.Text = "Main color";
            // 
            // CB_VERTICAL
            // 
            this.CB_VERTICAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_VERTICAL.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.CB_VERTICAL.Location = new System.Drawing.Point(103, 3);
            this.CB_VERTICAL.Name = "CB_VERTICAL";
            this.CB_VERTICAL.Size = new System.Drawing.Size(99, 21);
            this.CB_VERTICAL.TabIndex = 0;
            // 
            // LBL_DISPLAY
            // 
            this.LBL_DISPLAY.AutoSize = true;
            this.LBL_DISPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DISPLAY.Location = new System.Drawing.Point(7, 8);
            this.LBL_DISPLAY.Name = "LBL_DISPLAY";
            this.LBL_DISPLAY.Size = new System.Drawing.Size(61, 16);
            this.LBL_DISPLAY.TabIndex = 25;
            this.LBL_DISPLAY.Text = "Options";
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CANCEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BT_CANCEL.Location = new System.Drawing.Point(142, 188);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(134, 37);
            this.BT_CANCEL.TabIndex = 27;
            this.BT_CANCEL.Text = "Cancel";
            this.BT_CANCEL.UseVisualStyleBackColor = false;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
            // 
            // BT_APPLY
            // 
            this.BT_APPLY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_APPLY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_APPLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_APPLY.ForeColor = System.Drawing.Color.White;
            this.BT_APPLY.Location = new System.Drawing.Point(5, 188);
            this.BT_APPLY.Name = "BT_APPLY";
            this.BT_APPLY.Size = new System.Drawing.Size(134, 37);
            this.BT_APPLY.TabIndex = 26;
            this.BT_APPLY.Text = "Apply";
            this.BT_APPLY.UseVisualStyleBackColor = false;
            this.BT_APPLY.Click += new System.EventHandler(this.BT_APPLY_Click);
            // 
            // PNL_MENU
            // 
            this.PNL_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_MENU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_MENU.Controls.Add(this.BT_MINIMIZE);
            this.PNL_MENU.Controls.Add(this.BT_CLOSE);
            this.PNL_MENU.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_MENU.Location = new System.Drawing.Point(0, 0);
            this.PNL_MENU.Name = "PNL_MENU";
            this.PNL_MENU.Size = new System.Drawing.Size(283, 35);
            this.PNL_MENU.TabIndex = 30;
            this.PNL_MENU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseDown);
            this.PNL_MENU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseMove);
            this.PNL_MENU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseUp);
            // 
            // BT_MINIMIZE
            // 
            this.BT_MINIMIZE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_MINIMIZE.BackColor = System.Drawing.Color.Transparent;
            this.BT_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MINIMIZE.ForeColor = System.Drawing.Color.White;
            this.BT_MINIMIZE.Image = global::PokemonCounter.Properties.Resources.menu_minimize;
            this.BT_MINIMIZE.Location = new System.Drawing.Point(219, 5);
            this.BT_MINIMIZE.Name = "BT_MINIMIZE";
            this.BT_MINIMIZE.Size = new System.Drawing.Size(25, 25);
            this.BT_MINIMIZE.TabIndex = 21;
            this.BT_MINIMIZE.UseVisualStyleBackColor = false;
            this.BT_MINIMIZE.Click += new System.EventHandler(this.BT_MINIMIZE_Click);
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLOSE.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CLOSE.ForeColor = System.Drawing.Color.White;
            this.BT_CLOSE.Image = global::PokemonCounter.Properties.Resources.menu_close;
            this.BT_CLOSE.Location = new System.Drawing.Point(250, 5);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(25, 25);
            this.BT_CLOSE.TabIndex = 20;
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 266);
            this.Controls.Add(this.PNL_CONTENT);
            this.Controls.Add(this.PNL_MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.PNL_CONTENT.ResumeLayout(false);
            this.PNL_DISPLAY.ResumeLayout(false);
            this.PNL_DISPLAY.PerformLayout();
            this.TBL_DISPLAY.ResumeLayout(false);
            this.TBL_DISPLAY.PerformLayout();
            this.PNL_MENU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_CONTENT;
        private System.Windows.Forms.Panel PNL_DISPLAY;
        private System.Windows.Forms.Panel PNL_DISPLAY_UNDERLINE;
        private System.Windows.Forms.TableLayoutPanel TBL_DISPLAY;
        private System.Windows.Forms.Label LBL_DISPLAY;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.Button BT_APPLY;
        private System.Windows.Forms.Panel PNL_MENU;
        private System.Windows.Forms.Button BT_MINIMIZE;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.Label LBL_COLOR_MAIN;
        public System.Windows.Forms.Panel PNL_MAINCOLOR;
        private System.Windows.Forms.ColorDialog CDG_BACKGROUND;
        public System.Windows.Forms.CheckBox CKB_AOT;
        public System.Windows.Forms.CheckBox CKB_OOF;
        private System.Windows.Forms.Label LBL_COLOR_ACCENT;
        public System.Windows.Forms.Panel PNL_ACCENTCOLOR;
        private System.Windows.Forms.ComboBox CB_VERTICAL;
        private System.Windows.Forms.Label LBL_VERTICAL;
    }
}