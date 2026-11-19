using System.Collections.Concurrent;

namespace Mirror.SimpleWeb;

internal static class ReceiveLoop
{
	public struct Config(Connection conn, int maxMessageSize, bool expectMask, ConcurrentQueue<Message> queue, BufferPool bufferPool)
	{
		public readonly Connection conn = null;

		public readonly int maxMessageSize = 0;

		public readonly bool expectMask = false;

		public readonly ConcurrentQueue<Message> queue = null;

		public readonly BufferPool bufferPool = null;

		public void Deconstruct(out Connection conn, out int maxMessageSize, out bool expectMask, out ConcurrentQueue<Message> queue, out BufferPool bufferPool)
		{
			conn = null;
			maxMessageSize = default;
			expectMask = default;
			queue = null;
			bufferPool = null;
		}
	}

	private struct Header
	{
		public int payloadLength;

		public int offset;

		public int opcode;

		public bool finished;
	}

	public static void Loop(Config config)
	{
	}

	private static void ReadOneMessage(Config config, byte[] buffer)
	{
	}

	private static Header ReadHeader(Config config, byte[] buffer, bool opCodeContinuation = false)
	{
		return default;
	}

	private static void HandleArrayMessage(Config config, byte[] buffer, int msgOffset, int payloadLength)
	{
	}

	private static ArrayBuffer CopyMessageToBuffer(BufferPool bufferPool, bool expectMask, byte[] buffer, int msgOffset, int payloadLength)
	{
		return null;
	}

	private static void HandleCloseMessage(Config config, byte[] buffer, int msgOffset, int payloadLength)
	{
	}

	private static string GetCloseMessage(byte[] buffer, int msgOffset, int payloadLength)
	{
		return null;
	}

	private static int GetCloseCode(byte[] buffer, int msgOffset)
	{
		return 0;
	}
}
