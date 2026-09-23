using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {

            //creating variable
            String name,  s_department, s_semister, display;
            int s_id;

            //initial values to variable
            name =txtname.Text;
            s_department = txtdepartment.Text;
            s_semister = txtsemister.Text;

            //Convert string to int using parse method
            s_id = int.Parse(txtstudentid.Text);

            //stage 2= process  - concatination of full date
            display = name + "," + "," + s_department + "," + s_semister;

            //Diplay output to lbloutput
            lbloutput.Text=display;

        }

        private void btnclear_Click(object sender, EventArgs e)

        {
            lbloutput.Text = "";

        }
    }
}
