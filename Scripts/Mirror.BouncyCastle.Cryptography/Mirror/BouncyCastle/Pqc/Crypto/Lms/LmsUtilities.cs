using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public static class LmsUtilities
{
	internal class WrapperDigest : IDigest
	{
		private readonly IDigest m_digest;

		private readonly int m_length;

		public string AlgorithmName => null;

		internal WrapperDigest(IDigest digest, int length)
		{
		}

		public void BlockUpdate(byte[] input, int inOff, int inLen)
		{
		}

		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		public int GetByteLength()
		{
			return 0;
		}

		public int GetDigestSize()
		{
			return 0;
		}

		public void Reset()
		{
		}

		public void Update(byte input)
		{
		}
	}

	public static void U32Str(int n, IDigest d)
	{
	}

	public static void U16Str(short n, IDigest d)
	{
	}

	public static void ByteArray(byte[] array, IDigest digest)
	{
	}

	public static void ByteArray(byte[] array, int start, int len, IDigest digest)
	{
	}

	public static int CalculateStrength(LmsParameters lmsParameters)
	{
		return 0;
	}

	internal static IDigest GetDigest(LMOtsParameters otsParameters)
	{
		return null;
	}

	internal static IDigest GetDigest(LMSigParameters sigParameters)
	{
		return null;
	}

	private static IDigest CreateDigest(DerObjectIdentifier oid, int length)
	{
		return null;
	}

	private static IDigest CreateDigest(DerObjectIdentifier oid)
	{
		return null;
	}
}
