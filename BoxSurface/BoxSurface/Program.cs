using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Length: ");
                double inputLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Width: ");
                double inputWidth = double.Parse(Console.ReadLine());
                Console.WriteLine("Height: ");
                double inputHeight = double.Parse(Console.ReadLine());

                Box box = new Box(inputLength, inputWidth, inputHeight);
                Console.WriteLine($"Surface Area - {box.GetSurfaceArea()}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea()}");
                Console.WriteLine($"Volume - {box.GetVolume()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
