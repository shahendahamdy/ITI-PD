using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;
        public Department(int id, string name) {
            DeptID= id;
            DeptName
                = name;
        }
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            ///Try Register for EmployeeLayOff Event Here
            E.EmployeeLayOff += this.RemoveStaff;
        }

        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if(sender is Employee senderr &&senderr!=null)  {
                Staff.Remove(senderr);
            
            }
            foreach( Employee emp in Staff)
            {
                Console.WriteLine(emp.EmployeeID);
            }
        }
    }
}
