using System;
using System.Diagnostics;
using UnityEngine;

namespace Mirror.SimpleWeb;

public static class Log
{
	public enum Levels
	{
		Flood = 0,
		Verbose = 1,
		Info = 2,
		Warn = 3,
		Error = 4,
		None = 5
	}

	public static ILogger logger;

	public static Levels minLogLevel;

	public static void Exception(Exception e)
	{
	}

	[Conditional("DEBUG")]
	public static void Flood(string msg)
	{
	}

	[Conditional("DEBUG")]
	public static void DumpBuffer(string label, byte[] buffer, int offset, int length)
	{
	}

	[Conditional("DEBUG")]
	public static void DumpBuffer(string label, ArrayBuffer arrayBuffer)
	{
	}

	public static void Verbose(string msg)
	{
	}

	public static void Verbose<T>(string msg, T arg1)
	{
	}

	public static void Verbose<T1, T2>(string msg, T1 arg1, T2 arg2)
	{
	}

	private static void Info(string msg, ConsoleColor consoleColor = ConsoleColor.Cyan)
	{
	}

	public static void Info<T>(string msg, T arg1, ConsoleColor consoleColor = ConsoleColor.Cyan)
	{
	}

	public static void Info<T1, T2>(string msg, T1 arg1, T2 arg2, ConsoleColor consoleColor = ConsoleColor.Cyan)
	{
	}

	public static void InfoException(Exception e)
	{
	}

	public static void Warn(string msg)
	{
	}

	public static void Warn<T>(string msg, T arg1)
	{
	}

	public static void Error(string msg)
	{
	}

	public static void Error<T>(string msg, T arg1)
	{
	}

	public static void Error<T1, T2>(string msg, T1 arg1, T2 arg2)
	{
	}

	public static void Error<T1, T2, T3>(string msg, T1 arg1, T2 arg2, T3 arg3)
	{
	}

	public static string BufferToString(byte[] buffer, int offset = 0, int? length = null)
	{
		return null;
	}
}
