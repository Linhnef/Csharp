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
    public partial class insertVehicleMistake : Form
    {
        private Done done;
        private int a;
        public insertVehicleMistake(int a)
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
                bool Stt = false;
                if (this.stt.Checked) Stt = true;
                done.insert_vehicle_mistake(this.vehilce_id.Text, int.Parse(this.mistak_id.Text), this.desride.Text, Stt, DateTime.Parse(this.time.Text));
                done.insert_history(a, "Thêm lỗi vi phạm cho phương tiện " + this.vehilce_id.Text + " vào bảng.");
                MessageBox.Show("Succeed");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vehilce_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mistak_id.Focus();
            }
        }

        private void mistak_id_KeyDown(object sender, KeyEventArgs e)
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
                this.time.Focus();
            }
        }

        private void insertVehicleMistake_MouseDown(object sender, MouseEventArgs e)
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
