using System;
using Mirror.BouncyCastle.Utilities;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public class LmsSignedPubKey : IEncodable
{
	private readonly LmsSignature m_signature;

	private readonly LmsPublicKeyParameters m_publicKey;

	public LmsPublicKeyParameters PublicKey => null;

	public LmsSignature Signature => null;

	public LmsSignedPubKey(LmsSignature signature, LmsPublicKeyParameters publicKey)
	{
	}

	[Obsolete("Use 'PublicKey' instead")]
	public LmsPublicKeyParameters GetPublicKey()
	{
		return null;
	}

	[Obsolete("Use 'Signature' instead")]
	public LmsSignature GetSignature()
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
}
