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
using System.IO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;

namespace View
{
    public partial class Admin : Form
    {
        private Done done;
        public Admin(int id_Admin)
        {
            done = new Done();
            InitializeComponent();
            this.Admin_id.Text = id_Admin.ToString();
            this.select_Table.Items.Add("Danh sách thông tin phương tiện.");
            this.select_Table.Items.Add("Danh sách thông tin người có phương tiện giao thông.");
            this.select_Table.Items.Add("Danh sách các lỗi khi tham gia giao thông.");
            this.select_Table.Items.Add("Danh sách trạng thái tài khoản của người sở hữu phương tiện.");
            this.select_Table.Items.Add("Danh sách thông tin người sở hữu cùng phương tiện sử hữu.");
            this.select_Table.Items.Add("Danh sách phương tiện cùng lỗi mắc phải.");
            this.item.Items.Add("Bảng thông tin người có phương tiện.");
            this.item.Items.Add("Bảng tài khoản người dùng.");
            this.item.Items.Add("Bảng phương tiện.");
            this.item.Items.Add("Bảng lỗi vi phạm.");
            this.item.Items.Add("Bảng phương tiện cùng lỗi vi phạm mắc phải.");
            this.item.Items.Add("Bảng chủ sở hữu phương tiện.");
            this.item2.Items.Add("Chỉnh sửa thông tin phương tiện.");
            this.item2.Items.Add("Chỉnh sửa lỗi vi phạm.");
            this.item2.Items.Add("Chỉnh sửa thông tin nộp phạt.");
            this.item3.Items.Add("Xóa lỗi vi phạm.");
            this.item3.Items.Add("Xóa người sở hữu phương tiện.");
            this.item3.Items.Add("Xóa Phương tiện.");
            this.item3.Items.Add("Xóa phương tiện cùng lỗi vi phạm.");
            this.comboBox1.Items.Add("Tìm kiếm thông tin người có phương tiện giao thông.");
            this.comboBox1.Items.Add("Tìm kiếm thông tin phương tiện.");
            this.comboBox1.Items.Add("Tìm kiếm thông tin lỗi vi phạm.");
            this.comboBox1.Items.Add("Tìm kiếm thông tin tài khoản người dùng.");
            this.comboBox1.Items.Add("Tìm kiếm thông tin sở hữu phương tiện.");
            this.comboBox1.Items.Add("Tìm kiếm thông tin phương tiện có lỗi vi phạm.");
        }
        /// <summary>
        /// action click display button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Display_Click(object sender, EventArgs e)
        {
            Done tmp = new Done();
            if (this.select_Table.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn bảng để hiển thị", "Cảnh báo");
            }
            else if (this.select_Table.SelectedItem.ToString() == "Danh sách thông tin phương tiện.")
            {
                tmp.Display(this.admin_DataGridView, 2);
            }
            else if (this.select_Table.SelectedItem.ToString() == "Danh sách thông tin người có phương tiện giao thông.")
            {
                tmp.Display(this.admin_DataGridView, 4);
            }
            else if (this.select_Table.SelectedItem.ToString() == "Danh sách các lỗi khi tham gia giao thông.")
            {
                tmp.Display(this.admin_DataGridView, 6);
            }
            else if (this.select_Table.SelectedItem.ToString() == "Danh sách trạng thái tài khoản của người sở hữu phương tiện.")
            {
                tmp.Display(this.admin_DataGridView, 7);
            }
            else if (this.select_Table.SelectedItem.ToString() == "Danh sách thông tin người sở hữu cùng phương tiện sử hữu.")
            {
                tmp.Display(this.admin_DataGridView, 8);
            }
            else if (this.select_Table.SelectedItem.ToString() == "Danh sách phương tiện cùng lỗi mắc phải.")
            {
                tmp.Display(this.admin_DataGridView, 9);
            }
        }


