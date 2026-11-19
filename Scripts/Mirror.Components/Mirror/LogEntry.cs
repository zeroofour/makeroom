using UnityEngine;

namespace Mirror;

internal struct LogEntry(string message, LogType type)
{
	public string message = null;

	public LogType type = LogType.Error;
}
