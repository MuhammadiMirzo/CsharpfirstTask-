int number, secondNum, counter=0;
number = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int[number];
for(int i=0; i<number; i++)
{
    Arr[i] = Convert.ToInt32(Console.ReadLine());

}

secondNum = Convert.ToInt32(Console.ReadLine());

for(int i=0; i<number; i++)
{
    if(Arr[i]==secondNum)
    {
        counter++;
    }
}

Console.WriteLine($"{counter}");



Console.ReadKey();
