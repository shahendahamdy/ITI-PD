// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

employee[] eArr=new employee[3];
for(int i=1; i<eArr.Length+1; i++)
{
    Console.WriteLine("Enter Emp "+i+ "data");

    Console.WriteLine("Enter ID");
    eArr[i].setID(int.Parse(Console.ReadLine()));

    Console.WriteLine("Enter Salary");
    eArr[i].setSalary(int.Parse(Console.ReadLine()));

    Console.WriteLine("Enter Gender {Femle ,Male}");
    eArr[i].setGender(Console.ReadLine());

    Console.WriteLine("Enter Security Level {guest, Developer ,secretary ,DBA ,securityOfficer}");
    eArr[i].setSecurityLevel(Console.ReadLine());

    Console.WriteLine("Enter Hiring date [day month year]");
    eArr[i].setHireDate(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

    Console.WriteLine("\n\n Output is ");
    Console.WriteLine(eArr[i].ToString()+"\n\n");


}




struct employee
{
    public int Id;
    public securityLevel SecurityLevel;
    public double salary;
    public hiringDate hireDate;
    public gender gender;

    
    public override string ToString()
    {
        return $"ID {Id} , security Level {SecurityLevel} ,salary {String.Format("{0,-10:C}", salary)} , hireDate {hireDate.getHiringDate()} ,gender {gender} ";
    }
    public void setID(int id) { Id= id ; }
    public int getId() { return Id ; }
    public void setSecurityLevel(string s) {
        SecurityLevel = (securityLevel)Enum.Parse(typeof(securityLevel),s);
    }
    public securityLevel getSecurityLevel() { return SecurityLevel; }
    public void setSalary(double s) { salary = s; }
    public double getSalary() {
        return salary ; }
    public void setHireDate(int day,int month,int year)
    {
         hireDate.setDay(day); hireDate.setMonth(month); hireDate.setYear(year);
    }
    
    public string getHireDate()
    {
        return hireDate.getHiringDate() ;
    }
    public void setGender(string g)
    {
        gender = (gender)Enum.Parse(typeof(gender),g);
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
    public void setDay(int d){  day= d ;} 
    public void setMonth(int m) { month= m ; }
    public void setYear(int y) { year= y ; }
    public string getHiringDate() { return $"{day}/{month}/{year}"; }

    
}
enum gender
{
    Female, Male
}
[Flags]
enum securityLevel :byte
{
    guest=0X08, Developer=0X04, secretary=0X02,DBA=0X01, securityOfficer=0X0F
}
