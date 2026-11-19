using System;
using System.IO;
using Mirror.BouncyCastle.Utilities;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class HssSignature : IEncodable
{
	private readonly int m_lMinus1;

	private readonly LmsSignedPubKey[] m_signedPubKeys;

	private readonly LmsSignature m_signature;

	public int LMinus1 => 0;

	internal LmsSignedPubKey[] SignedPubKeys => null;

	public LmsSignature Signature => null;

	public HssSignature(int lMinus1, LmsSignedPubKey[] signedPubKey, LmsSignature signature)
	{
	}

	public static HssSignature GetInstance(object src, int L)
	{
		return null;
	}

	internal static HssSignature Parse(int L, BinaryReader binaryReader)
	{
		return null;
	}

	private static HssSignature Parse(int L, Stream stream, bool leaveOpen)
	{
		return null;
	}

	[Obsolete("Use 'LMinus1' instead")]
	public int GetLMinus1()
	{
		return 0;
	}

	public LmsSignedPubKey[] GetSignedPubKeys()
	{
		return null;
	}

	public override bool Equals(object other)
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
}
