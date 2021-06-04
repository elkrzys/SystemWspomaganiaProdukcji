﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.Models
{
    public class Employee
    {

        public int UserId { get; set; }

        public int TypeId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Pesel { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PlaceOfResidence { get; set; }

        public int DepartmentId { get; set; }

        public List<EmployeeForm> formList;

        public List<EmployeeForm> GetFormList()
        {

            return formList;
        }

        public void SetFormList(List<EmployeeForm> newEmployeeFormList)
        {
            if (formList != null)
                formList.Clear();

            formList = newEmployeeFormList;
        }
    }

}
