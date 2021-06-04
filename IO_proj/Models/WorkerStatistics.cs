using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.Models
{
    public class WorkerStatistics //Zrobiłem przez przypadek employee form która jest tym samym iksde
    {
        public int StatID { get; set; }

        public DateTime Date { get; set; }

        public int UserID { get; set; }

        public double Norm { get; set; }

        public int PrizePoints { get; set; }

        public int DepartmentID { get; set; }
    }
}
