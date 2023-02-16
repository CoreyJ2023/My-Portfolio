public class RecursionDemo
{
	public static void main(String[] args)
	{
		// By passing the argument 5 to the message method
		// we are telling it to display the message 5 tmes.
		message(5);
	}

	public static void message(int n)
	{
		if (n > 0)
		{
			System.out.println("This is a recursive method.");
			message(n - 1);
		}
	}
}