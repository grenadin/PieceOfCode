using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace PieceOfCode
{
    class Program
    {
        static void Main()
        {
            var buffer = new CircularBuffer(3);

            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }

            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while(!buffer.IsEmpty) //do it when true
            {
                Console.WriteLine(buffer.Read()); 
            }
            //Console.WriteLine(sum);
        }

      
    }

   

       
}
