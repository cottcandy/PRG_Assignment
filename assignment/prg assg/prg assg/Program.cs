// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using Microsoft.Win32;
using prg_assg;


void DisplayMenu()
{
    while (true)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("-----------Menu------------");
        Console.WriteLine("[1] List all the customers");
        Console.WriteLine("[2] List all current orders");
        Console.WriteLine("[3] Register a new customer");
        Console.WriteLine("[4] Create a customer's order");
        Console.WriteLine("[5] Display order details of a customer");
        Console.WriteLine("[6] Modify order details");
        Console.WriteLine("[7] Process an order and checkout");
        Console.WriteLine("[8] Display monthly amount and total");
        Console.WriteLine("[0] Exit");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Enter your option:");

        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)
        {
            Option1();
        }
        else if (option == 2)
        {
            Option2();
        }
        else if (option == 3)
        {
            Option3();
        }
        else if (option == 4)
        {
            Option4();
        }
        else if (option == 5)
        {
            Option5();
        }
        else if (option == 6)
        {
            Option6();
        }
        else if (option == 7)
        {
            Option7();
        }
        else if (option == 8)
        {
            Option8();
        }
        else if (option == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid option. Please choose a valid option.");
        }
    }
}
DisplayMenu();

void Option1()
{

}

void Option2()
{

}

void Option3()
{

}

void Option4()
{

}

void Option5()
{

}

void Option6()
{

}

void Option7()
{

}

void Option8()
{

}






