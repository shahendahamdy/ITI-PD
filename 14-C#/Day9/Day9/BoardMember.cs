using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class BoardMember:Employee
    {
        public BoardMember(int id, DateTime dt) : base(id, dt)
        {
        }

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause=LayOffCause.resign});
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.resign)
            {
                base.OnEmployeeLayOff(e);
            }
        }

    }
}
