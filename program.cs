using System;

public class HelloWorld
{
    public static void Main(string[] args) {
	Console.Write("Hello World!");
    }
    
    private static string GetName()
    {
    	return "tchang82";
    }
    
    private static int GetRandom()
    {
        return new Random().Next();
    }
}
