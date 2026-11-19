using System.IO;
using Mirror.BouncyCastle.Math.EC.Rfc8032;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public sealed class Ed448PrivateKeyParameters : AsymmetricKeyParameter
{
	public static readonly int KeySize;

	public static readonly int SignatureSize;

	private readonly byte[] data;

	private Ed448PublicKeyParameters cachedPublicKey;

	public Ed448PrivateKeyParameters(SecureRandom random)
		: base(privateKey: false)
	{
	}

	public Ed448PrivateKeyParameters(byte[] buf)
		: base(privateKey: false)
	{
	}

	public Ed448PrivateKeyParameters(byte[] buf, int off)
		: base(privateKey: false)
	{
	}

	public Ed448PrivateKeyParameters(Stream input)
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

	public Ed448PublicKeyParameters GeneratePublicKey()
	{
		return null;
	}

	public void Sign(Ed448.Algorithm algorithm, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
	{
	}

	private static Ed448PublicKeyParameters CreatePublicKey(byte[] data)
	{
		return null;
	}

	private static byte[] Validate(byte[] buf)
	{
		return null;
	}
}
