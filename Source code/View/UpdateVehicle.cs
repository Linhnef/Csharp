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
    public partial class UpdateVehicle : Form
    {
        private Done done;
        private int a;
        public UpdateVehicle(int a)
        {
            done = new Done();
            this.a = a;
            InitializeComponent();
            this.comboBox1.Items.Add("Chỉnh sửa số khung.");
            this.comboBox1.Items.Add("Chỉnh sửa số máy.");
            this.comboBox1.Items.Add("Chỉnh sửa nhãn hiệu.");
            this.comboBox1.Items.Add("Chỉnh sửa xuất xứ.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedItem == "Chỉnh sửa số khung.")
            {
                try
                {
                    done.Update_Vehicle(this.textBox1.Text, "Số Khung", this.textBox3.Text);
                    done.insert_history(a, "Chỉnh sửa số khung phương tiện " + this.textBox1.Text + " vào bảng.");
                    MessageBox.Show("Succeed");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if(this.comboBox1.SelectedItem == "Chỉnh sửa số máy.")
            {
                try
                {
                    done.Update_Vehicle(this.textBox1.Text, "Số máy", this.textBox3.Text);
                    done.insert_history(a, "Chỉnh sửa số máy phương tiện " + this.textBox1.Text + " vào bảng.");
                    MessageBox.Show("Succeed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.comboBox1.SelectedItem == "Chỉnh sửa nhãn hiệu.")
            {
                try
                {
                    done.Update_Vehicle(this.textBox1.Text, "Nhãn hiệu", this.textBox3.Text);
                    done.insert_history(a, "Chỉnh sửa nhãn hiệu phương tiện " + this.textBox1.Text + " vào bảng.");
                    MessageBox.Show("Succeed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (this.comboBox1.SelectedItem == "Chỉnh sửa xuất xứ.")
            {
                try
                {
                    done.Update_Vehicle(this.textBox1.Text, "Xuất xứ", this.textBox3.Text);
                    done.insert_history(a, "Chỉnh sửa xuất xứ phương tiện " + this.textBox1.Text + " vào bảng.");
                    MessageBox.Show("Succeed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }

        private void UpdateVehicle_MouseDown(object sender, MouseEventArgs e)
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
