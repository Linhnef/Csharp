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
    public partial class UpdateMistake : Form
    {
        private Done done;
        private int a;
        public UpdateMistake(int a)
        {
            this.a = a;
            done = new Done();
            InitializeComponent();
            this.comboBox1.Items.Add("Chỉnh sửa nội dung.");
            this.comboBox1.Items.Add("Chỉnh sửa mô tả.");
            this.comboBox1.Items.Add("Chỉnh sửa mức phạt.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.SelectedItem == "Chỉnh sửa nội dung.")
            {
                try
                {
                    done.Update_Mistake(int.Parse(id_mistake.Text), "Nội dung", this.new_value.Text);
                    done.insert_history(a, "Chỉnh sửa nội dung lỗi " + this.id_mistake.Text + " vào bảng.");
                    MessageBox.Show("Succeed");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if(this.comboBox1.SelectedItem == "Chỉnh sửa mô tả.")
            {
                try
                {
                    done.Update_Mistake(int.Parse(id_mistake.Text), "Mô tả", this.new_value.Text);
                    done.insert_history(a, "Chỉnh sửa mô tả lỗi " + this.id_mistake.Text + " vào bảng.");
                    MessageBox.Show("Succeed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(this.comboBox1.SelectedItem == "Chỉnh sửa mức phạt.")
            {

                try
                {
                    done.Update_Charde(int.Parse(this.id_mistake.Text), decimal.Parse(this.new_value.Text));
                    done.insert_history(a, "Chỉnh sửa mức phạt lỗi " + this.id_mistake.Text + " vào bảng.");
                    MessageBox.Show("Succeed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateMistake_MouseDown(object sender, MouseEventArgs e)
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
