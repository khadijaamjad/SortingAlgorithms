 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit of array:");
            int lim = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[lim];
            Console.WriteLine("Enter the values:");
            for (int s = 0; s < lim; s++)
            {
                Console.WriteLine("Value at " + s);
                a[s] = Console.ReadLine();
            }
            int n;
            string temp;
            for (int o = 0; o < a.Length - 1; o++)
            {
                n = o;
                for (int i = o + 1; i < a.Length; i++)
                {
                   int v= a[i].CompareTo(a[n]);
                    if (v==1) //change to 1 for ascending order
                    {
                        n = i;
                    }
                    temp = a[i];
                    a[i] = a[n];
                    a[n] = temp;
                }
            }
            for (int s = lim-1; s >=0; s--) //set the array in normal seq for ascending ordr
            {
                Console.WriteLine(a[s]);
               
            }
        }
    }
