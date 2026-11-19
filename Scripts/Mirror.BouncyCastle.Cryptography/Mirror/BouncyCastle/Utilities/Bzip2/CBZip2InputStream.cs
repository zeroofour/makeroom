using System.IO;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Utilities.Bzip2;

public class CBZip2InputStream : BaseInputStream
{
	private int last;

	private int origPtr;

	private int blockSize100k;

	private int bsBuff;

	private int bsLive;

	private readonly CRC m_blockCrc;

	private int nInUse;

	private byte[] seqToUnseq;

	private byte[] m_selectors;

	private int[] tt;

	private byte[] ll8;

	private int[] unzftab;

	private int[][] limit;

	private int[][] basev;

	private int[][] perm;

	private int[] minLens;

	private Stream bsStream;

	private bool streamEnd;

	private int currentByte;

	private const int RAND_PART_B_STATE = 1;

	private const int RAND_PART_C_STATE = 2;

	private const int NO_RAND_PART_B_STATE = 3;

	private const int NO_RAND_PART_C_STATE = 4;

	private int currentState;

	private int m_expectedBlockCrc;

	private int m_expectedStreamCrc;

	private int m_streamCrc;

	private int i2;

	private int count;

	private int chPrev;

	private int ch2;

	private int i;

	private int tPos;

	private int rNToGo;

	private int rTPos;

	private int j2;

	private int z;

	public CBZip2InputStream(Stream zStream)
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override int ReadByte()
	{
		return 0;
	}

	private void BeginBlock()
	{
	}

	private void EndBlock()
	{
	}

	protected void Detach(bool disposing)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void ImplDisposing(bool disposeInput)
	{
	}

	private int BsGetBit()
	{
		return 0;
	}

	private int BsGetBits(int n)
	{
		return 0;
	}

	private int BsGetBitsSmall(int n)
	{
		return 0;
	}

	private int BsGetInt32()
	{
		return 0;
	}

	private long BsGetLong48()
	{
		return 0L;
	}

	private void HbCreateDecodeTables(int[] limit, int[] basev, int[] perm, byte[] length, int minLen, int maxLen, int alphaSize)
	{
	}

	private int RecvDecodingTables()
	{
		return 0;
	}

	private void GetAndMoveToFrontDecode()
	{
	}

	private int RequireByte()
	{
		return 0;
	}

	private void SetupRandPartA()
	{
	}

	private void SetupNoRandPartA()
	{
	}

	private void SetupRandPartB()
	{
	}

	private void SetupNoRandPartB()
	{
	}

	private void SetupRandPartC()
	{
	}

	private void SetupNoRandPartC()
	{
	}

	internal static int[][] CreateIntArray(int n1, int n2)
	{
		return null;
	}
}
