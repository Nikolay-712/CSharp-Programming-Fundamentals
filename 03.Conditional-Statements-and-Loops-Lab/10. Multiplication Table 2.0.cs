using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                int result = theInteger * times;

                Console.WriteLine($"{theInteger} X {times} = {result}");
            }

            for (int i = times; i <= 10; i++)
            {
                int product = theInteger * i;

                Console.WriteLine($"{theInteger} X {i} = {product}");


            }


        }

    }


}


