***ReadAndFindMinSalaryOfNDoctors without array ****

class ReadAndFindMinSalaryOfNDoctorswithoutarray
{
   static void  ReadAndFindMinSalaryOfNDoctors()
   {
   int MinSalary = -1;
   Console.Write("Enter number of salaries");
   int n = int.Parse(Console.ReadLine());
     for (int i=1;i<n;i++)
    {
        int salary = int.Parse(Console.ReadLine());
        if (i == 1){
           MinSalary = salary;
           continue;
          }
        if (salary < MinSalary)
        {
            MinSalary = salary;
        }
        
     }
  }
  
 static void Main(string[] args) 
    {
        ReadAndFindMinSalaryOfNDoctors();
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
    
    
}
