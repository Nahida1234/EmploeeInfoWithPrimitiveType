using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoWithPrimitiveTypeApp
{
    public partial class EmployeeInfoFormUI : Form
    {
        public EmployeeInfoFormUI()
        {
            InitializeComponent();
        }

        private string id;
        private string name;
        private double salary;
        private void saveButton_Click(object sender, EventArgs e)
        {
           
                id = idTextBox.Text;
                name = nameTextBox.Text;
                salary = Convert.ToDouble(salaryTextBox.Text);
                MessageBox.Show(@"Information Saved Successfully");

                idTextBox.Text = "";
                nameTextBox.Text = "";
                salaryTextBox.Text = "";
          

        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text=id;
            name = nameTextBox.Text=name;
            salaryTextBox.Text=salary.ToString();
            MessageBox.Show(@"Information Retrive Successfully");

        }

      

    }
}
