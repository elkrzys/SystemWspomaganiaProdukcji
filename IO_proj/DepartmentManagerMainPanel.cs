using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem.Models;

namespace ProductionManagementSystem
{
    public partial class DepartmentManagerMainPanel : UserControl
    {
        public DepartmentManagerMainPanel()
        {
            InitializeComponent();
            DepartmentManager currentManager = new DepartmentManager();
            employeesDataGridView.DataSource=currentManager.mtList;

            employeesDataGridView.Columns[0].HeaderText = "IMIĘ";
            employeesDataGridView.Columns[1].HeaderText = "NAZWISKO";
            employeesDataGridView.Columns[2].HeaderText = "ILOŚĆ CZĘŚCI";
            employeesDataGridView.Columns[3].HeaderText = "DATA";
        }

    }
}
