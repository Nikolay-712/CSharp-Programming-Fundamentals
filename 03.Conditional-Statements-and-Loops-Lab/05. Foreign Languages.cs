﻿using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            if (country.Equals("USA") || country.Equals("England"))
            {
                Console.WriteLine("English ");
            }
            else if (country.Equals("Spain") || country.Equals("Argentina") || country.Equals("Mexico"))
            {
                Console.WriteLine("Spanish ");
            }
            else
            {
                Console.WriteLine("unknown");
            }




        }
    }


}


