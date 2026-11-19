using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class ByteQueue
{
	private byte[] m_databuf;

	private int m_skipped;

	private int m_available;

	private bool m_readOnlyBuf;

	public int Available => 0;

	private static int GetAllocationSize(int i)
	{
		return 0;
	}

	public ByteQueue()
	{
	}

	public ByteQueue(int capacity)
	{
	}

	public ByteQueue(byte[] buf, int off, int len)
	{
	}

	public void AddData(byte[] buf, int off, int len)
	{
	}

	public void CopyTo(Stream output, int length)
	{
	}

	public void Read(byte[] buf, int offset, int len, int skip)
	{
	}

	internal HandshakeMessageInput ReadHandshakeMessage(int length)
	{
		return null;
	}

	public int ReadInt32()
	{
		return 0;
	}

	public short ReadUint8(int skip)
	{
		return 0;
	}

	public int ReadUint16(int skip)
	{
		return 0;
	}

	public void RemoveData(int i)
	{
	}

	public void RemoveData(byte[] buf, int off, int len, int skip)
	{
	}

	public byte[] RemoveData(int len, int skip)
	{
		return null;
	}

	public void Shrink()
	{
	}
}
