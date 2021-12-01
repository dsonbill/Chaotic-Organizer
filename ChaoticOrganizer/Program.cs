using System;
using System.Threading;

namespace ChaoticOrganizer
{
    class Programz
    {
        static void Main(string[] args)
        {
            Organizer organizer = new Organizer();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Organizer.Payload payload = organizer.Pump();

                if (payload.Locked == true && payload.Solver == "DCC" && payload.Link == payload.Latch)
                {
                    //payload.Designation
                    //payload.Information

                    //payload.Link
                    //payload.Code
                    //payload.Target

                    //payload.Latch

                    //payload.Locked

                    //payload.Solver

                    Console.WriteLine("Designation: " + payload.Designation + " " +
                        "Information: f" + payload.Information + " " +
                        "Code: " + payload.Code + " " +
                        "Target: " + payload.Target);
                }
            }

        }
    }
}
