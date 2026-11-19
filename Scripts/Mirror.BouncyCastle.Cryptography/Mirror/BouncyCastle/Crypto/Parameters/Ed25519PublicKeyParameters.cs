using System.IO;
using Mirror.BouncyCastle.Math.EC.Rfc8032;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public sealed class Ed25519PublicKeyParameters : AsymmetricKeyParameter
{
	public static readonly int KeySize;

	private readonly Ed25519.PublicPoint m_publicPoint;

	public Ed25519PublicKeyParameters(byte[] buf)
		: base(privateKey: false)
	{
	}

	public Ed25519PublicKeyParameters(byte[] buf, int off)
		: base(privateKey: false)
	{
	}

	public Ed25519PublicKeyParameters(Stream input)
		: base(privateKey: false)
	{
	}

	public Ed25519PublicKeyParameters(Ed25519.PublicPoint publicPoint)
		: base(privateKey: false)
	{
	}

	public void Encode(byte[] buf, int off)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public bool Verify(Ed25519.Algorithm algorithm, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
	{
		return false;
	}

	private static Ed25519.PublicPoint Parse(byte[] buf, int off)
	{
		return null;
	}

	private static byte[] Validate(byte[] buf)
	{
		return null;
	}
}