        /// <summary>
        /// action button get path excel data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.item3.SelectedItem == "Xóa lỗi vi phạm.")
            {
                DeleteMistake delete = new DeleteMistake(int.Parse(this.Admin_id.Text));
                delete.ShowDialog();
            }
            else if (this.item3.SelectedItem == "Xóa người sở hữu phương tiện.")
            {
                DeleteInformation delete = new DeleteInformation(int.Parse(this.Admin_id.Text));
                delete.ShowDialog();
            }
            else if (this.item3.SelectedItem == "Xóa Phương tiện.")
            {
                DeleteVehicle delete = new DeleteVehicle(int.Parse(this.Admin_id.Text));
                delete.ShowDialog();
            }
            else if (this.item3.SelectedItem == "Xóa phương tiện cùng lỗi vi phạm.")
            {
                DeleteVehicleMistake delete = new DeleteVehicleMistake(int.Parse(this.Admin_id.Text));
                delete.ShowDialog();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (item.SelectedItem == "Bảng thông tin người có phương tiện.")
            {
                insertInfor infor = new insertInfor(int.Parse(this.Admin_id.Text));
                infor.ShowDialog();
            }
            else if (item.SelectedItem == "Bảng tài khoản người dùng.")
            {
                insertUserSTT userstt = new insertUserSTT(int.Parse(this.Admin_id.Text));
                userstt.ShowDialog();
            }
            else if (item.SelectedItem == "Bảng phương tiện.")
            {
                insertVehicle vehile = new insertVehicle(int.Parse(this.Admin_id.Text));
                vehile.ShowDialog();
            }
            else if (item.SelectedItem == "Bảng lỗi vi phạm.")
            {
                insertMistake mistake = new insertMistake(int.Parse(this.Admin_id.Text));
                mistake.ShowDialog();
            }
            else if (item.SelectedItem == "Bảng phương tiện cùng lỗi vi phạm mắc phải.")
            {
                insertVehicleMistake vehicleMistake = new insertVehicleMistake(int.Parse(this.Admin_id.Text));
                vehicleMistake.ShowDialog();
            }
            else if (item.SelectedItem == "Bảng chủ sở hữu phương tiện.")
            {
                insertVehicleInfor vehileInfor = new insertVehicleInfor(int.Parse(this.Admin_id.Text));
                vehileInfor.ShowDialog();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.item2.SelectedItem == "Chỉnh sửa thông tin phương tiện.")
            {
                UpdateVehicle update = new UpdateVehicle(int.Parse(this.Admin_id.Text));
                update.ShowDialog();
                done.Display(this.admin_DataGridView, 2);
            }
            else if (this.item2.SelectedItem == "Chỉnh sửa lỗi vi phạm.")
            {
                UpdateMistake update = new UpdateMistake(int.Parse(this.Admin_id.Text));
                update.ShowDialog();
                done.Display(this.admin_DataGridView, 6);
            }
            else if (this.item2.SelectedItem == "Chỉnh sửa thông tin nộp phạt.")
            {
                UpdateFineSTT update = new UpdateFineSTT(int.Parse(this.Admin_id.Text));
                update.ShowDialog();
                done.Display(this.admin_DataGridView, 9);

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            done.Display(this.admin_Datagrdview2, 5);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DeleteRequest delete = new DeleteRequest(int.Parse(this.Admin_id.Text));
            delete.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ReplyUser reply = new ReplyUser(int.Parse(this.Admin_id.Text));
            reply.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                done.deleteAllHistory();
                MessageBox.Show("Succeed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.richTextBox1.Text = done.showHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "Nhập tư khóa";
                this.textBox1.ForeColor = Color.Gray;
            }
            else if (this.textBox1.Text != null)
            {
                this.textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox1.ForeColor = Color.Black;
        }

        private void textBox1_LocationChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.textBox1.Text = "Nhập tư khóa";
                this.textBox1.ForeColor = Color.Gray;
            }
            else if (this.textBox1.Text != null)
            {
                this.textBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin người có phương tiện giao thông.")
            {
                this.label1.Text = "Nhập số giấy phép lái xe";

            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin phương tiện.")
            {
                this.label1.Text = "Nhập bảng số.";
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin lỗi vi phạm.")
            {
                this.label1.Text = "Nhập mã lỗi.";
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin tài khoản người dùng.")
            {
                this.label1.Text = "Nhập số giấy phép lái xe.";
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin sở hữu phương tiện.")
            {
                this.label1.Text = "Nhập bảng số.";
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin phương tiện có lỗi vi phạm.")
            {
                this.label1.Text = "Nhập bảng số.";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin người có phương tiện giao thông.")
            {
                try
                {
                    done.search_Information(this.admin_DataGridView, this.textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin phương tiện.")
            {
                try
                {
                    done.search_Vehicle(this.admin_DataGridView, this.textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin lỗi vi phạm.")
            {
                try
                {
                    done.search_TOmistask(this.admin_DataGridView, int.Parse(this.textBox1.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin tài khoản người dùng.")
            {
                try
                {
                    done.search_UserSTT(this.admin_DataGridView, this.textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin sở hữu phương tiện.")
            {
                try
                {
                    done.search_vehicle_Infor(this.admin_DataGridView, this.textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.comboBox1.SelectedItem == "Tìm kiếm thông tin phương tiện có lỗi vi phạm.")
            {
                try
                {
                    done.search_vehicle_Mistask(this.admin_DataGridView, this.textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
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
