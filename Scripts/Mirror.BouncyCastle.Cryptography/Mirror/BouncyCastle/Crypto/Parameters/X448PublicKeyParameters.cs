using System.IO;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public sealed class X448PublicKeyParameters : AsymmetricKeyParameter
{
	public static readonly int KeySize;

	private readonly byte[] data;

	public X448PublicKeyParameters(byte[] buf)
		: base(privateKey: false)
	{
	}

	public X448PublicKeyParameters(byte[] buf, int off)
		: base(privateKey: false)
	{
	}

	public X448PublicKeyParameters(Stream input)
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

	private static byte[] Validate(byte[] buf)
	{
		return null;
	}
}
