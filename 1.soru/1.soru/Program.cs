using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 10, 10 };
            int[] B = { 30, 20 };
            int[] C = { 20, 40 };
            int[] D = { 20, 30 };
            int bx, by, cx, cy, x, y;
            double d,WA,WB,WC;
            bx = B[0] - A[0]; by= B[1] - A[1];
            cx = C[0] - A[0];cy= C[1] - A[1];
            x = D[0] - A[0]; y = D[1] - A[1];
            d = bx * cy - cx * by;
            WA = (x * (by - cy) + y * (cx - bx) + bx * cy - cx * by)/d;
            WB = (x * cy - y * cx) / d;
            WC = (y * bx - x * by) / d;
            if (0<WA && WA<1 && 0<WB && WB<1 && 0<WC && WC<1)
            {
                Console.WriteLine("Nokta üçgen alanının içerisinde");
            }
            else
            {
                Console.WriteLine("Nokta üçgen alanının içerisinde değil");
            }
            Console.ReadKey();
        }
    }
}
