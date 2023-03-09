using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
        {
            Console.WriteLine("Layed off cause is ->  "+e.Cause);
            EmployeeLayOff?.Invoke (this, e);
        }
        public int EmployeeID { get; set; }
        DateTime birthDate;
        public DateTime BirthDate{get;  set;}
        public int VacationStock{ get;set ; }

        public Employee(int id,DateTime dt)
        {
            EmployeeID= id;
            BirthDate= dt;
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            if(To.Day-From.Day>VacationStock)
            {

                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Vacation_Stock_0 });
                return false;
            }
            else
            {
                VacationStock -= (To.Day - From.Day);
                return true;
            }
        }
        public void EndOfYearOperation()
        {
            if (DateTime.Now.Year - birthDate.Year > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Age_60});

            }
        }
    }
}
enum LayOffCause
{ Vacation_Stock_0 , Age_60 ,target,resign}