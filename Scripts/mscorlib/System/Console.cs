using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System;

public static class Console
{
	private class WindowsConsole
	{
		private delegate bool WindowsCancelHandler(int keyCode);

		public static bool ctrlHandlerAdded;

		private static WindowsCancelHandler cancelHandler;

		[PreserveSig]
		private static extern int GetConsoleCP();

		[PreserveSig]
		private static extern int GetConsoleOutputCP();

		private static bool DoWindowsConsoleCancelEvent(int keyCode)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetInputCodePage()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetOutputCodePage()
		{
			return 0;
		}
	}

	internal static TextWriter stdout;

	private static TextWriter stderr;

	private static TextReader stdin;

	internal static bool IsRunningOnAndroid;

	private static Encoding inputEncoding;

	private static Encoding outputEncoding;

	private static ConsoleCancelEventHandler cancel_event;

	public static TextWriter Error => null;

	public static Encoding InputEncoding => null;

	public static Encoding OutputEncoding => null;

	public static ConsoleColor ForegroundColor
	{
		set
		{
		}
	}

	static Console()
	{
	}

	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
	{
	}

	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize)
	{
		return null;
	}

	public static Stream OpenStandardError(int bufferSize)
	{
		return null;
	}

	public static Stream OpenStandardInput(int bufferSize)
	{
		return null;
	}

	public static Stream OpenStandardOutput(int bufferSize)
	{
		return null;
	}

	public static void SetOut(TextWriter newOut)
	{
	}

	public static void Write(object value)
	{
	}

	public static void WriteLine(string value)
	{
	}

	public static void WriteLine(string format, object arg0)
	{
	}

	public static ConsoleKeyInfo ReadKey()
	{
		return default;
	}

	public static ConsoleKeyInfo ReadKey(bool intercept)
	{
		return default;
	}

	public static void ResetColor()
	{
	}

	private static void DoConsoleCancelEvent()
	{
	}
}
