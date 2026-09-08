namespace Main
{
    public class PrimeNumberFinder
    {
        public void FindAllPrimeNumbersFromOne()
        {
            List<int> PrimeNumbersList = new List<int>();
            Console.Write("입력 : ");
            string input = Console.ReadLine();

            bool isParsed = int.TryParse(input, out int ParseResult);
            if (!isParsed)
            {
                return;
            }
            // for (int j = 2; j <= ParseResult; j++)
            // {
            //     bool isPrime = true;
            //     for (int a = 2; a<j; a++)
            //     {
            //         if(j % a == 0)
            //         {
            //         isPrime = false;
            //         break;
            //         }
            //     }
            //     if (isPrime)
            //     {
                    
            //         PrimeNumbersList.Add(j);
            //     }
                
            // }
            for (int a = 2; a <=ParseResult; a++)
            { 
                bool isPrime = true;
                for(int i = 2; i*i <= a; i++)
                {
                    if(a % i  == 0)
                    {
                    isPrime = false;
                    break;
                    }
                }
                if (isPrime)
                {
                    PrimeNumbersList.Add(a);
                }
            }
            Console.WriteLine("소수 목록: "); 
            //소수 목록 출력을 위한 포문.
            for(int i = 0; i<PrimeNumbersList.Count; i++)
            {
                Console.Write($"{PrimeNumbersList[i]} ");
            }
        }
    }
}