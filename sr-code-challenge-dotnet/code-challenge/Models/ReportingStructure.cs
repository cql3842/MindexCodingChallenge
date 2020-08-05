using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Models
{
    public class ReportingStructure
    {
        public int numberOfReports { get; set; }
        public Employee employee { get; set; }
        public int GetNumberOfReports(Employee employee)
        {
            int number = 0;
            for (int i = 0; i < employee.DirectReports.Count(); i++)
            {
                // if there are other employees, search through their direct reports and keep going
                // until no more direct reports are found.
                if (employee.DirectReports[i].DirectReports.Count() > 0)
                {
                    number += 1;
                    number += GetNumberOfReports(employee.DirectReports[i]);
                }
                // else, just add one and go to the next spot in the loop.
                else
                {
                    number += 1;
                }
            }
            return number;
        }

    }
}
