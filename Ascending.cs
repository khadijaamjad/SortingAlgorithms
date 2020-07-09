 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of values:");
            int no = Convert.ToInt32(Console.ReadLine());
            int[] digits = new int[no];
            Console.WriteLine("Enter values:");
            for (int n = 0; n < no; n++)
            {
                digits[n] = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    for (int o = 1; o <=n; o++)
                    {
                        if (digits[o] < digits[o - 1])
                        {
                            int temp = digits[o];
                            digits[o] = digits[o- 1];
                            digits[o - 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            for (int n = 0; n < no; n++)
            {  
                Console.WriteLine(digits[n]);
            }
        }
    }
