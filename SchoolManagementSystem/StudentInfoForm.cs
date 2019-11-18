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

namespace SchoolManagementSystem
{
    public partial class StudentInfoForm : Form
    {
        Form previousForm { get; set; }
        public StudentInfoForm(Form form) {
            InitializeComponent();
            previousForm = form;
            populate();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        void populate() {
            if(previousForm is UserForm)
            {
                var userForm = previousForm as UserForm;
                this.textBox1.Text = userForm.UserObject.UserName;
                try
                {
                    using (StreamWriter sw = new StreamWriter("UserInfo.txt"))
                    {
                        sw.WriteLine(userForm.UserObject.UserName);
                        sw.WriteLine(userForm.UserObject.UserID);
                        sw.WriteLine(userForm.UserObject.Address);
                        sw.WriteLine(userForm.UserObject.DOB);
                        sw.WriteLine(userForm.UserObject.Phone);
                        sw.WriteLine(userForm.UserObject.ProfilePhotoPath);
                        sw.Close();
                    }
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
            }
            
        }

    }
}
