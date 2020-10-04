using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageFinalSolution
{
     interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void computeEmpWage();
        int getTotalWage(string company);
    }
}
