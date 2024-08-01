QUESTION
7. ReadAndFindMinSalaryOfNDoctors() without array

****pseudocode***

function ReadAndFindMinSalaryOfNDoctors():
    MinSalary = -1
    Input N //number of salaries 
    for I = 1 .. N 
        Input salary
        if I == 1 then 
             MinSalary = salary 
             continue 
        end if 

        if salary < MinSalary then 
            MinSalary = salary
        end if 


 ****C# CODE******         


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
