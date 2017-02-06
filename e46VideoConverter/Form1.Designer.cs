namespace e46VideoConverter {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboardButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.convertingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logopanel = new System.Windows.Forms.Panel();
            this.appLabel = new System.Windows.Forms.Label();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reduceLabel = new System.Windows.Forms.Label();
            this.activeTabLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.elipsedForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.draggableForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.container = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Controls.Add(this.aboutButton);
            this.sidepanel.Controls.Add(this.dashboardButton);
            this.sidepanel.Controls.Add(this.convertingButton);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 39);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(171, 349);
            this.sidepanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 54);
            this.panel1.TabIndex = 4;
            // 
            // aboutButton
            // 
            this.aboutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutButton.BorderRadius = 0;
            this.aboutButton.ButtonText = "          About";
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.DisabledColor = System.Drawing.Color.Gray;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.aboutButton.Iconimage = null;
            this.aboutButton.Iconimage_right = null;
            this.aboutButton.Iconimage_right_Selected = null;
            this.aboutButton.Iconimage_Selected = null;
            this.aboutButton.IconMarginLeft = 0;
            this.aboutButton.IconMarginRight = 0;
            this.aboutButton.IconRightVisible = true;
            this.aboutButton.IconRightZoom = 0D;
            this.aboutButton.IconVisible = true;
            this.aboutButton.IconZoom = 90D;
            this.aboutButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aboutButton.IsTab = true;
            this.aboutButton.Location = new System.Drawing.Point(0, 84);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(6);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.aboutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.aboutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.aboutButton.selected = false;
            this.aboutButton.Size = new System.Drawing.Size(171, 42);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "          About";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Textcolor = System.Drawing.Color.LightGray;
            this.aboutButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dashboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardButton.BorderRadius = 0;
            this.dashboardButton.ButtonText = "          Dashboard";
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.DisabledColor = System.Drawing.Color.Gray;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboardButton.Iconimage = null;
            this.dashboardButton.Iconimage_right = null;
            this.dashboardButton.Iconimage_right_Selected = null;
            this.dashboardButton.Iconimage_Selected = null;
            this.dashboardButton.IconMarginLeft = 0;
            this.dashboardButton.IconMarginRight = 0;
            this.dashboardButton.IconRightVisible = true;
            this.dashboardButton.IconRightZoom = 0D;
            this.dashboardButton.IconVisible = true;
            this.dashboardButton.IconZoom = 90D;
            this.dashboardButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dashboardButton.IsTab = true;
            this.dashboardButton.Location = new System.Drawing.Point(0, 42);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(6);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dashboardButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.dashboardButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dashboardButton.selected = false;
            this.dashboardButton.Size = new System.Drawing.Size(171, 42);
            this.dashboardButton.TabIndex = 2;
            this.dashboardButton.Text = "          Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Textcolor = System.Drawing.Color.LightGray;
            this.dashboardButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // convertingButton
            // 
            this.convertingButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.convertingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.convertingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convertingButton.BorderRadius = 0;
            this.convertingButton.ButtonText = "          Converting";
            this.convertingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertingButton.DisabledColor = System.Drawing.Color.Gray;
            this.convertingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertingButton.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertingButton.Iconcolor = System.Drawing.Color.Transparent;
            this.convertingButton.Iconimage = null;
            this.convertingButton.Iconimage_right = null;
            this.convertingButton.Iconimage_right_Selected = null;
            this.convertingButton.Iconimage_Selected = null;
            this.convertingButton.IconMarginLeft = 0;
            this.convertingButton.IconMarginRight = 0;
            this.convertingButton.IconRightVisible = true;
            this.convertingButton.IconRightZoom = 0D;
            this.convertingButton.IconVisible = true;
            this.convertingButton.IconZoom = 90D;
            this.convertingButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.convertingButton.IsTab = true;
            this.convertingButton.Location = new System.Drawing.Point(0, 0);
            this.convertingButton.Margin = new System.Windows.Forms.Padding(6);
            this.convertingButton.Name = "convertingButton";
            this.convertingButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.convertingButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.convertingButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.convertingButton.selected = true;
            this.convertingButton.Size = new System.Drawing.Size(171, 42);
            this.convertingButton.TabIndex = 1;
            this.convertingButton.Text = "          Converting";
            this.convertingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.convertingButton.Textcolor = System.Drawing.Color.LightGray;
            this.convertingButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertingButton.Load += new System.EventHandler(this.convertingButton_Load);
            this.convertingButton.Click += new System.EventHandler(this.convertingButton_Click);
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.logopanel.Controls.Add(this.appLabel);
            this.logopanel.Controls.Add(this.appLogo);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(171, 39);
            this.logopanel.TabIndex = 0;
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.BackColor = System.Drawing.Color.Transparent;
            this.appLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.ForeColor = System.Drawing.Color.White;
            this.appLabel.Location = new System.Drawing.Point(38, 9);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(129, 21);
            this.appLabel.TabIndex = 0;
            this.appLabel.Text = "Jin-K Converter";
            // 
            // appLogo
            // 
            this.appLogo.Image = global::e46VideoConverter.Properties.Resources.logo_bmw;
            this.appLogo.Location = new System.Drawing.Point(5, 6);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(35, 29);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 1;
            this.appLogo.TabStop = false;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.White;
            this.headerpanel.Controls.Add(this.logopanel);
            this.headerpanel.Controls.Add(this.pictureBox1);
            this.headerpanel.Controls.Add(this.reduceLabel);
            this.headerpanel.Controls.Add(this.activeTabLabel);
            this.headerpanel.Controls.Add(this.closeLabel);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(817, 39);
            this.headerpanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::e46VideoConverter.Properties.Resources.square_individual_nine_7;
            this.pictureBox1.Location = new System.Drawing.Point(185, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // reduceLabel
            // 
            this.reduceLabel.AutoSize = true;
            this.reduceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.reduceLabel.Location = new System.Drawing.Point(775, 8);
            this.reduceLabel.Name = "reduceLabel";
            this.reduceLabel.Size = new System.Drawing.Size(15, 21);
            this.reduceLabel.TabIndex = 4;
            this.reduceLabel.Text = "-";
            // 
            // activeTabLabel
            // 
            this.activeTabLabel.AutoSize = true;
            this.activeTabLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeTabLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.activeTabLabel.Location = new System.Drawing.Point(215, 9);
            this.activeTabLabel.Margin = new System.Windows.Forms.Padding(0);
            this.activeTabLabel.Name = "activeTabLabel";
            this.activeTabLabel.Size = new System.Drawing.Size(94, 19);
            this.activeTabLabel.TabIndex = 2;
            this.activeTabLabel.Text = "Converting";
            this.activeTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.closeLabel.Location = new System.Drawing.Point(790, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(19, 21);
            this.closeLabel.TabIndex = 3;
            this.closeLabel.Text = "X";
            // 
            // elipsedForm
            // 
            this.elipsedForm.ElipseRadius = 20;
            this.elipsedForm.TargetControl = this;
            // 
            // draggableForm
            // 
            this.draggableForm.Fixed = true;
            this.draggableForm.Horizontal = true;
            this.draggableForm.TargetControl = this.headerpanel;
            this.draggableForm.Vertical = true;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(171, 39);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(646, 349);
            this.container.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(817, 388);
            this.Controls.Add(this.container);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.sidepanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.PictureBox appLogo;
        private Bunifu.Framework.UI.BunifuFlatButton aboutButton;
        private Bunifu.Framework.UI.BunifuFlatButton dashboardButton;
        private Bunifu.Framework.UI.BunifuFlatButton convertingButton;
        private System.Windows.Forms.Label reduceLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label activeTabLabel;
        private Bunifu.Framework.UI.BunifuElipse elipsedForm;
        private Bunifu.Framework.UI.BunifuDragControl draggableForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

