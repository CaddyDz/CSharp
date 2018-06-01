using System;

namespace CSharpTutA
{
    class Television : IElectronicDevice
    {
        public int Volumn { get; set; }
        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void VolumnDown()
        {
            if (Volumn != 0)
            {
                Volumn--;
            }
            Console.WriteLine($"The TV Volumn is at {Volumn}");
        }

        public void VolumnUp()
        {
            if (Volumn != 100)
            {
                Volumn++;
            }
            Console.WriteLine($"The TV Volumn is at {Volumn}");
        }
    }
}
