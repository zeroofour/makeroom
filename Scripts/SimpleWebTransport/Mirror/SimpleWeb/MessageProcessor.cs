using System.Runtime.CompilerServices;

namespace Mirror.SimpleWeb;

public static class MessageProcessor
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static byte FirstLengthByte(byte[] buffer)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool NeedToReadShortLength(byte[] buffer)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool NeedToReadLongLength(byte[] buffer)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int GetOpcode(byte[] buffer)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int GetPayloadLength(byte[] buffer)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Finished(byte[] buffer)
	{
		return false;
	}

	public static void ValidateHeader(byte[] buffer, int maxLength, bool expectMask, bool opCodeContinuation = false)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ToggleMask(byte[] src, int sourceOffset, int messageLength, byte[] maskBuffer, int maskOffset)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ToggleMask(byte[] src, int sourceOffset, ArrayBuffer dst, int messageLength, byte[] maskBuffer, int maskOffset)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void ToggleMask(byte[] src, int srcOffset, byte[] dst, int dstOffset, int messageLength, byte[] maskBuffer, int maskOffset)
	{
	}

	private static int GetMessageLength(byte[] buffer, int offset, byte lenByte)
	{
		return 0;
	}

	private static void ThrowIfMaskNotExpected(bool hasMask, bool expectMask)
	{
	}

	private static void ThrowIfBadOpCode(int opcode, bool finished, bool opCodeContinuation)
	{
	}

	private static void ThrowIfLengthZero(int msglen)
	{
	}

	public static void ThrowIfMsgLengthTooLong(int msglen, int maxLength)
	{
	}
}
