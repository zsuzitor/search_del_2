using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_del_2
{
    //class ad
    //{
    //    int g = 0;

    //    public void fc()
    //    {
    //        g = 10;
    //    }
    //}


    class Program
    {

        public static int? funcc(List<int> mass,int start,int end,int num,int? nn1=null)
        {
            int nn = (end-start) / 2+start;
            //if (end == start && mass[start] != num)
            if(nn==nn1)
               return null;
            
               
            if (mass[nn] < num)
            {
                return funcc(mass, nn, end, num, nn);
            }
            else
            {
                if (mass[nn] > num)
                {
                    return funcc(mass, start, nn, num, nn);
                }
                else
                {
                    return nn;
                }
            }
        }


        static void Main(string[] args)
        {
            List <int>mass =new List<int> { };// 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
            for (int i = 5; i < 1000; ++i)
                mass.Add(i);

            for (;;)
            {
                Console.WriteLine("введите число");
                int num = Convert.ToInt32(Console.ReadLine());
                int? res = funcc(mass, 0, mass.Count, num);
                if(res==null)
                    Console.WriteLine("ошибка");
                else
                    Console.WriteLine(res);
                Console.WriteLine();
            }
           



            Console.ReadKey();
        }
    }
}
