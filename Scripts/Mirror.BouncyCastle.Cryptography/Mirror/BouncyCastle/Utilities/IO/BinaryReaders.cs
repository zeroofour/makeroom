using System;
using System.IO;

namespace Mirror.BouncyCastle.Utilities.IO;

public static class BinaryReaders
{
	internal static T Parse<T>(Func<BinaryReader, T> parse, Stream stream, bool leaveOpen)
	{
		return default;
	}

	public static byte[] ReadBytesFully(BinaryReader binaryReader, int count)
	{
		return null;
	}

	public static short ReadInt16BigEndian(BinaryReader binaryReader)
	{
		return 0;
	}

	public static short ReadInt16LittleEndian(BinaryReader binaryReader)
	{
		return 0;
	}

	public static int ReadInt32BigEndian(BinaryReader binaryReader)
	{
		return 0;
	}

	public static int ReadInt32LittleEndian(BinaryReader binaryReader)
	{
		return 0;
	}

	public static long ReadInt64BigEndian(BinaryReader binaryReader)
	{
		return 0L;
	}

	public static long ReadInt64LittleEndian(BinaryReader binaryReader)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ushort ReadUInt16BigEndian(BinaryReader binaryReader)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static ushort ReadUInt16LittleEndian(BinaryReader binaryReader)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint ReadUInt32BigEndian(BinaryReader binaryReader)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static uint ReadUInt32LittleEndian(BinaryReader binaryReader)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static ulong ReadUInt64BigEndian(BinaryReader binaryReader)
	{
		return 0uL;
	}

	[CLSCompliant(false)]
	public static ulong ReadUInt64LittleEndian(BinaryReader binaryReader)
	{
		return 0uL;
	}
}
