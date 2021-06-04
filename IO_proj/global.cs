using ProductionManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem
{
    public class global //singleton
    {
        private static Employee currentUser;

        private static global instance;

        private global()
        { 
        }

        public static global GetInstance()
        {
            if (instance == null)
            {
                instance = new global();

                
            }
            return instance;
        }

        public void SetCurrentUser(Employee newUser)
        {
            currentUser = newUser;
        }

        public Employee GetCurrentUser()
        {
            return currentUser;
        }

    }
}
