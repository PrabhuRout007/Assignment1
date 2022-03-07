using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Create_Student : Student_marks
    {
        public string[] StudentName = new string[2];
        public string Name;
        public int Rank=0;
        int j=0;

        public int[] TotalMark= new int[2];

        public void Create_Student_Account()
        {
            for (int i = 0; i < StudentName.Length; i++)
            {
                Console.WriteLine("Enter Student Name");
                StudentName[i] = Console.ReadLine();
        
           }
        }

        public void Enter_Marks()
        {
           
            Console.WriteLine("Enter the Student Name for whom you want to store Marks");
            Name = Console.ReadLine();
            for (int i = 0; i < StudentName.Length; i++)
                if (StudentName[i] == Name)
                    {
                            marks();
                            TotalMark[j] = Students_mark[0] + Students_mark[1] + Students_mark[2];
                            Console.WriteLine(TotalMark[j]);
                    j++;
                    }
            }
 
        public void Display()
        {
            for (int i = 0; i < StudentName.Length; i++)
            {
                Console.WriteLine("Student Name: {0}, Student Total Marks: {1} \n ", StudentName[i], TotalMark[i]);
                
            }

        }
        public void RankList()
        {
            
            int[] temp = TotalMark;
            Array.Sort(temp);
            Array.Reverse(temp);
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[i] == TotalMark[j])
                    {
                        Rank++;
                        Console.WriteLine("Rank: {0} Name : {1} ",Rank, Name);
                    }
                }

            }





        }
            
                
        }

        }
    

