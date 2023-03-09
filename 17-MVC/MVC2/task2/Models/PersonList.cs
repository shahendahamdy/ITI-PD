using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task2.Models
{
    public class PersonList
    {
        List<Person> list = new List<Person>()
        {
            new Person() {Id=1,Name="aaa",ImgPath=""},
            new Person() {Id=2,Name="bbb",ImgPath=""},
            new Person() {Id=3,Name="ccc",ImgPath=""},
            new Person() {Id=4,Name="ddd",ImgPath=""},
            new Person() {Id=5,Name="eee",ImgPath=""},
            new Person() {Id=6,Name="fff",ImgPath=""},
            new Person() {Id=7,Name="ggg",ImgPath=""},
        };
    }
}