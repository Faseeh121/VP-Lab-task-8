using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_lab
{
    public partial class form_2 : Form
    {
        public form_2()
        {
            InitializeComponent();
        }
        public form_2(string name,string gender,string hobbies,string status,string country)
        {
            InitializeComponent();

            label1.Text = "Name is " + name;
                       
            label2.Text = "Gender is " + gender ;
            label3.Text = "Hobby is " + hobbies ;
            label4.Text = "Status is " + status ;
            label5.Text = "Country is " + country;
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();

        }

        private void form_2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
