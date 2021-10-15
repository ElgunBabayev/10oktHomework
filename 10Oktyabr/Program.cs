using System;

namespace _10Oktyabr
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertisement adv1= new Advertisement("SL540",5500,"MAN");
            Advertisement adv2 = new Advertisement("SWG 45", 4000, "Schneider");
            Advertisement adv3 = new Advertisement("VRK 78", 15000, "MAN");

            Advertisement[] advertisement = { adv1, adv2, adv3 };

            Array.Sort(advertisement);

                foreach (Advertisement item in advertisement)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(adv1>adv2);

            


        }
    }
    
    
}
