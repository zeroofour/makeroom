namespace System;

internal class NullConsoleDriver : IConsoleDriver
{
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo;

	public ConsoleColor ForegroundColor
	{
		set
		{
		}
	}

	public ConsoleKeyInfo ReadKey(bool intercept)
	{
		return default;
	}

	public void ResetColor()
	{
	}
}
