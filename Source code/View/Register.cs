using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excute;

namespace View
{
    public partial class Register : Form
    {
        private Done done;
        public Register()
        {
            done = new Done();
            InitializeComponent();
        }

        private void ID_data_KeyDown(object sender, KeyEventArgs e)
        {
            Done done = new Done();
            if (e.KeyCode == Keys.Enter)
            {
                if (done.Search_Information_on_Register(this.ID_data.Text) == false)
                { this.Label.Text = "Chúng tôi không tìm thấy bạn trên hệ thống !!!"; }
                else if (done.Search_Information_on_Register(this.ID_data.Text) == true)
                {
                    this.Label.Text = "Nhập thông tin bên dưới để tiếp tục !!!";
                    this.use_name_data.Focus();
                }
                this.use_name_data.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Label.Text == "Nhập thông tin bên dưới để tiếp tục !!!" && this.pass_data.Text == this.refill_pass.Text)
            {
                done.insert_status(this.ID_data.Text, true, this.use_name_data.Text, done.Cryptography_MD5(this.Text),this.secret.Text);
                Notification a = new Notification("Đăng ký thành công !!!");
                a.Show();
            }else if(this.Label.Text == "Chúng tôi không tìm thấy bạn trên hệ thống !!!")
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin.");
            }    
        }

        private void ID_data_MouseLeave(object sender, EventArgs e)
        {
            if (done.Search_Information_on_Register(this.ID_data.Text) == false)
            { this.Label.Text = "Chúng tôi không tìm thấy bạn trên hệ thống !!!"; }
            else if (done.Search_Information_on_Register(this.ID_data.Text) == true)
            {
                this.Label.Text = "Nhập thông tin bên dưới để tiếp tục !!!";
            }
        }

        private void refill_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pass_data.Text != refill_pass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không chính xác.");
                }
                this.secret.Focus();
            }
        }

        private void refill_pass_TextChanged(object sender, EventArgs e)
        {
            
            if (refill_pass.Text.Length >= pass_data.Text.Length)
            {
                if (refill_pass.Text != pass_data.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không chính xác.");
                }
            }
        }

        private void use_name_data_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.pass_data.Focus();
            }    
        }

        private void pass_data_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.refill_pass.Focus();
            }    
        }

        private void secret_Leave(object sender, EventArgs e)
        {
            if(this.pass_data.Text != this.refill_pass.Text)
            {
                Notification noty = new Notification("Mật khẩu nhập lại không đúng !!!");
            }
        }

        private void ID_data_Leave(object sender, EventArgs e)
        {
            if (done.Search_Information_on_Register(this.ID_data.Text) == false)
            { this.Label.Text = "Chúng tôi không tìm thấy bạn trên hệ thống !!!"; }
            else if (done.Search_Information_on_Register(this.ID_data.Text) == true)
            {
                this.Label.Text = "Nhập thông tin bên dưới để tiếp tục !!!";
            }
        }

        private void ID_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
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
