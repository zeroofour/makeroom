using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Bcpg;

public class BcpgOutputStream : BaseOutputStream
{
	private Stream outStr;

	private bool useOldFormat;

	private byte[] partialBuffer;

	private int partialBufferLength;

	private int partialPower;

	private int partialOffset;

	private const int BufferSizePower = 16;

	internal static BcpgOutputStream Wrap(Stream outStr)
	{
		return null;
	}

	public BcpgOutputStream(Stream outStr)
	{
	}

	public BcpgOutputStream(Stream outStr, bool newFormatOnly)
	{
	}

	public BcpgOutputStream(Stream outStr, PacketTag tag)
	{
	}

	public BcpgOutputStream(Stream outStr, PacketTag tag, long length, bool oldFormat)
	{
	}

	public BcpgOutputStream(Stream outStr, PacketTag tag, long length)
	{
	}

	public BcpgOutputStream(Stream outStr, PacketTag tag, byte[] buffer)
	{
	}

	private void WriteNewPacketLength(long bodyLen)
	{
	}

	private void WriteHeader(PacketTag packetTag, bool oldPackets, bool partial, long bodyLen)
	{
	}

	private void PartialFlush()
	{
	}

	private void PartialFlushLast()
	{
	}

	private void PartialWrite(byte[] buffer, int offset, int count)
	{
	}

	private void PartialWriteByte(byte value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void WriteByte(byte value)
	{
	}

	internal virtual void WriteShort(short n)
	{
	}

	internal virtual void WriteInt(int n)
	{
	}

	internal virtual void WriteLong(long n)
	{
	}

	public void WritePacket(ContainedPacket p)
	{
	}

	internal void WritePacket(PacketTag tag, byte[] body)
	{
	}

	internal void WritePacket(PacketTag tag, byte[] body, bool oldFormat)
	{
	}

	public void WriteObject(BcpgObject bcpgObject)
	{
	}

	public void WriteObjects(params BcpgObject[] v)
	{
	}

	public override void Flush()
	{
	}

	public void Finish()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
