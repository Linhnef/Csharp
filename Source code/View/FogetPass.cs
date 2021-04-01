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
    public partial class FogetPass : Form
    {
        private Done done;
        public FogetPass()
        {
            done = new Done();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode  == Keys.Enter)
            {
                if(done.Check_Secre(this.id_card.Text,this.secre.Text) != true)
                    {
                    MessageBox.Show("ERROR !!!");
                }
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (done.Check_Secre(this.id_card.Text, this.secre.Text) == true)
            {
                if (done.Get_useName(this.id_card.Text) == this.usename.Text)
                {
                    if (this.pass.Text == this.newpass.Text)
                    {
                        try
                        {
                            done.Update_Password(this.id_card.Text, this.pass.Text);
                            MessageBox.Show("Succeed !!!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error !!!");
                    }
                }
            }
        }

        private void FogetPass_MouseDown(object sender, MouseEventArgs e)
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
