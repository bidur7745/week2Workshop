namespace ConsoleApp1
{
    internal class ParameterDemo
    {
        // 1. Increase using ref
        public void Increase(ref int number)
        {
            number += 10;
        }

        // 2. Assign full name using out
        public void GetFullName(out string fullname)
        {
            fullname = "Bidur Siwakoti";  
        }

        // 3. SumAll using params
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}
