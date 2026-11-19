using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpSecretKeyRing : PgpKeyRing
{
	private readonly IList<PgpSecretKey> keys;

	private readonly IList<PgpPublicKey> extraPubKeys;

	internal PgpSecretKeyRing(IList<PgpSecretKey> keys)
	{
	}

	private PgpSecretKeyRing(IList<PgpSecretKey> keys, IList<PgpPublicKey> extraPubKeys)
	{
	}

	public PgpSecretKeyRing(byte[] encoding)
	{
	}

	public PgpSecretKeyRing(Stream inputStream)
	{
	}

	public PgpPublicKey GetPublicKey()
	{
		return null;
	}

	public PgpPublicKey GetPublicKey(long keyID)
	{
		return null;
	}

	public PgpPublicKey GetPublicKey(byte[] fingerprint)
	{
		return null;
	}

	public IEnumerable<PgpPublicKey> GetKeysWithSignaturesBy(long keyID)
	{
		return null;
	}

	public IEnumerable<PgpPublicKey> GetPublicKeys()
	{
		return null;
	}

	public PgpSecretKey GetSecretKey()
	{
		return null;
	}

	public IEnumerable<PgpSecretKey> GetSecretKeys()
	{
		return null;
	}

	public PgpSecretKey GetSecretKey(long keyId)
	{
		return null;
	}

	public PgpSecretKey GetSecretKey(byte[] fingerprint)
	{
		return null;
	}

	public IEnumerable<PgpPublicKey> GetExtraPublicKeys()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public void Encode(Stream outStr)
	{
	}

	public static PgpSecretKeyRing ReplacePublicKeys(PgpSecretKeyRing secretRing, PgpPublicKeyRing publicRing)
	{
		return null;
	}

	public static PgpSecretKeyRing CopyWithNewPassword(PgpSecretKeyRing ring, char[] oldPassPhrase, char[] newPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
	{
		return null;
	}

	public static PgpSecretKeyRing InsertSecretKey(PgpSecretKeyRing secRing, PgpSecretKey secKey)
	{
		return null;
	}

	public static PgpSecretKeyRing RemoveSecretKey(PgpSecretKeyRing secRing, PgpSecretKey secKey)
	{
		return null;
	}
}
