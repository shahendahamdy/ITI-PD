using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class NIC
    {
        string Manufacture;
        string MAC;
        Type t;
        static NIC obj;
        NIC(string manufacture, string mAC, Type t)
        {
            Manufacture = manufacture;
            MAC = mAC;
            this.t = t;
        }
        public static NIC singletonObj { get; } = new("china", "192.168.1.1", Type.Ethernet);

        //static NIC()
        //{
        //    obj = new NIC("china", "192.168.1.1", Type.Ethernet);
        //}
        //public static NIC SingleTonObj
        //{
        //    get { return obj; }
        //}

    }

    enum Type:byte
    {
        Ethernet=0,token=1
    }

}
