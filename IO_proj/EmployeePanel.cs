using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem.DataAccess;
using System.Globalization;
using ProductionManagementSystem;

namespace IO_proj
{
    public partial class EmployeePanel : UserControl
    {
        public EmployeePanel()
        {
            InitializeComponent();
            showForms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(textBox2.Text);
            DateTime tmpDate;
            tmpDate = DateTime.Parse(textBox1.Text);

            DBManager.Instance.InsertEmployeeForm(tmpDate,amount);

            DBManager.Instance.GetEmployeeForm();

            showForms();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showForms()
        {
            DBManager.Instance.GetEmployeeForm();
            var formList = global.GetInstance().GetCurrentUser().GetFormList();

            dataGridView2.DataSource = formList;
          
            dataGridView2.Columns[0].HeaderText = "DATA";
            dataGridView2.Columns[1].HeaderText = "ILOŚĆ CZĘŚCI";
            dataGridView2.Columns[2].HeaderText = "NORMA";
            dataGridView2.Columns[3].HeaderText = "PUNKTY NAGRÓD";
            
        }
    
    }
}
