using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Utilities;

namespace Mirror.BouncyCastle.Crypto.Digests;

public sealed class Blake3Digest : IDigest, IMemoable, IXof
{
	private const string ERR_OUTPUTTING = "Already outputting";

	private const int NUMWORDS = 8;

	private const int ROUNDS = 7;

	private const int BLOCKLEN = 64;

	private const int CHUNKLEN = 1024;

	private const int CHUNKSTART = 1;

	private const int CHUNKEND = 2;

	private const int PARENT = 4;

	private const int ROOT = 8;

	private const int KEYEDHASH = 16;

	private const int DERIVECONTEXT = 32;

	private const int DERIVEKEY = 64;

	private const int CHAINING0 = 0;

	private const int CHAINING1 = 1;

	private const int CHAINING2 = 2;

	private const int CHAINING3 = 3;

	private const int CHAINING4 = 4;

	private const int CHAINING5 = 5;

	private const int CHAINING6 = 6;

	private const int CHAINING7 = 7;

	private const int IV0 = 8;

	private const int IV1 = 9;

	private const int IV2 = 10;

	private const int IV3 = 11;

	private const int COUNT0 = 12;

	private const int COUNT1 = 13;

	private const int DATALEN = 14;

	private const int FLAGS = 15;

	private static readonly byte[] SIGMA;

	private static readonly uint[] IV;

	private readonly byte[] m_theBuffer;

	private readonly uint[] m_theK;

	private readonly uint[] m_theChaining;

	private readonly uint[] m_theV;

	private readonly uint[] m_theM;

	private readonly byte[] m_theIndices;

	private readonly List<uint[]> m_theStack;

	private readonly int m_theDigestLen;

	private bool m_outputting;

	private long m_outputAvailable;

	private int m_theMode;

	private int m_theOutputMode;

	private int m_theOutputDataLen;

	private long m_theCounter;

	private int m_theCurrBytes;

	private int m_thePos;

	public string AlgorithmName => null;

	public Blake3Digest()
	{
	}

	public Blake3Digest(int pDigestSize)
	{
	}

	public Blake3Digest(Blake3Digest pSource)
	{
	}

	public int GetByteLength()
	{
		return 0;
	}

	public int GetDigestSize()
	{
		return 0;
	}

	public void Init(Blake3Parameters pParams)
	{
	}

	public void Update(byte b)
	{
	}

	public void BlockUpdate(byte[] pMessage, int pOffset, int pLen)
	{
	}

	public int DoFinal(byte[] pOutput, int pOutOffset)
	{
		return 0;
	}

	public int OutputFinal(byte[] pOut, int pOutOffset, int pOutLen)
	{
		return 0;
	}

	public int Output(byte[] pOut, int pOutOffset, int pOutLen)
	{
		return 0;
	}

	public void Reset()
	{
	}

	public void Reset(IMemoable pSource)
	{
	}

	public IMemoable Copy()
	{
		return null;
	}

	private void CompressBlock(byte[] pMessage, int pMsgPos)
	{
	}

	private void InitM(byte[] pMessage, int pMsgPos)
	{
	}

	private void AdjustStack()
	{
	}

	private void CompressFinalBlock(int pDataLen)
	{
	}

	private void ProcessStack()
	{
	}

	private void Compress()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void PerformRound()
	{
	}

	private void AdjustChaining()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void MixG(int msgIdx, int posA, int posB, int posC, int posD)
	{
	}

	private void InitIndices()
	{
	}

	private void PermuteIndices()
	{
	}

	private void InitNullKey()
	{
	}

	private void InitKey(byte[] pKey)
	{
	}

	private void InitKeyFromContext()
	{
	}

	private void InitChunkBlock(int pDataLen, bool pFinal)
	{
	}

	private void InitParentBlock()
	{
	}

	private void NextOutputBlock()
	{
	}

	private void IncrementBlockCount()
	{
	}

	private void ResetBlockCount()
	{
	}

	private void SetRoot()
	{
	}
}
