using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysExamsearch
{
    class PhysExamsearch
    {
        private class physcData
        {
            private string name;
            private int height;
            private double vision;

            public physcData(string name, int height, double vision)
            {
                this.name = name;
                this.height = height;
                this.vision = vision;
            }

            public string tostring()
            {
                return name + " " + height + " " + vision;
            }
    
            public static readonly Comparer<physcData> HEIGHT_ORDER = new HeightOrdercomparaotr();

            private class HeightOrdercomparaotr : Comparer<physcData>
            {
                public override int Compare(physcData x, physcData y)
                {
                    return (x.height > y.height) ? 1 :
                        (x.height < y.height) ? -1 : 0;
                }
            }
        }
        
        static void Main(string[] args)
        {
            physcData[] x = {
                new physcData("이나령", 162, 0.3),
                new physcData("유지훈", 168, 0.4),
                new physcData("김한결", 169, 0.8),
                new physcData("홍준기", 171, 1.5),
                new physcData("전서현", 173, 0.7),
                new physcData("이호연", 174, 1.2),
                new physcData("이수민", 175, 2.0),
            };
            Console.Write("몇 cm인 사람을 찾고 있나요? ");
            int height = Convert.ToInt32(Console.ReadLine());

            int idx = Array.BinarySearch(
                x,
                new physcData("", height, 0.0),
                physcData.HEIGHT_ORDER
                
                );

            if (idx < 0)
                Console.WriteLine("요소가 없습니다.");
            else
                Console.WriteLine("x[" + idx + "]에 있습니다.");
                Console.WriteLine("찾은 데이터 : " + x[idx].tostring());

        }
    }
}
