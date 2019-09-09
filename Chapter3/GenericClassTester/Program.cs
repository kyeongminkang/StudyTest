using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassTester
{
    class Program
    {

        class GenericClass<T>
        {
            private T xyz;
            public GenericClass(T t)
            {
                this.xyz = t;
            }
            public T getXyz()
            {
                return xyz;
            }
        }
        static void Main(string[] args)
        {
            GenericClass<string> s = new GenericClass<string>("ABC");
            GenericClass<int> n = new GenericClass<int>(15);

            Console.WriteLine(s.getXyz());
            Console.WriteLine(n.getXyz());
        }

        // static? 정적 메서드 public 생성자 x 모든 멤버 static, 생성자 역시 static (why? static 객체 생성x)
        // 처음 메서드가 사용될 때 초기화 되어 동일 메모리를 사용 (nonstatic의 경우 클래스 인스턴스 생성 마다 메모리에 매번 새로 생성)
        // 다시 체크할 것!
    }
}
