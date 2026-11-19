using System.IO;
using Mirror.BouncyCastle.Math.EC.Rfc8032;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public sealed class Ed25519PrivateKeyParameters : AsymmetricKeyParameter
{
	public static readonly int KeySize;

	public static readonly int SignatureSize;

	private readonly byte[] data;

	private Ed25519PublicKeyParameters cachedPublicKey;

	public Ed25519PrivateKeyParameters(SecureRandom random)
		: base(privateKey: false)
	{
	}

	public Ed25519PrivateKeyParameters(byte[] buf)
		: base(privateKey: false)
	{
	}

	public Ed25519PrivateKeyParameters(byte[] buf, int off)
		: base(privateKey: false)
	{
	}

	public Ed25519PrivateKeyParameters(Stream input)
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

	public Ed25519PublicKeyParameters GeneratePublicKey()
	{
		return null;
	}

	public void Sign(Ed25519.Algorithm algorithm, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
	{
	}

	private static Ed25519PublicKeyParameters CreatePublicKey(byte[] data)
	{
		return null;
	}

	private static byte[] Validate(byte[] buf)
	{
		return null;
	}
}
