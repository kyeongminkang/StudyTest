using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSet_3
{
    public class IntSet
    {
        private int max; // 집합 최대 개수
        private int num; // 집합 요소 개수
        private int[] set; // 집합 본체

        public IntSet(int capacity)
        {
            num = 0;
            max = capacity;
            try
            {
                set = new int[max]; //집합 배열 생성
            }
            catch (OutOfMemoryException) // 실패
            {
                max = 0;
            }
        }

        public int capacity()
        {
            return max;
        }

        public int size()
        {
            return num;
        }

        public int indexOf(int n)
        {
            for (int i = 0; i < num; i++)
            {
                if (set[i] == n)
                    return i;
            }
            return -1;
        }

        public bool contains(int n)
        {
            return (indexOf(n) != -1) ? true : false;
        }

        public bool add(int n)
        {
            // 가득 찼거나 이미 n이 존재할 때
            if (num >= max || contains(n) == true)
            {
                return false;
            }
            else
            {
                set[num++] = n; // 가장 마지막에 추가
                return true;
            }
        }

        public bool remove(int n)
        {
            int idx;

            if (num <= 0 || (idx = indexOf(n)) == -1) // 비어 있거나 n이 존재안함
            {
                return false;
            }
            else
            {
                set[idx] = set[--num]; //마지막 요소를 삭제한 곳으로 옮김
                return true;
            }
        }

        // 집합 s에 복사
        public void copyTo(IntSet s)
        {
            int n = (s.max < num) ? s.max : num;
            for (int i = 0; i < n; i++)
            {
                s.set[i] = set[i];
            }
            s.num = n;

        }

        // 집한 s를 복사
        public void copyFrom(IntSet s)
        {
            int n = (max < s.num) ? max : s.num;
            for (int i = 0; i < n; i++)
            {
                set[i] = s.set[i];
            }
            num = n;
        }

        public bool equalTo(IntSet s)
        {
            if (num != s.num)
                return false;

            for (int i = 0; i < num; i++)
            {
                int j = 0;
                for (; j < s.num; j++)
                {
                    if (set[i] == s.set[j])
                        break;
                }
                if (j == s.num)
                    return false;

            }
            return true;
        }

        // 집한 s1과 s2 합집합 복사
        public void unionOf(IntSet s1, IntSet s2)
        {
            copyFrom(s1); //집합 s1복사
            for (int i = 0; i < s2.num; i++)
            {
                add(s2.set[i]);
            }
        }

        // 7-1
        // 공집합인지 확인
        public bool isEmpty()
        {
            return num == 0;

        }

        // 집합이 가득 찼는지 확인
        public bool isFull()
        {
            return num >= max;
        }

        // 집합을 초기화
        public void clear()
        {
            num = 0;
        }

        // 7-2
        // 집합 s의 모든 요소를 추가할 때 집합이 변경되는가?
        public bool add(IntSet s)
        {
            bool flag = false;
            for (int i = 0; i < num; i++)
            {
                if (add(set[i]) == true)
                    return true;

            }
            return flag;
        }

        // 집합 s에 들어있는 요소만 남기고 들어있지 않은 요소는 삭제할 때, 집합이 변경되는가?
        public bool retain(IntSet s)
        {
            bool flag = false;
            for (int i = 0; i < num; i++)
            {
                if (s.contains(set[i]) == false)
                {
                    remove(set[i]);
                    flag = true;
                }
            }
            return flag;
        }

        // 집합 s에 들어있는 요소를 삭제하는 메서드
        public bool remove(IntSet s)
        {
            bool flag = false;
            for (int i = 0; i < num; i++)
            {
                if (s.contains(set[i]) == true)
                {
                    remove(set[i]);
                    flag = true;
                }
            }
            return flag;
        }

        // 7-3
        // 집합 s의 부분집합인지 확인
        public bool isSubsetOf(IntSet s)
        {
            for (int i = 0; i < num; i++)
            {
                int j = 0;
                for(; j<s.num; j++)
                {
                    if (set[i] == s.set[j])
                        break;
                }
                if (j == s.num)
                    return false;
            }
            return true;
               
        }

        // 집합 s의 진부분집합인지 확인
        public bool isProperSubsetOf(IntSet s)
        {
            if (num >= s.num)
                return false;
            return s.isSubsetOf(s);
        }


        public string toString()
        {
            StringBuilder temp = new StringBuilder("{ ");
            for (int i = 0; i < num; i++)
            {
                temp.Append(set[i] + " ");
            }
            temp.Append(" }");
            return temp.ToString();

        }
    }
}
