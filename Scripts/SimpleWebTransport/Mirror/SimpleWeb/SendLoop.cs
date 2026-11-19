namespace Mirror.SimpleWeb;

internal static class SendLoop
{
	public struct Config(Connection conn, int bufferSize, bool setMask)
	{
		public readonly Connection conn = null;

		public readonly int bufferSize = 0;

		public readonly bool setMask = false;

		public void Deconstruct(out Connection conn, out int bufferSize, out bool setMask)
		{
			conn = null;
			bufferSize = default;
			setMask = default;
		}
	}

	public static void Loop(Config config)
	{
	}

	private static int SendMessage(byte[] buffer, int startOffset, ArrayBuffer msg, bool setMask, MaskHelper maskHelper)
	{
		return 0;
	}

	public static int WriteHeader(byte[] buffer, int startOffset, int msgLength, bool setMask)
	{
		return 0;
	}
}
