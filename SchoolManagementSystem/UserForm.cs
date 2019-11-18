using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Entity;

namespace SchoolManagementSystem
{
    public partial class UserForm : Form
    {
        public User UserObject;
        public UserForm()
        {
            InitializeComponent();
            btnShow.Click += BtnShow_Click;
            UserObject = new User();
        }

      

        private void BtnShow_Click(object sender, EventArgs e)
        {
            try
            {

                using (var sw = new StreamReader("UserInfo.txt"))
                {
                    string un = sw.ReadLine();
                    string uid = sw.ReadLine();
                    string all = sw.ReadToEnd();

                    MessageBox.Show("User Name and Id:" + un + " " + uid);
                    MessageBox.Show(all);


                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox1.Text = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            UserObject.UserName = txtUserName.Text;
            UserObject.DOB = dateTimePickerDOB.Value;
            UserObject.Address = txtAddress.Text;
            UserObject.Phone = txtPhone.Text;
            UserObject.UserID = txtUserID.Text;
            UserObject.ProfilePhotoPath = textBox1.Text;

            var sinfo = new StudentInfoForm(this);
            sinfo.Show();
            this.Hide();
        }
    }

}
