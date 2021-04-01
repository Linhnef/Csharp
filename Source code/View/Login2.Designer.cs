namespace View
{
    partial class Login2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.admin_check = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id_Card = new System.Windows.Forms.TextBox();
            this.user_Data = new System.Windows.Forms.TextBox();
            this.password_Data = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.admin_check);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản trị viên";
            // 
            // admin_check
            // 
            this.admin_check.AutoSize = true;
            this.admin_check.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_check.Location = new System.Drawing.Point(18, 20);
            this.admin_check.Name = "admin_check";
            this.admin_check.Size = new System.Drawing.Size(58, 19);
            this.admin_check.TabIndex = 0;
            this.admin_check.Text = "Admin";
            this.admin_check.UseVisualStyleBackColor = true;
            this.admin_check.CheckedChanged += new System.EventHandler(this.admin_check_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(270, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(299, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_Card
            // 
            this.id_Card.ForeColor = System.Drawing.Color.Gray;
            this.id_Card.Location = new System.Drawing.Point(57, 377);
            this.id_Card.Name = "id_Card";
            this.id_Card.Size = new System.Drawing.Size(205, 20);
            this.id_Card.TabIndex = 19;
            this.id_Card.Text = "Mã số giấy phép lái xe.";
            this.id_Card.Leave += new System.EventHandler(this.id_Card_Leave);
            this.id_Card.MouseEnter += new System.EventHandler(this.id_Card_MouseEnter);
            // 
            // user_Data
            // 
            this.user_Data.ForeColor = System.Drawing.Color.Gray;
            this.user_Data.Location = new System.Drawing.Point(57, 403);
            this.user_Data.Name = "user_Data";
            this.user_Data.Size = new System.Drawing.Size(205, 20);
            this.user_Data.TabIndex = 20;
            this.user_Data.Text = "Tên đăng nhập.";
            this.user_Data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.user_Data_MouseClick);
            this.user_Data.Leave += new System.EventHandler(this.user_Data_Leave);
            // 
            // password_Data
            // 
            this.password_Data.ForeColor = System.Drawing.Color.Gray;
            this.password_Data.Location = new System.Drawing.Point(57, 429);
            this.password_Data.Name = "password_Data";
            this.password_Data.Size = new System.Drawing.Size(205, 20);
            this.password_Data.TabIndex = 21;
            this.password_Data.Text = "Mật khẩu.";
            this.password_Data.UseSystemPasswordChar = true;
            this.password_Data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_Data_MouseClick);
            this.password_Data.Leave += new System.EventHandler(this.password_Data_Leave);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(57, 455);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(90, 23);
            this.button_login.TabIndex = 22;
            this.button_login.Text = "Đăng nhập";
            this.button_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Location = new System.Drawing.Point(153, 455);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(87, 23);
            this.button_Register.TabIndex = 23;
            this.button_Register.Text = "Đăng ký";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(115, 500);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 15);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(331, 608);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.password_Data);
            this.Controls.Add(this.user_Data);
            this.Controls.Add(this.id_Card);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login2_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox admin_check;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id_Card;
        private System.Windows.Forms.TextBox user_Data;
        private System.Windows.Forms.TextBox password_Data;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}