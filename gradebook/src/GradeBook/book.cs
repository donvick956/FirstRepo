using System.Collections.Generic;


namespace GradeBook

{
    class book
    
    
    {

        public book()
        {
         figures = new List<double>();
        }
       public void AddGrade( double grade)
       {
         figures.Add (grade);
       }

       List<double> figures;
    }
}