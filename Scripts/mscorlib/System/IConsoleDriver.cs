namespace System;

internal interface IConsoleDriver
{
	ConsoleColor ForegroundColor { set; }

	ConsoleKeyInfo ReadKey(bool intercept);

	void ResetColor();
}
