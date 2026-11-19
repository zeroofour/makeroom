using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpV3SignatureGenerator
{
	private readonly PublicKeyAlgorithmTag keyAlgorithm;

	private readonly HashAlgorithmTag hashAlgorithm;

	private PgpPrivateKey privKey;

	private ISigner sig;

	private IDigest dig;

	private int signatureType;

	private byte lastb;

	public PgpV3SignatureGenerator(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
	{
	}

	public void InitSign(int sigType, PgpPrivateKey privKey)
	{
	}

	public void InitSign(int sigType, PgpPrivateKey privKey, SecureRandom random)
	{
	}

	public void Update(byte b)
	{
	}

	private void DoCanonicalUpdateByte(byte b)
	{
	}

	private void DoUpdateCRLF()
	{
	}

	private void DoUpdateByte(byte b)
	{
	}

	public void Update(params byte[] b)
	{
	}

	public void Update(byte[] b, int off, int len)
	{
	}

	public PgpOnePassSignature GenerateOnePassVersion(bool isNested)
	{
		return null;
	}

	public PgpSignature Generate()
	{
		return null;
	}
}
