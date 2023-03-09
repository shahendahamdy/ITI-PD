namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            int res = 0 ,num1=0,num2=0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i] && j-i-1>res)
                    {
                        res=j-i-1; num1 = arr[i]; num2 = arr[j];
                    }
                }
               
            }
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            Console.WriteLine(" ");
            Console.WriteLine("the difference between "+num1+" And "+num2+" is "+res);
          
        }
    }
}