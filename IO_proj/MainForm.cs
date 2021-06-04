using IO_proj;
using ProductionManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProductionManagementSystem
{
    public partial class MainForm : Form
    {
        public enum UserType
        {
            Admin = 1,
            Manager = 2,
            Employee = 3
        }

        //andrew68 : haslo

        //kubus123 : ugabuga

        //bogusia420 : weed

        //marcino22 : qwerty

        public MainForm(Employee currentUser)
        { 
            InitializeComponent();
            if(currentUser!=null)
            switch(currentUser.TypeId)
            {
                case (int)UserType.Employee:
                        {
                            global.GetInstance().SetCurrentUser(currentUser);
                            AddEmployeeTabs();
                        }
                    break;
                case (int)UserType.Manager:
                        {
                            global.GetInstance().SetCurrentUser(currentUser);
                            AddManagerTabs();
                        }
                    break;
                case (int)UserType.Admin:
                        {
                            global.GetInstance().SetCurrentUser(currentUser);
                            AddAdminTabs();
                        }
                    break;
                default:
                    MessageBox.Show("Nieznany błąd");
                    break;
            }
        }

        public void AddEmployeeTabs()
        {
            tabControl.Controls.Add(employeeTab1);
            tabControl.Controls.Add(employeeTab2);

            employeeTab1.Controls.Add(new EmployeePanel());
            employeeTab2.Controls.Add(new EmployeeProfilePanel());
 
        }
        public void AddManagerTabs()
        {
            tabControl.Controls.Add(managerTab1);
            tabControl.Controls.Add(managerTab2);

            managerTab1.Controls.Add(new DepartmentManagerMainPanel());
            managerTab2.Controls.Add(new DepartmentManagerPrizeView());
        }
        public void AddAdminTabs()
        {
            tabControl.Controls.Add(adminTab1);
            tabControl.Controls.Add(adminTab2);
            tabControl.Controls.Add(adminTab3);
            tabControl.Controls.Add(adminTab4);

            adminTab1.Controls.Add(new FacilityManagerPanel());
            adminTab2.Controls.Add(new AddEmployee());
            adminTab3.Controls.Add(new EmployeeManagementPanel());
            adminTab4.Controls.Add(new PrizeManagerPanel());
        }

        public void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
