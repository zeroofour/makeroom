using System.IO;
using Mirror.BouncyCastle.Math.EC.Rfc8032;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public sealed class Ed448PublicKeyParameters : AsymmetricKeyParameter
{
	public static readonly int KeySize;

	private readonly Ed448.PublicPoint m_publicPoint;

	public Ed448PublicKeyParameters(byte[] buf)
		: base(privateKey: false)
	{
	}

	public Ed448PublicKeyParameters(byte[] buf, int off)
		: base(privateKey: false)
	{
	}

	public Ed448PublicKeyParameters(Stream input)
		: base(privateKey: false)
	{
	}

	public Ed448PublicKeyParameters(Ed448.PublicPoint publicPoint)
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

	public bool Verify(Ed448.Algorithm algorithm, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
	{
		return false;
	}

	private static Ed448.PublicPoint Parse(byte[] buf, int off)
	{
		return null;
	}

	private static byte[] Validate(byte[] buf)
	{
		return null;
	}
}
