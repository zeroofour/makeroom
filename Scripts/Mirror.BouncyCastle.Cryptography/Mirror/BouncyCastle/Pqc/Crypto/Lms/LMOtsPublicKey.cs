using System;
using System.IO;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LMOtsPublicKey
{
	private readonly LMOtsParameters m_parameters;

	private readonly byte[] m_I;

	private readonly int m_q;

	private readonly byte[] m_K;

	public LMOtsParameters Parameters => null;

	public int Q => 0;

	[Obsolete("Use 'GetI' instead")]
	public byte[] I => null;

	[Obsolete("Use 'GetK' instead")]
	public byte[] K => null;

	public LMOtsPublicKey(LMOtsParameters parameters, byte[] i, int q, byte[] k)
	{
	}

	public static LMOtsPublicKey GetInstance(object src)
	{
		return null;
	}

	internal static LMOtsPublicKey Parse(BinaryReader binaryReader)
	{
		return null;
	}

	public byte[] GetI()
	{
		return null;
	}

	public byte[] GetK()
	{
		return null;
	}

	public override bool Equals(object obj)
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

	internal LmsContext CreateOtsContext(LMOtsSignature signature)
	{
		return null;
	}

	internal LmsContext CreateOtsContext(LmsSignature signature)
	{
		return null;
	}
}
