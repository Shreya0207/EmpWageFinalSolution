using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageFinalSolution
{
    class CompanyEmpWage
    {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;
            public CompanyEmpWage(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }

            public string toString()
            {
                return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
            }
        }
    }

          
