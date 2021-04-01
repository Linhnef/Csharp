namespace View
{
    partial class insertVehicleMistake
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
            this.label4 = new System.Windows.Forms.Label();
            this.vehilce_id = new System.Windows.Forms.TextBox();
            this.desride = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.mistak_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(137, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bảng số phương tiện :";
            // 
            // vehilce_id
            // 
            this.vehilce_id.Location = new System.Drawing.Point(274, 34);
            this.vehilce_id.Name = "vehilce_id";
            this.vehilce_id.Size = new System.Drawing.Size(144, 20);
            this.vehilce_id.TabIndex = 30;
            this.vehilce_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vehilce_id_KeyDown);
            // 
            // desride
            // 
            this.desride.Location = new System.Drawing.Point(229, 113);
            this.desride.Name = "desride";
            this.desride.Size = new System.Drawing.Size(144, 20);
            this.desride.TabIndex = 31;
            this.desride.KeyDown += new System.Windows.Forms.KeyEventHandler(this.desride_KeyDown);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(229, 155);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(144, 20);
            this.time.TabIndex = 33;
            // 
            // mistak_id
            // 
            this.mistak_id.Location = new System.Drawing.Point(229, 75);
            this.mistak_id.Name = "mistak_id";
            this.mistak_id.Size = new System.Drawing.Size(144, 20);
            this.mistak_id.TabIndex = 34;
            this.mistak_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mistak_id_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(137, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã lỗi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(137, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mô tả : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(137, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Thời gian :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(401, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "dd/mm/yyyy";
            // 
            // stt
            // 
            this.stt.AutoSize = true;
            this.stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stt.Location = new System.Drawing.Point(229, 197);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(84, 17);
            this.stt.TabIndex = 42;
            this.stt.Text = "Trạng thái";
            this.stt.UseVisualStyleBackColor = true;
            // 
            // insertVehicleMistake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(496, 268);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mistak_id);
            this.Controls.Add(this.time);
            this.Controls.Add(this.desride);
            this.Controls.Add(this.vehilce_id);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertVehicleMistake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertVehicleMistake";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.insertVehicleMistake_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vehilce_id;
        private System.Windows.Forms.TextBox desride;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox mistak_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox stt;
    }
}