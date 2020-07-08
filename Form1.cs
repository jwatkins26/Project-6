using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject06
{
    public partial class SemesterProject06 : Form
    {
        public SemesterProject06()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            
            string name = nameBox.Text;
            DateTime today = DateTime.Today;
            DateTime birthDate = bdp.Value.Date;
            DateTime futureDate = fdp.Value.Date;
            //TimeSpan future = futureDate - birthDate;
            DateTime nextBday = new DateTime(today.Year + 1, birthDate.Month, birthDate.Day);
            TimeSpan yearsOld = today - birthDate;
           
            int age = futureDate.Year - birthDate.Year;
            TimeSpan future = futureDate - today;
            int days = future.Days;

            OutputLabel.Text = "Hello " + name + " you will be " + age + " years old on " + futureDate.ToString("MMMM dd, yyyy");
            DaysLabel.Visible = true;
            DaysLabel.Text = "A date that is " + days +" days from now.";
            DaysLabel.Update();
        }

        private void fdp_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            if (fdp.Value.Date < today)
            {
                MessageBox.Show("Error - Date must be in the future.");
                fdp.Value = today;
            }
        }

        private void bdp_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            if (bdp.Value.Date > today)
            {
                MessageBox.Show("Error - Date must be in past");
                bdp.Value = today;


             }
                  
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
