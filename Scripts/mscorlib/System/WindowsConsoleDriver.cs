using System.Runtime.InteropServices;

namespace System;

internal class WindowsConsoleDriver : IConsoleDriver
{
	private IntPtr inputHandle;

	private IntPtr outputHandle;

	private short defaultAttribute;

	public ConsoleColor ForegroundColor
	{
		set
		{
		}
	}

	private static short GetAttrForeground(int attr, ConsoleColor color)
	{
		return 0;
	}

	public ConsoleKeyInfo ReadKey(bool intercept)
	{
		return default;
	}

	public void ResetColor()
	{
	}

	private static bool IsModifierKey(short virtualKeyCode)
	{
		return false;
	}

	[PreserveSig]
	private static extern IntPtr GetStdHandle(Handles handle);

	[PreserveSig]
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info);

	[PreserveSig]
	private static extern bool SetConsoleTextAttribute(IntPtr handle, short attribute);

	[PreserveSig]
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread);
}
