 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int items = Convert.ToInt32(Console.ReadLine());
            string[,] tab = new string[items, 2];
            Console.WriteLine("Enter price then item name:");
            for (int m = 0; m < items; m++)
            {
                for (int n = 0; n < 2; n++)
                {
                    string val = Console.ReadLine();
                    tab[m, n] = val;
                }
            }
            for (int m = 0; m < items; m++)
            {
                for (int n = 1; n < items; n++)
                {
                    int a = tab[n - 1, 0].CompareTo(tab[n, 0]);
                    if (a == 1)
                    {
                        string temp = tab[n - 1, 0];
                        string temp1 = tab[n - 1, 1];
                        tab[n - 1, 0] = tab[n, 0];
                        tab[n - 1, 1] = tab[n, 1];
                        tab[n, 0] = temp;
                        tab[n, 1] = temp1;
                    }
            }
        }
            Console.WriteLine("SORTED LIST:");
                    for (int x = 0; x < items; x++)
                    {
                        for (int y = 0; y < 2; y++)
                        {
                            Console.Write(tab[x, y] + "\t");
                        }
                        Console.WriteLine();
                    }
                    
            Console.WriteLine("Do you want to search for something? Y/N");
                char se = Convert.ToChar(Console.ReadLine());
                while (se=='y'|| se=='Y')
    {
        Console.WriteLine("Enter name of the item:");
        string it = Console.ReadLine();
        for (int c = 0; c < items; c++)
        {
            if (tab[c, 1] == it)
            {
                Console.WriteLine("RESULT");
                Console.WriteLine("Price: " + tab[c, 0]+" \t Name:"+tab[c,1]);
            }
         Console.WriteLine("Do you want to search for something? Y/N");
         se= Convert.ToChar(Console.ReadLine());
         if (se == 'n' || se == 'N')
             break;
        }
    }
           }
        
    }
