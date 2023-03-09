// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

employee[] eArr = new employee[3];
eArr[0].Id = 1; eArr[1].Id = 2; eArr[2].Id = 1;
Console.WriteLine(eArr[0].Id);

eArr[0].Name = "A"; eArr[1].Name = "B"; eArr[2].Name = "C";
Console.WriteLine(eArr[0].Name);

eArr[0].SecurityLevel = securityLevel.guest; eArr[1].SecurityLevel = securityLevel.secretary; eArr[2].SecurityLevel = securityLevel.guest;
Console.WriteLine(eArr[0].SecurityLevel);

eArr[0].Salary = 1000; eArr[1].Salary = 2000; eArr[2].Salary = 3000;
Console.WriteLine(eArr[0].Salary);

eArr[0].HireDate = new hiringDate(1,1,2001); eArr[1].HireDate = new hiringDate(2, 2, 2001); eArr[2].HireDate = new hiringDate(3, 3, 2003);
Console.WriteLine(eArr[0].HireDate);


employeeSearch srch=new employeeSearch(eArr);
Console.WriteLine("\nSearchById +\n " + srch.srchByID(1) + "\n------------------------------\n");
Console.WriteLine("\nSearchByName +\n " + srch.srchByname("B") + "\n------------------------------\n");
Console.WriteLine("\nSearchByHire +\n " + srch.srchByHire("3/3/2003") + "\n------------------------------\n");


Console.WriteLine("------------------------\nINDEXERS\n");
Console.WriteLine(srch["A"].ToString());
Console.WriteLine(srch[2].ToString());
Console.WriteLine(srch[new hiringDate(3,3,2003)].ToString());

//-------------------------------------------------------------------
struct employee
{
    int id ;
    string name;
    securityLevel securityLevel;
    double salary;
    hiringDate hireDate;
    gender gender;


    public override string ToString()
    {
        return $"ID {id} ,name {name} , security Level {securityLevel} ,salary {String.Format("{0,-10:C}", salary)} , hireDate {hireDate.ToString()} ,gender {gender} ";
    }
    //getter and setter()
    //ID
    public int Id
    {
        set { id = value; }
        get { return id; }
    }
    //Name
    public string Name
    {
        set { name = value; }
        get { return name; }
    }
    //SecurityLevel
    public securityLevel SecurityLevel{
        set { securityLevel = value; }
        get { return securityLevel; }
    }

    //Salary
    public double Salary
    {
        set { salary = value; }
        get { return salary; }
    }
    public hiringDate HireDate
    {
        set { hireDate = value; }
        get { return hireDate; }
    }
   
    public void setGender(string g)
    {
        gender = (gender)Enum.Parse(typeof(gender), g);
    }
    public gender getGender()
    {
        return gender;
    }

}
struct hiringDate
{
    int day;
    int month;
    int year;
    
    public hiringDate(int d,int m,int y)
    {
        day = d;
        month = m;
        year = y;
    }
    public override string ToString()
    {
        return $"{day}/{month}/{year}";
    }


}
enum gender
{
    Female, Male
}
[Flags]
enum securityLevel : byte
{
    guest = 0X08, Developer = 0X04, secretary = 0X02, DBA = 0X01, securityOfficer = 0X0F
}

class employeeSearch
{
    int[] nationalIDs;
    hiringDate[] hire;
    string[] name;
    employee[] employees;
    int size;

    //ctor
    public employeeSearch(employee[] emp)
    {
        size = emp.Length;
        this.employees = emp;
        nationalIDs = new int[size];
        hire = new hiringDate[size];
        name = new string[size];

        for (int i = 0; i < size; i++)
        {
            nationalIDs[i] = employees[i].Id;
            hire[i] = employees[i].HireDate;
            name[i] = employees[i].Name;
        }

    }
    
    public override string ToString()
    {
        string s = "xx ";
        for(int i=0; i < employees.Length; i++)
        {
            s += employees[i].ToString();
        }
        return "a  "+s;
    }
    public employee[] Employee
    {
        set { employees = value; }
        get { return employees; }
    }
    public int[] NationalIds
    {
        set { nationalIDs = value; }
        get { return nationalIDs; }
    }
    public string srchByID(int id)
    {
        string res = "\n";

        for (int i = 0; i < size; i++)
        {
            if (nationalIDs[i] == id)
            {
                res += employees[i].ToString() + '\n';

            }
        }
        return res;

    }
    public string srchByname(string nam)
    {
        string res = "\n";

        for (int i = 0; i < size; i++)
        {
            if (name[i] == nam)
            {
                res += employees[i].ToString() + '\n';

            }
        }
        return res;

    }

    public string srchByHire(string hir)
    {
        string res = "\n";

        for (int i = 0; i < size; i++)
        {
            if (hire[i].ToString() == hir)
            {
                res += employees[i].ToString() + '\n';

            }
        }
        return res;

    }
    public employee this[string name]
    {
        get
        {
            for (int i = 0; i < size; i++)
            {
                if (employees[i].Name == name) return employees[i];
            }
            return default;
        }
    }
    public employee this[hiringDate hire]
    {
        get
        {
            for (int i = 0; i < size; i++)
            {
                if (employees[i].HireDate.ToString() == hire.ToString() )return employees[i];
            }
            return default;
        }
    }
    public employee this[int  id]
    {
        get
        {
            for (int i = 0; i < size; i++)
            {
                if (employees[i].Id== id) return employees[i];
            }
            return default;
        }
    }
}
