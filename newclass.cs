public class Blah
{
	public void DoBlah()
	{
		DoSomething();
	}
	
	public string ReturnBlah()
	{
		return "blah";
	}
	
	private void DoSomething()
	{
		Console.Writeline("Doing something now");
	}
}

public class BetterBlah : Blah
{
	public void DoBlah(enum actionType)
	{
		//Take actionType and do something with it	
	}	
}
