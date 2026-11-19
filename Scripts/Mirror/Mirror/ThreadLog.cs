using System.Collections.Concurrent;
using UnityEngine;

namespace Mirror;

public static class ThreadLog
{
	private struct LogEntry(int threadId, LogType type, string message, string stackTrace)
	{
		public int threadId = 0;

		public LogType type = LogType.Error;

		public string message = null;

		public string stackTrace = null;
	}

	private static readonly ConcurrentQueue<LogEntry> logs;

	private static int mainThreadId;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Initialize()
	{
	}

	private static bool IsMainThread()
	{
		return false;
	}

	private static void OnLog(string message, string stackTrace, LogType type)
	{
	}

	private static void OnLateUpdate()
	{
	}
}
