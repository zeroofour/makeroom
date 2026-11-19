using System.IO;
using Mirror.BouncyCastle.Utilities;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public class LmsSignature : IEncodable
{
	private readonly int m_q;

	private readonly LMOtsSignature m_otsSignature;

	private readonly LMSigParameters m_parameters;

	private readonly byte[][] m_y;

	public LMOtsSignature OtsSignature => null;

	public int Q => 0;

	public LMSigParameters SigParameters => null;

	public byte[][] Y => null;

	public LmsSignature(int q, LMOtsSignature otsSignature, LMSigParameters parameter, byte[][] y)
	{
	}

	public static LmsSignature GetInstance(object src)
	{
		return null;
	}

	internal static LmsSignature Parse(BinaryReader binaryReader)
	{
		return null;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	private static bool DeepEquals(byte[][] a, byte[][] b)
	{
		return false;
	}

	private static int DeepGetHashCode(byte[][] a)
	{
		return 0;
	}
}
