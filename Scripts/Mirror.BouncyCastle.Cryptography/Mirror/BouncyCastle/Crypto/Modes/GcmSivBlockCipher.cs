using System;
using System.IO;
using Mirror.BouncyCastle.Crypto.Modes.Gcm;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crypto.Modes;

public class GcmSivBlockCipher : IAeadBlockCipher, IAeadCipher
{
	private class GcmSivCache : MemoryStream
	{
		internal GcmSivCache()
		{
		}
	}

	private class GcmSivHasher
	{
		private readonly byte[] theBuffer;

		private readonly byte[] theByte;

		private int numActive;

		private ulong numHashed;

		private readonly GcmSivBlockCipher parent;

		internal GcmSivHasher(GcmSivBlockCipher parent)
		{
		}

		internal ulong getBytesProcessed()
		{
			return 0uL;
		}

		internal void Reset()
		{
		}

		internal void UpdateHash(byte pByte)
		{
		}

		internal void UpdateHash(byte[] pBuffer, int pOffset, int pLen)
		{
		}

		internal void completeHash()
		{
		}
	}

	private static readonly int BUFLEN;

	private static readonly int HALFBUFLEN;

	private static readonly int NONCELEN;

	private static readonly int MAX_DATALEN;

	private static readonly byte MASK;

	private static readonly byte ADD;

	private static readonly int INIT;

	private static readonly int AEAD_COMPLETE;

	private readonly IBlockCipher theCipher;

	private readonly IGcmMultiplier theMultiplier;

	internal readonly byte[] theGHash;

	internal readonly byte[] theReverse;

	private readonly GcmSivHasher theAEADHasher;

	private readonly GcmSivHasher theDataHasher;

	private GcmSivCache thePlain;

	private GcmSivCache theEncData;

	private bool forEncryption;

	private byte[] theInitialAEAD;

	private byte[] theNonce;

	private int theFlags;

	public virtual IBlockCipher UnderlyingCipher => null;

	public virtual string AlgorithmName => null;

	public GcmSivBlockCipher()
	{
	}

	public GcmSivBlockCipher(IBlockCipher pCipher)
	{
	}

	[Obsolete("Will be removed")]
	public GcmSivBlockCipher(IBlockCipher pCipher, IGcmMultiplier pMultiplier)
	{
	}

	public virtual int GetBlockSize()
	{
		return 0;
	}

	public virtual void Init(bool pEncrypt, ICipherParameters cipherParameters)
	{
	}

	private void CheckAeadStatus(int pLen)
	{
	}

	private void CheckStatus(int pLen)
	{
	}

	public virtual void ProcessAadByte(byte pByte)
	{
	}

	public virtual void ProcessAadBytes(byte[] pData, int pOffset, int pLen)
	{
	}

	public virtual int ProcessByte(byte pByte, byte[] pOutput, int pOutOffset)
	{
		return 0;
	}

	public virtual int ProcessBytes(byte[] pData, int pOffset, int pLen, byte[] pOutput, int pOutOffset)
	{
		return 0;
	}

	public virtual int DoFinal(byte[] pOutput, int pOffset)
	{
		return 0;
	}

	public virtual byte[] GetMac()
	{
		return null;
	}

	public virtual int GetUpdateOutputSize(int pLen)
	{
		return 0;
	}

	public virtual int GetOutputSize(int pLen)
	{
		return 0;
	}

	public virtual void Reset()
	{
	}

	private void ResetStreams()
	{
	}

	private static int bufLength(byte[] pBuffer)
	{
		return 0;
	}

	private int EncryptPlain(byte[] pCounter, byte[] pTarget, int pOffset)
	{
		return 0;
	}

	private void DecryptPlain()
	{
	}

	private byte[] CalculateTag()
	{
		return null;
	}

	private byte[] completePolyVal()
	{
		return null;
	}

	private void gHashLengths()
	{
	}

	private void gHASH(byte[] pNext)
	{
	}

	private static void fillReverse(byte[] pInput, int pOffset, int pLength, byte[] pOutput)
	{
	}

	private static void xorBlock(byte[] pLeft, byte[] pRight)
	{
	}

	private static void xorBlock(byte[] pLeft, byte[] pRight, int pOffset, int pLength)
	{
	}

	private static void incrementCounter(byte[] pCounter)
	{
	}

	private static void mulX(byte[] pValue)
	{
	}

	private void DeriveKeys(KeyParameter pKey)
	{
	}
}
