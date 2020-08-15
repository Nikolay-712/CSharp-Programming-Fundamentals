using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {

            string Month = Console.ReadLine();
            int NightCount = int.Parse(Console.ReadLine());

            double ResultStudio = 0;
            double ResultRoomDouble = 0;
            double ResultSuite = 0;

            if (Month.Equals("May") || Month.Equals("October"))
            {
                double Studio = 50;
                double RoomDouble = 65;
                double Suite = 75;

                ResultStudio =  Studio * NightCount;
                ResultRoomDouble =  RoomDouble * NightCount;
                ResultSuite =  Suite * NightCount;


                if (NightCount > 7)
                {
                    double RateDown = Studio - (Studio * 5 / 100);

                    ResultStudio = RateDown * NightCount;
                    ResultRoomDouble = RoomDouble * NightCount;
                    ResultSuite = Suite * NightCount;
                }
            }

            if (Month.EndsWith("June") || Month.Equals("September"))
            {
                double Studio = 60;
                double RoomDouble = 72;
                double Suite = 82;

                ResultStudio =  Studio * NightCount;
                ResultRoomDouble =  RoomDouble * NightCount;
                ResultSuite =  Suite * NightCount;


                if (NightCount > 14)
                {
                    double RateDown = RoomDouble - (RoomDouble * 10 / 100);

                    ResultStudio =  Studio * NightCount;
                    ResultRoomDouble = RateDown * NightCount;
                    ResultSuite =  Suite * NightCount;

                }

            }

            if (Month.EndsWith("July") || Month.Equals("August") || Month.Equals("December"))
            {
                double Studio = 68;
                double RoomDouble = 77;
                double Suite = 89;

                ResultStudio =  Studio * NightCount;
                ResultRoomDouble = RoomDouble * NightCount;
                ResultSuite =  Suite * NightCount;

                if (NightCount > 14)
                {
                    double RateDown = Suite - (Suite * 15 / 100);

                    ResultStudio = Studio * NightCount;
                    ResultRoomDouble =  RoomDouble * NightCount;
                    ResultSuite =  RateDown * NightCount;
                }
            }

            if(Month.Equals("September") && NightCount >= 7)
            {

                double Studio = 60;
                double RoomDouble = 72;
                double Suite = 82;

              
                ResultStudio =  Studio * NightCount - Studio;
                ResultRoomDouble =  RoomDouble * NightCount;
                ResultSuite =  Suite * NightCount;

         }
            if(Month.Equals("October") && NightCount > 7)
            {
                double Studio = 50;
                double RoomDouble = 65;
                double Suite = 75;

                ResultStudio =  Studio * NightCount - Studio;
                ResultRoomDouble =  RoomDouble * NightCount;
                ResultSuite =  Suite * NightCount;
            }

            Console.WriteLine($"Studio: {ResultStudio:F2} lv.");
            Console.WriteLine($"Double: {ResultRoomDouble:F2} lv.");
            Console.WriteLine($"Suite: {ResultSuite:F2} lv.");
        }
    }
}





