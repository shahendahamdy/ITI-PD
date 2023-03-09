using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3_1.Models
{
    public class CarList
    {
        public static List<Car> cars = new List<Car>()
        {
            new Car(){Num= 1, Color="red",Model="model-1",Manfacture="Volvo"},
            new Car(){Num= 2, Color="blue",Model="model-2",Manfacture="BMW"},
            new Car(){Num= 5, Color="green",Model="model-3",Manfacture="Fiat"},
        };
    }
}