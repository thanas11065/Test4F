using System;
class Program
{
    static void Main(string[] args)
    {
            int i, sum, c = 1;
        string A, B, C, D,F,G,X,P;
        A = "External damage(17000)";
        B = "Car body(5200)";
        C = "Hood(2900)";
        D = "Front bumper(2300)";
        F = "Windshield(10000)";
        G = "Wheels(1800)";
        X = "Front left tire(900)";
        P = "Back left tire(900)";
            string TYPE;
            Console.Write("Pleaes input your select : ");
            TYPE = Console.ReadLine();
            switch (TYPE)
            {
                case "External damage":
                    Console.WriteLine("Your select : {0}", A);
                    break;
                case "Car body":
                    Console.WriteLine("Your select : {0}", B);
                    break;
                case "Hood":
                    Console.WriteLine("Your select : {0}", C);
                    break;
                case "Front bumper":
                    Console.WriteLine("Your select : {0}", D);
                    break;
                case "Windshield":
                    Console.WriteLine("Your select : {0}", F);
                    break;
                case "Wheels":
                    Console.WriteLine("Your select : {0}", G);
                    break;
                case "Front left tire":
                    Console.WriteLine("Your select : {0}", X);
                    break;
                case "Back left tire":
                    Console.WriteLine("Your select : {0}", P);
                    break;
                default:
                    Console.WriteLine("NOT FOUND INFORMATION");
                    break;
            }
     Check();
    }
    
    static bool Check()
    {
        Console.WriteLine("True/False");
        string s = Console.ReadLine(); 
        if (s == "True"|| s == "true")
        {
            return true;
        }
        else if (s == "False"|| s == "false")
        {
            return false;
        }
        else
                {
                    Console.WriteLine("Please Enter only True or False :"); 
                    return Check();            
                }
    }

    } 