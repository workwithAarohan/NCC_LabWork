using System;

namespace Inheritance
{
    public class MarkSheet: Student 
    {
        public int marksInCDC, marksInNCC, marksInSE;
        float percentage;


        public MarkSheet(int CDC, int NCC, int SE)
        {
            marksInCDC = CDC;
            marksInNCC = NCC;
            marksInSE = SE;

            percentage = (marksInCDC+marksInNCC+marksInSE)/3;
        }

        public void Result()
        {
            addStudent("Aarohan",1);
            this.personalDetail();
            Console.WriteLine("I got {0} percentage.", percentage);
        }
    }
}


