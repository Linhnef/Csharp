using Excute;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Login2 : Form
    {
        private Done done;
        public Login2()
        {
            done = new Done();
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (!this.admin_check.Checked)
            {
                try
                {
                    if (done.Check_login(this.id_Card.Text, user_Data.Text, done.Cryptography_MD5(password_Data.Text), "user") == true)
                    {
                        User user = new User();
                        user.setUser(this.id_Card.Text);
                        this.Visible = false;
                        user.ShowDialog();
                        
                    }
                    else
                    {
                        Notification noty = new Notification("Kiểm tra lại thông tin đã nhập !!!");
                        noty.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(this.admin_check.Checked)
            {
                try
                {
                        Admin admin = new Admin(int.Parse(this.id_Card.Text));
                        admin.ShowDialog();
                        this.Dispose();
                       
                }
                catch(Exception ex)
                {
                    Notification noty = new Notification(ex.Message);
                    noty.ShowDialog();
                }
            } 
        }

        private void user_Data_MouseClick(object sender, MouseEventArgs e)
        {
            this.user_Data.Text = "";
        }

        private void user_Data_Leave(object sender, EventArgs e)
        {
            if (this.user_Data.Text != "")
            {
                ((TextBox)sender).ForeColor = Color.Black;
            }
            else if (this.user_Data.Text == "")
            {
                this.user_Data.Text = "Nhập tên đăng nhập.";
                ((TextBox)sender).ForeColor = Color.Gray;
            }
        }

        private void password_Data_Leave(object sender, EventArgs e)
        {
            if (this.password_Data.Text == "")
            {
                this.password_Data.Text = "Nhập mật khẩu.";
                ((TextBox)sender).ForeColor = Color.Gray;
            }
            else if (this.password_Data.Text != "")
            {
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private void password_Data_MouseClick(object sender, MouseEventArgs e)
        {
            this.password_Data.Text = "";
        }

        private void admin_check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.admin_check.Checked)
            {
                this.id_Card.Text = "Nhập mã admin";
            }
            if (!this.admin_check.Checked)
            {
                this.id_Card.Text = "Nhập mã số giấy phép lái xe.";
            }
        }

        private void id_Card_Leave(object sender, EventArgs e)
        {
            if (this.id_Card.Text == string.Empty || this.id_Card.Text == null)
            {
                this.id_Card.Text = "Mã số giấy phép";
            }
        }

        private void id_Card_MouseEnter(object sender, EventArgs e)
        {
            this.id_Card.Text = "";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                notifyIcon1.Visible = false;
                WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(10);
            this.Hide();
            this.ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg = Message.Create(this.Handle,
                                             WM_NCLBUTTONDOWN,
                                             new IntPtr(HTCAPTION),
                                             IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
    }
}
