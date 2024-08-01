QUESTION
6.  ReadAndCountDoctorsMin6DigitsSalaried(): without array 

****pseudocode*****


function ReadAndCountDoctorsMin6DigitsSalaried(): 
[Minnu: without array]
    count = 0 
    Input N //number of salaries 
    for I = 1 .. N 
        Input salary 
        isMin6Digits = IsDoctorSalaryMin6Digits(salary)
        if isMin6Digits then 
            count += 1
        end if 


****C# CODE*****


class ReadAndCountDoctors6DigitsSalariedwithoutarray
{

 static bool IsDoctorSalaryMin6Digits(int doctorSalary)   //For counting the digits,returns true if count>=6
    {
        int salary = doctorSalary;
        int count = 0;
        while (salary > 0)
        {
            int digit = salary % 10;
            count += 1;
            salary = salary / 10;
        }
        return count >= 6;
    }


static void ReadAndCountDoctors6DigitsSalaried()
{
   int count = 0 ;
   Console.Write("ENter number of salaries");
   int n = int.Parse(Console.ReadLine());
   for (int i=1;i<n;i++)
    {
       int salary = int.Parse(Console.ReadLine());
       int isMin6Digits = IsDoctorSalaryMin6Digits(salary);
       if (isMin6Digits) 
        {
            count += 1;
         }
    }
   Console.WriteLine($"count is : {count}");
}

 static void Main(string[] args) 
    {
        ReadAndCountDoctors6DigitsSalaried();
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
}
