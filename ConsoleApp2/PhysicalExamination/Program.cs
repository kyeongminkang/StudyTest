using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalExamination
{
    class Program
    {
        const int VMAX = 21;

        public class PhyscData
        {
            public string name;
            public int height;
            public double vision;

            public PhyscData(string name, int height, double vision)
            {
                this.name = name;
                this.height = height;
                this.vision = vision;
            }
        }

        public static double aveHeight(PhyscData[] dat)
        {
            double sum = 0;

            for (int i=0; i< dat.Length; i++)
            {
                sum += dat[i].height;
            }

            return sum / dat.Length;
        }

        static void distVision(PhyscData[] dat, int[] dist)
        {
            int i = 0;

            dist[i] = 0;
            for (i = 0; i<dat.Length; i++)
            {
                if(dat[i].vision >= 0.0 && dat[i].vision <= VMAX / 10.0)
                {
                    dist[(int)(dat[i].vision * 10)]++;

                }
            }
        }




        static void Main(string[] args)
        {

            PhyscData[] x =
            {
                new PhyscData("박현규", 162, 0.3),
                new PhyscData("함진아", 173, 0.7),
            };

            int[] vdist = new int[VMAX];

            Console.WriteLine("신체검사 리스트");
            Console.WriteLine("이름       키  시력");
            for (int i=0; i<x.Length; i++)
            {
                Console.WriteLine($"{x[i].name, -5}   {x[i].height}  {x[i].vision}");
            }

            Console.WriteLine($"평균 키 : {aveHeight(x)}");

            distVision(x, vdist);

            Console.WriteLine("시력분포");

            for (int i=0; i< VMAX; i++)
            {
                Console.WriteLine($"{i / 10.0} ~ : {vdist[i]}명");
            }




        }
        
    }
}
