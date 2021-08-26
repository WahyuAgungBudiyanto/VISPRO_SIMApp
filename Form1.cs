using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace App_SIM
{
    public partial class FormMain : Form
    {
        //Rounded Corner
        /*[System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );*/

        public FormMain()
        {
            InitializeComponent();
            //Remove Top
            this.FormBorderStyle = FormBorderStyle.None;

            //ComboBox
            
        }

        

        
        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        public object GMapProviders { get; }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_image_upload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                    imageLocation = dialog.FileName;

                    pictureBox_image_placed.ImageLocation = imageLocation;
                    pictureBox_image_output.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            String name = textBox_name.Text;
            label_name_output.Text = name;

            String address = textBox_address.Text;
            label_address_output.Text = address;

            String place = textBox_place.Text;
            label_place_output.Text = place;

            label_date_output.Text = dateTimePicker_tL.Text;

            String height = textBox_height.Text;
            label_height_output.Text = height;

            String job = textBox_job.Text;
            label_job_output.Text = job;

            label_expired_output.Text = dateTimePicker_expired.Text;

            if (radioButton_gol_a.Checked == true)
            {
                label_gol_sim_output.Text = "A";
            }
            if (radioButton_gol_a_khusus.Checked == true)
            {
                label_gol_sim_output.Text = "A Khusus";
            }
            if (radioButton_gol_c.Checked == true)
            {
                label_gol_sim_output.Text = "C";
            }
            if (radioButton_gol_b1.Checked == true)
            {
                label_gol_sim_output.Text = "B1";
            }
            if (radioButton_gol_b2.Checked == true)
            {
                label_gol_sim_output.Text = "B2";
            }

            String nosim = textBox_no_sim.Text;
            label_no_sim_output.Text = nosim;

            
        }
    }
}
