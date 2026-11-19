using System.Collections.Generic;
using System.IO;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpPublicKeyRing : PgpKeyRing
{
	private readonly IList<PgpPublicKey> keys;

	public PgpPublicKeyRing(byte[] encoding)
	{
	}

	internal PgpPublicKeyRing(IList<PgpPublicKey> pubKeys)
	{
	}

	public PgpPublicKeyRing(Stream inputStream)
	{
	}

	public virtual PgpPublicKey GetPublicKey()
	{
		return null;
	}

	public virtual PgpPublicKey GetPublicKey(long keyId)
	{
		return null;
	}

	public virtual PgpPublicKey GetPublicKey(byte[] fingerprint)
	{
		return null;
	}

	public virtual IEnumerable<PgpPublicKey> GetPublicKeys()
	{
		return null;
	}

	public virtual byte[] GetEncoded()
	{
		return null;
	}

	public virtual void Encode(Stream outStr)
	{
	}

	public static PgpPublicKeyRing InsertPublicKey(PgpPublicKeyRing pubRing, PgpPublicKey pubKey)
	{
		return null;
	}

	public static PgpPublicKeyRing RemovePublicKey(PgpPublicKeyRing pubRing, PgpPublicKey pubKey)
	{
		return null;
	}

	internal static PublicKeyPacket ReadPublicKeyPacket(BcpgInputStream bcpgInput)
	{
		return null;
	}

	internal static PgpPublicKey ReadSubkey(BcpgInputStream bcpgInput)
	{
		return null;
	}

	public static PgpPublicKeyRing Join(PgpPublicKeyRing first, PgpPublicKeyRing second)
	{
		return null;
	}

	public static PgpPublicKeyRing Join(PgpPublicKeyRing first, PgpPublicKeyRing second, bool joinTrustPackets, bool allowSubkeySigsOnNonSubkey)
	{
		return null;
	}
}
