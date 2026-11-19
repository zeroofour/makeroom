using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Utilities.Bzip2;

public class CBZip2OutputStream : BaseOutputStream
{
	internal class StackElem
	{
		internal int ll;

		internal int hh;

		internal int dd;
	}

	protected const int SETMASK = 2097152;

	protected const int CLEARMASK = -2097153;

	protected const int GREATER_ICOST = 15;

	protected const int LESSER_ICOST = 0;

	protected const int SMALL_THRESH = 20;

	protected const int DEPTH_THRESH = 10;

	internal static readonly ushort[] RNums;

	private static readonly int[] Incs;

	private bool finished;

	private int count;

	private int origPtr;

	private readonly int blockSize100k;

	private readonly int allowableBlockSize;

	private bool blockRandomised;

	private readonly IList<StackElem> blocksortStack;

	private int bsBuff;

	private int bsLivePos;

	private readonly CRC m_blockCrc;

	private bool[] inUse;

	private int nInUse;

	private byte[] m_selectors;

	private byte[] blockBytes;

	private ushort[] quadrantShorts;

	private int[] zptr;

	private int[] szptr;

	private int[] ftab;

	private int nMTF;

	private int[] mtfFreq;

	private int workFactor;

	private int workDone;

	private int workLimit;

	private bool firstAttempt;

	private int currentByte;

	private int runLength;

	private int m_streamCrc;

	private bool closed;

	private Stream bsStream;

	protected static void HbMakeCodeLengths(byte[] len, int[] freq, int alphaSize, int maxLen)
	{
	}

	public CBZip2OutputStream(Stream outStream)
	{
	}

	public CBZip2OutputStream(Stream outStream, int blockSize)
	{
	}

	public override void WriteByte(byte value)
	{
	}

	private void WriteRun()
	{
	}

	protected void Detach(bool disposing)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void ImplDisposing(bool disposeOutput)
	{
	}

	public void Finish()
	{
	}

	public override void Flush()
	{
	}

	private void InitBlock()
	{
	}

	private void EndBlock()
	{
	}

	private void EndCompression()
	{
	}

	private void HbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
	{
	}

	private void BsFinishedWithStream()
	{
	}

	private void BsPutBit(int v)
	{
	}

	private void BsPutBits(int n, int v)
	{
	}

	private void BsPutBitsSmall(int n, int v)
	{
	}

	private void BsPutInt32(int u)
	{
	}

	private void BsPutLong48(long u)
	{
	}

	private void SendMtfValues()
	{
	}

	private void MoveToFrontCodeAndSend()
	{
	}

	private void SimpleSort(int lo, int hi, int d)
	{
	}

	private void Vswap(int p1, int p2, int n)
	{
	}

	private int Med3(int a, int b, int c)
	{
		return 0;
	}

	private static void PushStackElem(IList<StackElem> stack, int stackCount, int ll, int hh, int dd)
	{
	}

	private void QSort3(int loSt, int hiSt, int dSt)
	{
	}

	private void MainSort()
	{
	}

	private void RandomiseBlock()
	{
	}

	private void DoReversibleTransformation()
	{
	}

	private bool FullGtU(int i1, int i2)
	{
		return false;
	}

	private void GenerateMtfValues()
	{
	}

	internal static byte[][] CreateByteArray(int n1, int n2)
	{
		return null;
	}
}
