namespace View
{
    partial class Register
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
            this.ID_data = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.use_name_data = new System.Windows.Forms.TextBox();
            this.pass_data = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refill_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.secret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ID_data
            // 
            this.ID_data.Location = new System.Drawing.Point(136, 50);
            this.ID_data.Name = "ID_data";
            this.ID_data.Size = new System.Drawing.Size(173, 20);
            this.ID_data.TabIndex = 0;
            this.ID_data.TextChanged += new System.EventHandler(this.ID_data_TextChanged);
            this.ID_data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_data_KeyDown);
            this.ID_data.Leave += new System.EventHandler(this.ID_data_Leave);
            this.ID_data.MouseLeave += new System.EventHandler(this.ID_data_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // use_name_data
            // 
            this.use_name_data.Location = new System.Drawing.Point(212, 89);
            this.use_name_data.Name = "use_name_data";
            this.use_name_data.Size = new System.Drawing.Size(173, 20);
            this.use_name_data.TabIndex = 2;
            this.use_name_data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.use_name_data_KeyDown);
            // 
            // pass_data
            // 
            this.pass_data.Location = new System.Drawing.Point(212, 125);
            this.pass_data.Name = "pass_data";
            this.pass_data.PasswordChar = '*';
            this.pass_data.Size = new System.Drawing.Size(173, 20);
            this.pass_data.TabIndex = 3;
            this.pass_data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_data_KeyDown);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label.Location = new System.Drawing.Point(359, 53);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(36, 13);
            this.Label.TabIndex = 4;
            this.Label.Text = "Nhập.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã số bằng lái : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(119, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên đăng nhập :";
            // 
            // refill_pass
            // 
            this.refill_pass.Location = new System.Drawing.Point(212, 151);
            this.refill_pass.Name = "refill_pass";
            this.refill_pass.PasswordChar = '*';
            this.refill_pass.Size = new System.Drawing.Size(173, 20);
            this.refill_pass.TabIndex = 7;
            this.refill_pass.TextChanged += new System.EventHandler(this.refill_pass_TextChanged);
            this.refill_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.refill_pass_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(148, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(107, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập lại mật khẩu :";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(561, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(115, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thông tin bí mật :\r\n";
            // 
            // secret
            // 
            this.secret.Location = new System.Drawing.Point(212, 179);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(173, 20);
            this.secret.TabIndex = 12;
            this.secret.Leave += new System.EventHandler(this.secret_Leave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(592, 247);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refill_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.pass_data);
            this.Controls.Add(this.use_name_data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ID_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Register_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox use_name_data;
        private System.Windows.Forms.TextBox pass_data;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox refill_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secret;
    }
}