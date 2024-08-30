class Program
{      
 
 static void loop(int nr){
        int sum = 0;
        for (int i = 0; i < nr; i++)
        {
                Console.WriteLine($"i = {i}");
                sum = sum + i;
                Console.WriteLine($"sum = {sum}");
                if(sum == 3){
                        Console.WriteLine("We have now the magical sum of 3");
                }
               
        }
 }
 static void Main()
    {
        Console.WriteLine("Program begin");
        loop(11);
        Console.WriteLine("Program ends");
    }
}




