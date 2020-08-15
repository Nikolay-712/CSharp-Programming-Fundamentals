using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int time = minutes + 30;
            int minut = 0;

            if (time > 59)
            {
                hours = hours + 1;
                minut = time - 60;

            }
            if (hours > 23)
            {
                hours = 0;
            }
            else if (time < 59)
            {
                minut = time;
            }


            Console.WriteLine($"{hours}:{minut:D2}");
        }

    }

}       