//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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace регулярные_выражения
{
    internal class Program
    {
        static List<int> sort(List<int>massiv)
        {
            int temp;
            for (int i = 0; i < massiv.Count;++i)
            {
                for(int j = i + 1; j < massiv.Count; ++j)
                {
                    if (massiv[j] < massiv[i])
                    {
                        temp = massiv[j];
                        massiv[j] = massiv[i];
                        massiv[i] = temp;
                    }
                }
            }
            return massiv;
        }
        static void Main(string[] args)
        {
            List<int> massiv = new List<int>() {7,8,8,9,4,1,5,3,4,5 };
            massiv = sort(massiv);
            foreach(int i in massiv)
            {
                Console.Write($"{i},");
            }
        }
    }
}
