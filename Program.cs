// int number, secondNum, counter=0;
// number = Convert.ToInt32(Console.ReadLine());
// int[] Arr = new int[number];
// for(int i=0; i<number; i++)
// {
//     Arr[i] = Convert.ToInt32(Console.ReadLine());

// }

// secondNum = Convert.ToInt32(Console.ReadLine());

// for(int i=0; i<number; i++)
// {
//     if(Arr[i]==secondNum)
//     {
//         counter++;
//     }
// }

// Console.WriteLine($"{counter}");



// Console.ReadKey();

// int num;
// num = Convert.ToInt32 (Console.ReadLine());


// System.Console.WriteLine();
// System.Console.WriteLine("enter a number:");
// System.Console.WriteLine(num);




// Car bmv = new Car();

// bmv.Color = "aqua";
// bmv.Make = "xaymayli";
// bmv.Model = "bmw";

// System.Console.WriteLine(bmv.Color);
// System.Console.WriteLine(bmv.Make);
// System.Console.WriteLine(bmv.Model);


class Calculator
{
  public string Name;
  public string Surname;
  public DateTime BirthDate;
  public List<double> Grades;
  public string GetFullName()
  {
      return $"{Surname} {Name}";
  }
  public double GetGrade()
  {
      double sum = 0;
      foreach (var item in Grades)
      {
          sum+=item;
      }
      return sum;
  }


var student1 = new Calculator();
student1.Name = "Mirzo";
var student1.Surname = "mitmi";


