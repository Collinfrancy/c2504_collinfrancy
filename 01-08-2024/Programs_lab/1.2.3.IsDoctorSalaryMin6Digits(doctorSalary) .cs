1.)IsDoctorSalaryMin6Digits(doctorSalary) 
2.)TestIsDoctorSalaryMin6Digits()
3.)TestIsDoctorSalaryMin6DigitsOrNot()

  ****pseudocode***

  function IsDoctorSalaryMin6Digits(doctorSalary) 
        salary = doctorSalary
        count = 0
        while salary > 0            
            digit = salary % 10     
            count += 1               
            salary = salary / 10    
        end while 
        return count >= 6

function TestIsDoctorSalaryMin6Digits()
    Input doctorSalary
    if IsDoctorSalaryMin6Digits(doctorSalary)
        print "Doctor gets Min 6 digits salary"
    end if 

function TestIsDoctorSalaryMin6DigitsOrNot()
    Input doctorSalary
    if IsDoctorSalaryMin6Digits(doctorSalary)
        print "Doctor gets Min 6 digits salary"
    else 
        print "Doctor does not get Min 6 digits salary"
    end if 


      
      
***C# CODE*****


class IsDoctorSalaryMin6Digits
{
    static bool IsDoctorSalaryMin6Digits(int doctorSalary)    //main routine for which returns true if the count is above 6
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

// ***TEST CASE 1*****

    // input=678943, output="Doctor gets 6 digits salary"
    // input=67894, ouput="Doctor does not get 6 digits salary"
    // input=67894356, output="Doctor gets 6 digits salary"
   
static void TestIsDoctorSalaryMin6DigitsOrNot()
    {
        Console.WriteLine("Enter doctor salary:");
        int doctorSalary = int.Parse(Console.ReadLine());
        if(IsDoctorSalaryMin6Digits(doctorSalary))
        { 
            Console.WriteLine("Doctor gets Min 6 digits salary");
        }
        else
        {
            Console.WriteLine("Doctor does not get Min 6 digits salary");
        }
    }

// ***TEST CASE 2*****

    // input=678943, output="Doctor gets 6 digits salary"
    // input=67894, ouput=no output
    // input=67894356, output="Doctor gets 6 digits salary"
    static void TestIsDoctorSalaryMin6Digits()
    {
        Console.WriteLine("Enter doctor salary:");
        int doctorSalary = int.Parse(Console.ReadLine());
        if (IsDoctorSalaryMin6Digits(doctorSalary))
        {
            Console.WriteLine("Doctor gets Min 6 digits salary");
        }
    }

    static void Main(string[] args) 
    {
        TestIsDoctorSalaryMin6Digits();
        TestIsDoctorSalaryMin6DigitsOrNot();
        Console.WriteLine("Press any key to contine...");
        Console.ReadKey();
    }
}

