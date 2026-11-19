using System;
using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpPublicKey : PgpObject
{
	private static readonly PgpKdfParameters DefaultKdfParameters;

	private static readonly int[] MasterKeyCertificationTypes;

	internal PublicKeyPacket publicPk;

	internal TrustPacket trustPk;

	internal IList<PgpSignature> keySigs;

	internal IList<IUserDataPacket> ids;

	internal IList<TrustPacket> idTrusts;

	internal IList<IList<PgpSignature>> idSigs;

	internal IList<PgpSignature> subSigs;

	private long keyId;

	private byte[] fingerprint;

	private int keyStrength;

	public int Version => 0;

	public DateTime CreationTime => default;

	public long KeyId => 0L;

	public bool IsEncryptionKey => false;

	public bool IsMasterKey => false;

	public PublicKeyAlgorithmTag Algorithm => (PublicKeyAlgorithmTag)0;

	public int BitStrength => 0;

	public PublicKeyPacket PublicKeyPacket => null;

	public static byte[] CalculateFingerprint(PublicKeyPacket publicPk)
	{
		return null;
	}

	private static void UpdateDigest(IDigest d, BigInteger b)
	{
	}

	private void Init()
	{
	}

	public PgpPublicKey(PublicKeyAlgorithmTag algorithm, AsymmetricKeyParameter pubKey, DateTime time)
	{
	}

	public PgpPublicKey(PublicKeyPacket publicPk)
	{
	}

	internal PgpPublicKey(PublicKeyPacket publicPk, TrustPacket trustPk, IList<PgpSignature> sigs)
	{
	}

	internal PgpPublicKey(PgpPublicKey key, TrustPacket trust, IList<PgpSignature> subSigs)
	{
	}

	internal PgpPublicKey(PgpPublicKey pubKey)
	{
	}

	internal PgpPublicKey(PublicKeyPacket publicPk, TrustPacket trustPk, IList<PgpSignature> keySigs, IList<IUserDataPacket> ids, IList<TrustPacket> idTrusts, IList<IList<PgpSignature>> idSigs)
	{
	}

	internal PgpPublicKey(PublicKeyPacket publicPk, IList<IUserDataPacket> ids, IList<IList<PgpSignature>> idSigs)
	{
	}

	internal PgpPublicKey(PgpPublicKey original, TrustPacket trustPk, List<PgpSignature> keySigs, List<IUserDataPacket> ids, List<TrustPacket> idTrusts, IList<IList<PgpSignature>> idSigs)
	{
	}

	public byte[] GetTrustData()
	{
		return null;
	}

	public long GetValidSeconds()
	{
		return 0L;
	}

	private long GetExpirationTimeFromSig(bool selfSigned, int signatureType)
	{
		return 0L;
	}

	public byte[] GetFingerprint()
	{
		return null;
	}

	public bool HasFingerprint(byte[] fingerprint)
	{
		return false;
	}

	public AsymmetricKeyParameter GetKey()
	{
		return null;
	}

	private ECPublicKeyParameters GetECKey(string algorithm, ECPublicBcpgKey ecK)
	{
		return null;
	}

	public IEnumerable<string> GetUserIds()
	{
		return null;
	}

	public IEnumerable<byte[]> GetRawUserIds()
	{
		return null;
	}

	public IEnumerable<PgpUserAttributeSubpacketVector> GetUserAttributes()
	{
		return null;
	}

	public IEnumerable<PgpSignature> GetSignaturesForId(string id)
	{
		return null;
	}

	public IEnumerable<PgpSignature> GetSignaturesForId(byte[] rawId)
	{
		return null;
	}

	private IEnumerable<PgpSignature> GetSignaturesForId(UserIdPacket id)
	{
		return null;
	}

	public IEnumerable<PgpSignature> GetSignaturesForKeyID(long keyID)
	{
		return null;
	}

	public IEnumerable<PgpSignature> GetSignaturesForUserAttribute(PgpUserAttributeSubpacketVector userAttributes)
	{
		return null;
	}

	public IEnumerable<PgpSignature> GetSignaturesOfType(int signatureType)
	{
		return null;
	}

	public IEnumerable<PgpSignature> GetSignatures()
	{
		return null;
	}

	public IEnumerable<PgpSignature> GetKeySignatures()
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

	public void Encode(Stream outStr, bool forTransfer)
	{
	}

	public bool IsRevoked()
	{
		return false;
	}

	public static PgpPublicKey AddCertification(PgpPublicKey key, string id, PgpSignature certification)
	{
		return null;
	}

	public static PgpPublicKey AddCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes, PgpSignature certification)
	{
		return null;
	}

	private static PgpPublicKey AddCert(PgpPublicKey key, IUserDataPacket id, PgpSignature certification)
	{
		return null;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes)
	{
		return null;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, string id)
	{
		return null;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, byte[] rawId)
	{
		return null;
	}

	private static PgpPublicKey RemoveCert(PgpPublicKey key, IUserDataPacket id)
	{
		return null;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, byte[] id, PgpSignature certification)
	{
		return null;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, string id, PgpSignature certification)
	{
		return null;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes, PgpSignature certification)
	{
		return null;
	}

	private static PgpPublicKey RemoveCert(PgpPublicKey key, IUserDataPacket id, PgpSignature certification)
	{
		return null;
	}

	public static PgpPublicKey AddCertification(PgpPublicKey key, PgpSignature certification)
	{
		return null;
	}

	public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpSignature certification)
	{
		return null;
	}

	public static PgpPublicKey Join(PgpPublicKey key, PgpPublicKey copy, bool joinTrustPackets, bool allowSubkeySigsOnNonSubkey)
	{
		return null;
	}
}
