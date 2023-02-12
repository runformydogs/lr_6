using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            N1_1();
        }
        static void N1_1()
        {
            string[] Name1 = new string[] { "Sasha", "Andrey", "Max", "Ivan", "Nikita", "Misha", "Nika", "Masha", "Vika", "Vitia", "Danil", "Dima", "NN", "Bill" };

            Group[] g1 = RandomGroup(Name1, 5, 5, 2, 6);
            Group[] g2 = RandomGroup(Name1, 5, 5, 2, 6);
            Group[] g3 = RandomGroup(Name1, 5, 5, 2, 6);


            Console.WriteLine("1 группа ");
            PrintGroup(g1);
            Console.WriteLine("2 группа ");
            PrintGroup(g2);
            Console.WriteLine("3 группа ");
            PrintGroup(g3);

            double g1_score = Sr_score(g1);
            Console.WriteLine(g1_score);
            double g2_score = Sr_score(g2);
            Console.WriteLine(g2_score);
            double g3_score = Sr_score(g3);
            Console.WriteLine(g3_score);

        }
        struct Group
        {
            public string Name;
            public int[] Marks;

            public Group(string Name, int[] Marks)
            {
                this.Name = Name;
                this.Marks = Marks;
            }
        }
        static Group[] RandomGroup(string[] name, int amount, int h, int k, int l)
        {
            Random random = new Random();
            Group[] name1 = new Group[amount];

            for (int i = 0; i < amount; i++)
            {
                int[] Marks = new int[h];
                for (int j = 0; j < Marks.Length; j++)
                {
                    Marks[j] = random.Next(k, l);
                }
                int name_number = random.Next(0, amount);
                name1[i] = new Group(name[name_number], Marks);
            }
            return name1;
        }
        static void PrintGroup(Group[] print)
        {
            for (int i = 0; i < print.Length; i++)
            {
                Console.Write(print[i].Name + " ");
                for (int j = 0; j < 5; j++)
                {
                    int marks = print[i].Marks[j];
                    Console.Write(marks + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static double Sr_score(Group[] score)
        {
            double marks = 0;
            for (int i = 0; i < score.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    marks += score[i].Marks[j];
                }
            }
            return marks/(score.Length*5);
        }
    }
}
