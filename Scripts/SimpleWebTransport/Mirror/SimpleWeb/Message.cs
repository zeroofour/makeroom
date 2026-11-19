using System;

namespace Mirror.SimpleWeb;

public struct Message
{
	public readonly int connId = 0;

	public readonly EventType type = EventType.Connected;

	public readonly ArrayBuffer data = null;

	public readonly Exception exception = null;

	public Message(EventType type)
	{
	}

	public Message(ArrayBuffer data)
	{
	}

	public Message(Exception exception)
	{
	}

	public Message(int connId, EventType type)
	{
	}

	public Message(int connId, ArrayBuffer data)
	{
	}

	public Message(int connId, Exception exception)
	{
	}
}
