using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhyscExamSort
{
    class PhyscExamSort
    {

        public class PhyscData
        {
            public string Name;
            public int Height;
            public double Vision;

            public PhyscData(string name, int height, double vision)
            {
                Name = name;
                Height = height;
                Vision = vision;
            }

            public String toString()
            {
                return Name + " " + Height + " " + Vision;
            }

            public readonly IComparable<PhyscData> HEIGHT_ORDER = new HeightOrdercomparator();

            private class HeightOrdercomparator : IComparable<PhyscData>
            {
                public int compare(PhyscData d1, PhyscData d2)
                {
                    return d1.Height > d2.Height ? 1 :
                        d1.Height < d2.Height ? -1 : 0;
                }

                public int CompareTo(PhyscData other)
                {
                    throw new NotImplementedException();
                }
            }






            public static void Main(string[] args)
            {
                PhyscData[] x =
                {
                    new PhyscData("이나령", 162, 0.3),
                    new PhyscData("전서현", 173, 0.7),
                    new PhyscData("이수민", 175, 2.0),
                    new PhyscData("홍준기", 171, 1.5),
                    new PhyscData("유지훈", 168, 0.4)
                };

                Array.Sort(x);

                for (int i=0; i<x.Length; i++)
                {
                    Console.WriteLine(x[i].Name);
                }
            }


        }
    }
    
}
