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
    public partial class insertInfor : Form
    {
        private Done done;
        private int a;
        public insertInfor(int a)
        {
            this.a = a;
            done = new Done();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                done.insert_Informations(this.id_card.Text, this.fname.Text, this.name.Text, int.Parse(this.born.Text), this.addr.Text);
                done.insert_history(a, "Thêm người dùng " + this.id_card.Text + " vào bảng.");
                MessageBox.Show("Succeed");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void id_card_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.name.Focus();
            }    
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.fname.Focus();
            }
        }

        private void fname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.addr.Focus();
            }
        }

        private void addr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.born.Focus();
            }
        }

        private void insertInfor_MouseDown(object sender, MouseEventArgs e)
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
