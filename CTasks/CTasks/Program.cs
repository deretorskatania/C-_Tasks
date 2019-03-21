using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CTasks
{   

    class Program
    {

        static void Main(string[] args)
        {
            //Task1
            Task1 task1 = new Task1(2, 3);
            Console.WriteLine("Task 1");
            Console.WriteLine(task1.chooseBigger + "\n");

            //Task2
            double[] someArray = new double[] { 12, 30, 1, -2, 0, 26, 84, -40, 52, -64 };
            Console.WriteLine("Task 2");
            if (someArray.Length != 0)
            {
                Task2 task2 = new Task2(someArray);
                Console.WriteLine(task2.findMax + "  " + task2.findMin + "\n");
            }
           
            //Task3
            double[] myArray = new double[] { 12, 30, 1, -2, 0, 26, 84, -40, 52, -64 };
            if (myArray.Length != 0)
            {
                double[] result = Task3.filterArray(myArray, 0, 50);
                Console.WriteLine("Task 3");
                for (int i = 0; i < result.Length; i++)
                    Console.WriteLine(result[i]);
                Console.WriteLine("\n");
            }

            //Task4
            string text = "Hello.sfd  !";
            if (text.Length != 0)
            {
                Task4 task4 = new Task4(text);
                Console.WriteLine("Task 4");
                Console.WriteLine(task4.wordsCounter);
                Console.WriteLine("\n");
            }

            //Task5
            double x = 4;
            double y = 10;
            Console.WriteLine("Task 5");
            Console.WriteLine(Task5.Calculator.sub(Task5.Calculator.sum(x, Task5.Calculator.mult(x, 5)), Task5.Calculator.div(y, 2)));
            Console.WriteLine("\n");

            //Task6
            string text1 = "In many countries there is a pecking order to the universities, with a few high-status institutions at the top, turning out an intellectual elite and attracting the best minds in teaching and research.";
            string [] mas = new string[] { "in", "the", "universities" };
            if (text.Length != 0 && mas.Length != 0)
            {
                Words[] words = new Words[mas.Length];
                words = Task6.findWords(text1, mas);
                Console.WriteLine("Task 6");
                for (int i = 0; i < mas.Length; i++)
                    words[i].print();
                Console.WriteLine("\n");
            }
            //Task7
            double[] array = new double[] { 11, 35, 1, -2, 10, 25, 84, -40, 52, 41 };
            if (array.Length != 0)
            {
                IsOdd[] numbers = new IsOdd[array.Length];
                numbers = Task7.OddOrEven(array);
                Console.WriteLine("Task 7");
                for (int i = 0; i < array.Length; i++)
                    numbers[i].print();                
            }
            Console.ReadLine();
        }           
    }
}
