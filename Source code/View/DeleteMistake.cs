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
    public partial class DeleteMistake : Form
    {
        private Done done;
        private int a;
        public DeleteMistake(int a)
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
                done.delete_mistake(int.Parse(this.textBox1.Text));
                done.insert_history(a, "Xóa lỗi vi phạm " + this.textBox1 + " khỏi bảng.");
                MessageBox.Show("Succeed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteMistake_MouseDown(object sender, MouseEventArgs e)
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
