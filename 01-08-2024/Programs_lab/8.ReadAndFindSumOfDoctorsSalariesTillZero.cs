QUESTION
8.ReadAndFindSumOfDoctorsSalariesTillZero() use do..while loop 


****pseuodcode****


function ReadAndFindSumOfDoctorsSalariesTillZero()
    sum = 0 
    do 
        input salary 
        if !(salary > 0 || salary == 0) //Invalid salary
            print "Input valid salary"
            continue 
        end if 
        sum += salary 
    while salary != 0
    print sum 


****C# CODE*****


class  ReadAndFindSumOfDoctorsSalariesTillZerodowhile()
{

  static void ReadAndFindSumOfDoctorsSalariesTillZero()
  {
    int sum = 0 ;
    do 
    {
        Console.Write("Enter salary");
        int salary = int.Parse(Console.ReadLine());
        if (salary < 0 ) //Invalid salary
        {
            Console.WriteLine("ENTER valid salary");
            continue ;
        }
        
        if (salary != 0) // Business Rule
        {
            sum += salary;
        } 
    } while (salary != 0);
      Console.WriteLine($"sum is : {sum}");
  }


 static void Main(string[] args) 
    {
        ReadAndFindSumOfDoctorsSalariesTillZero();
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
    
    
}
