 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit of array:");
            int lim = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[lim];
            Console.WriteLine("Enter the values:");
            for (int s = 0; s < lim; s++)
            {
                Console.WriteLine("Value at " + s);
                a[s] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Which sorting would you like to use?\n B. BUBBLE\n I. INSERTION \n S. SELECTION");
            char sor = Convert.ToChar(Console.ReadLine());
            switch (sor)
            {
                case 'B':
                case'b':
                    Console.WriteLine("BUBBLE SORTING");
                    bubble(a, lim);
                    print(a, lim);
                    break;
                case'I':
                case'i':
                    Console.WriteLine("INSERTION SORTING");
                    insertion(a, lim);
                    print(a, lim);
                    break;
                case 'S':
                case's':
                    Console.WriteLine("SELECTION SORTING");
                    selection(a, lim);
                    print(a, lim);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
        static void bubble(int[] arr, int lim)
        {
            int l = arr.Length;
            int n,temp;
            for (int o = l; o >= 0; o--)
            {
                for (int i = 0; i < l - 1; i++)
                {
                    n = i + 1;
                    if (arr[i] > arr[n])
                    {
                        temp = arr[i];
                        arr[i] = arr[n];
                        arr[n] = temp;
                    }
                }
            }
        }
        static void insertion(int[] arr, int lim)
        {
            int l = arr.Length;
            int temp,n;
            for (int o = 0; o < l; o++)
            {
                for (int i = o; i > 0; i--)
                {
                    n=i-1;
                    if (arr[i] < arr[n])
                    {
                        temp = arr[i];
                        arr[i] = arr[n];
                        arr[n] = temp;
                    }
                }
            }
        }
        static void selection(int[] arr, int lim)
        {
            int l = arr.Length;
            int temp, n;
            for (int o = 0; o < l - 1; o++)
            {
                n = o;
                for (int i = o + 1; i < l; i++)
                {
                    if (arr[i] > arr[n])
                    {
                        n = i;
                    }
                    temp = arr[i];
                    arr[i] = arr[n];
                    arr[n] = temp;
                }
            }

        }
        static void print(int[] arr, int lim)
        {
            for (int s = 0; s < lim; s++)
            {
                Console.WriteLine(arr[s]);
            }
        }
    }
