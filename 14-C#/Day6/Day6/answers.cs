using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class answers
    {
        int exId;
        int stId;

        Dictionary<int, string> STDAns;
        public answers(int eId,int sId)
        {
            exId= eId;
            stId= sId;
            STDAns= new Dictionary<int, string>(); 

        }
        
    }
}
