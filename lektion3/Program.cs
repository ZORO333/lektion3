
class Program
{
 static void Main()
    {
        Console.WriteLine("Program begin");
 
        int sum = 0;
       
        for (int i = 0; i < 4; i++)
        {
                Console.WriteLine($"i = {i}");
                sum = sum + i;
                Console.WriteLine($"sum = {sum}");
                if(sum == 3){
                        Console.WriteLine("We have now the magical sum of 3");
                }
               
        }
        Console.WriteLine("Program ends");
    }
}
