using ProductionManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.Models
{
    public class DepartmentManager
    {
        public Department department { get; set; }

        public List<Employee> employeesList { get; }

        public List<ManagerTable> mtList { get; set; }
        public DepartmentManager()
        {
            department = DBManager.Instance.GetDepartmentManagerData(global.GetInstance().GetCurrentUser().DepartmentId);

            employeesList = DBManager.Instance.GetEmployeesList(global.GetInstance().GetCurrentUser().DepartmentId);

            for (int i=0;i<employeesList.Count;i++)
            {
               employeesList[i].SetFormList(DBManager.Instance.GetEmployeeForm(employeesList[i].UserId));
            }

            SetManagerTableList();
        }

        public void SetManagerTableList()
        {
            if (mtList == null)
                mtList = new List<ManagerTable>();
            else
                mtList.Clear();
            
            for (int i=0; i< employeesList.Count;i++)
                for (int j=0;j< employeesList[i].formList.Count;j++)
                {
                    ManagerTable tmp = new ManagerTable();
                    
                    tmp.date = employeesList[i].formList[j].date;
                    tmp.lastName = employeesList[i].LastName;
                    tmp.name = employeesList[i].Name;
                    tmp.parts = employeesList[i].formList[j].amount;

                    mtList.Add(tmp);
                }
        }
    }
}
