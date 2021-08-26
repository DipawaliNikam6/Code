using System;
class Program
{
    static void Main(string[] args)
    {
        // Step 1: test for null.
        if (args == null)
        {
            Console.WriteLine("args is null");
        }
        else
        {
            
            FileDetails.GetVersion(-v,"abc.txt");
            FileDetails.GetSize(-s,"abc.txt");
            
        }
        Console.ReadLine();
    }
}
