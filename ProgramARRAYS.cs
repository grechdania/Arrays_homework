//FIRST AND SECOND TASKs

//int[] numbers = new int[10];
//Random random = new Random();
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(-10, 10);
//    sum = sum + numbers[i];

//    if (i % 2 == 0)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}

//if (sum < 0)
//{
//    Console.WriteLine("Sum is not an integer");
//}
//else 
//{
//    Console.WriteLine("Sum is an integer");
//}



//THIRD TASK


//int[,] numbers = new int[9, 9] { {1,2,3,4,5,6,7,8,9}, {1,2,3,4,5,6,7,8,9}, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };

//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        numbers[i, j] = numbers[i, j] * (i+1);
//        Console.Write($"{numbers[i, j]} ");
//    }
//    Console.WriteLine();
//}




//FORTH TASK

//using System.Runtime.InteropServices;

//int[,] numbers = new int[5, 5];
//Random random = new Random();
//int max = 0;
//int min = 0;
//int i_min = 0;
//int j_min = 0;
//int i_max = 0;
//int j_max = 0;

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        numbers[i, j] = random.Next(-150, 150);
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {

//        int current_value = numbers[i, j];
//        if (current_value > max)
//        {
//            i_max = i;
//            j_max = j;
//            max = current_value;
//        }


//        if(current_value < min)
//        {
//            i_min = i;
//            j_min = j;
//            min = current_value;
//        }           
//    }
//}

//Console.WriteLine($"Biggest number: {max}, the coordinates: {i_max}, {j_max}");
//Console.WriteLine($"Biggest number: {min}, the coordinates: {i_min}, {j_min}");



using System.Reflection.Emit;

Console.WriteLine("Enter the number of days");
int number = Int32.Parse(Console.ReadLine());
if (number > 7)
{
    number = number - (number / 7) * 7;
}

var day = (WeekDays)number;

Console.WriteLine($"Your day is {day}");

enum WeekDays
{
    Monday = 1,    // 1
    Tuesday,   // 2
    Wednesday,  // 3
    Thursday,   // 4
    Friday,     // 5
    Saturday,   // 6
    Sunday      // 7
}