using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            { var figures = new List<int>{ 3,4,5,6,7};

               var book = new book();
               book.AddGrade(6.7);
         
                figures.Add(50);
                decimal result = 0;

            foreach(var number in figures)
            {
                result += number;
            }
            result = result/figures.Count;
            System.Console.WriteLine($"the average figures is {result}");

            }
    }
    
    
}
}

            
               


            
        
    

