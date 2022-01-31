namespace HMS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.accessTokenTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.signInButton = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(718, 99);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(458, 448);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gunaLabel4.Location = new System.Drawing.Point(882, 640);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(133, 17);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Beta Version 20.2.1";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gunaLabel3.Location = new System.Drawing.Point(904, 612);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(87, 25);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Handler";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gunaShadowPanel1.Controls.Add(this.confirmButton);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel7);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel6);
            this.gunaShadowPanel1.Controls.Add(this.accessTokenTextBox);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel5);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Controls.Add(this.passwordTextBox);
            this.gunaShadowPanel1.Controls.Add(this.usernameTextBox);
            this.gunaShadowPanel1.Controls.Add(this.signInButton);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(189, 39);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(373, 582);
            this.gunaShadowPanel1.TabIndex = 5;
            // 
            // confirmButton
            // 
            this.confirmButton.BorderRadius = 12;
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(186)))), ((int)(((byte)(133)))));
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(53, 500);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(264, 45);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gunaLabel7.Location = new System.Drawing.Point(131, 307);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(109, 20);
            this.gunaLabel7.TabIndex = 4;
            this.gunaLabel7.Text = "Access Token";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel7.Visible = false;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gunaLabel6.Location = new System.Drawing.Point(146, 351);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(78, 20);
            this.gunaLabel6.TabIndex = 4;
            this.gunaLabel6.Text = "Password";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accessTokenTextBox
            // 
            this.accessTokenTextBox.BorderRadius = 12;
            this.accessTokenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.accessTokenTextBox.DefaultText = "";
            this.accessTokenTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.accessTokenTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.accessTokenTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.accessTokenTextBox.DisabledState.Parent = this.accessTokenTextBox;
            this.accessTokenTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.accessTokenTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.accessTokenTextBox.FocusedState.Parent = this.accessTokenTextBox;
            this.accessTokenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.accessTokenTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.accessTokenTextBox.HoverState.Parent = this.accessTokenTextBox;
            this.accessTokenTextBox.Location = new System.Drawing.Point(53, 339);
            this.accessTokenTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accessTokenTextBox.Name = "accessTokenTextBox";
            this.accessTokenTextBox.PasswordChar = '\0';
            this.accessTokenTextBox.PlaceholderText = "";
            this.accessTokenTextBox.SelectedText = "";
            this.accessTokenTextBox.ShadowDecoration.Parent = this.accessTokenTextBox;
            this.accessTokenTextBox.Size = new System.Drawing.Size(264, 39);
            this.accessTokenTextBox.TabIndex = 6;
            this.accessTokenTextBox.Visible = false;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gunaLabel5.Location = new System.Drawing.Point(144, 264);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(83, 20);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Username";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gunaLabel2.Location = new System.Drawing.Point(81, 123);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(208, 60);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Proceed with your\r\neasy-to-remember usename\r\nand password";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderRadius = 12;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.Parent = this.passwordTextBox;
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
            this.passwordTextBox.Location = new System.Drawing.Point(53, 383);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
            this.passwordTextBox.Size = new System.Drawing.Size(264, 39);
            this.passwordTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderRadius = 12;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.Parent = this.usernameTextBox;
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
            this.usernameTextBox.Location = new System.Drawing.Point(53, 296);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(264, 39);
            this.usernameTextBox.TabIndex = 3;
            // 
            // signInButton
            // 
            this.signInButton.BorderRadius = 12;
            this.signInButton.CheckedState.Parent = this.signInButton;
            this.signInButton.CustomImages.Parent = this.signInButton;
            this.signInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(186)))), ((int)(((byte)(133)))));
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.HoverState.Parent = this.signInButton;
            this.signInButton.Location = new System.Drawing.Point(53, 500);
            this.signInButton.Name = "signInButton";
            this.signInButton.ShadowDecoration.Parent = this.signInButton;
            this.signInButton.Size = new System.Drawing.Size(264, 45);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Go";
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(91, 36);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(189, 59);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Sign In";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 705);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private Guna.UI2.WinForms.Guna2Button signInButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox accessTokenTextBox;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
    }
}