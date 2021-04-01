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
    public partial class insertMistake : Form
    {
        private Done done;
        private int a;
        public insertMistake(int a)
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
                done.insert_type_mistake(int.Parse(this.mistake_id.Text), this.content.Text, this.desride.Text, decimal.Parse(this.charge.Text));
                done.insert_history(a, "Thêm lỗi " + this.mistake_id.Text + " vào bảng.");
                MessageBox.Show("Succeed");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mistake_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.content.Focus();
            }
        }

        private void content_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.desride.Focus();
            }
        }

        private void desride_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.charge.Focus();
            }
        }

        private void insertMistake_MouseDown(object sender, MouseEventArgs e)
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
