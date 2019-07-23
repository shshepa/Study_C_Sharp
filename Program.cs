using System;



namespace Second_Theme
{
    class Program
    {
        public class FString
        {
            public string f, s;
            public FString(string x, string y)
            {
                f = x;
                s = y;
            }
        }
        public struct RTK
        {
            public int a, b, c;
            public RTK(int q, int w, int e)
            {
                Console.WriteLine($"{q}----{w}----{e}");
                while(q >= w )
                {
                    while (w >= e)
                    {
                        e++;
                        w--;
                    }
                    q--;
                    w++;
                }
                a = q;
                b = w;
                c = e;
            }
            
            }
        static void Main(string[] args)
        {
            FString str = new FString(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine($"{str.f} \n {str.s}");
            RTK ineger = new RTK(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("struct");
            Console.WriteLine($"{ineger.a}-----{ineger.b}----------{ineger.c}");
        }
        
    }
}
    