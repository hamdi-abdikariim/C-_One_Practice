using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Assignment
{
    public partial class txtnemeric : Form
    {
        public txtnemeric()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //
            //creating variable
            String dayof_week, Name_of_Month, Numeric_Day, Year, Full_Date;

            //initial values to variable
            dayof_week=txtdayoftheweek.Text;
            Name_of_Month=txtmonth.Text;
            Numeric_Day = txtnumeric.Text;
            Year=txtyear.Text;

            //stage 2= process  - concatination of full date
            Full_Date=dayof_week + "," + "," +Name_of_Month + "," + Numeric_Day + "," + Year;

            //Stage 3 = the output using label

            lbloutput.Text = Full_Date;


        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            //Stage 4 clear 
            txtdayoftheweek.Clear();
            txtnameofthemonth.Text="";
            txtmonth.Clear();
            txtyear.Text=string.Empty;


            //Clearing Label can not use clear function
            lbloutput.Text = string.Empty;
            //lbloutput.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //Form Clossing - using this keyword and close function
            this.Close();
        }
    }
}
