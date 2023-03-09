using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }


        public SalesPerson(int id , DateTime d1, int achievedTarget):base(1,d1)
        {

            AchievedTarget = achievedTarget;
        }

        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget >Quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.target });
                
                return false;
            }
            else
            {
                return true;
            }
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if(e.Cause== LayOffCause.target)
            {
                base.OnEmployeeLayOff(e);

            }
        }
    }
}
