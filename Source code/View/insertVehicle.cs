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
    public partial class insertVehicle : Form
    {
        private int a;
        private Done done;
        public insertVehicle(int a)
        {
            this.a = a;
            done = new Done();
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                done.insert_Vehicle(this.vehile_id.Text, this.frame_number.Text, this.mahine_number.Text, this.brand.Text, this.origin.Text);
                done.insert_history(a, "Thêm phương tiện " + this.vehile_id.Text + " vào bảng.");
                MessageBox.Show("Succeed");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void vehile_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mahine_number.Focus();
            }
        }

        private void mahine_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.frame_number.Focus();
            }
        }

        private void frame_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.brand.Focus();
            }
        }

        private void brand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.origin.Focus();
            }
        }

        private void insertVehicle_MouseDown(object sender, MouseEventArgs e)
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
