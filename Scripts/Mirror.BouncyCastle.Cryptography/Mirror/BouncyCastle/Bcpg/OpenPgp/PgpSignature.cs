using System;
using System.IO;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpSignature
{
	public const int BinaryDocument = 0;

	public const int CanonicalTextDocument = 1;

	public const int StandAlone = 2;

	public const int DefaultCertification = 16;

	public const int NoCertification = 17;

	public const int CasualCertification = 18;

	public const int PositiveCertification = 19;

	public const int SubkeyBinding = 24;

	public const int PrimaryKeyBinding = 25;

	public const int DirectKey = 31;

	public const int KeyRevocation = 32;

	public const int SubkeyRevocation = 40;

	public const int CertificationRevocation = 48;

	public const int Timestamp = 64;

	public const int ThirdPartyConfirmation = 80;

	private readonly SignaturePacket sigPck;

	private readonly int signatureType;

	private readonly TrustPacket trustPck;

	private ISigner sig;

	private byte lastb;

	public int Version => 0;

	public PublicKeyAlgorithmTag KeyAlgorithm => (PublicKeyAlgorithmTag)0;

	public HashAlgorithmTag HashAlgorithm => (HashAlgorithmTag)0;

	public int SignatureType => 0;

	public long KeyId => 0L;

	public DateTime CreationTime => default;

	public bool HasSubpackets => false;

	private static SignaturePacket Cast(Packet packet)
	{
		return null;
	}

	internal PgpSignature(BcpgInputStream bcpgInput)
	{
	}

	internal PgpSignature(SignaturePacket sigPacket)
	{
	}

	internal PgpSignature(SignaturePacket sigPacket, TrustPacket trustPacket)
	{
	}

	public byte[] GetDigestPrefix()
	{
		return null;
	}

	public bool IsCertification()
	{
		return false;
	}

	public void InitVerify(PgpPublicKey pubKey)
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

	public void Update(params byte[] bytes)
	{
	}

	public void Update(byte[] bytes, int off, int length)
	{
	}

	public bool Verify()
	{
		return false;
	}

	private void UpdateWithIdData(int header, byte[] idBytes)
	{
	}

	private void UpdateWithPublicKey(PgpPublicKey key)
	{
	}

	public bool VerifyCertification(PgpUserAttributeSubpacketVector userAttributes, PgpPublicKey key)
	{
		return false;
	}

	public bool VerifyCertification(string id, PgpPublicKey key)
	{
		return false;
	}

	public bool VerifyCertification(PgpPublicKey masterKey, PgpPublicKey pubKey)
	{
		return false;
	}

	public bool VerifyCertification(PgpPublicKey pubKey)
	{
		return false;
	}

	public byte[] GetSignatureTrailer()
	{
		return null;
	}

	public PgpSignatureSubpacketVector GetHashedSubPackets()
	{
		return null;
	}

	public PgpSignatureSubpacketVector GetUnhashedSubPackets()
	{
		return null;
	}

	private static PgpSignatureSubpacketVector CreateSubpacketVector(SignatureSubpacket[] pcks)
	{
		return null;
	}

	public byte[] GetSignature()
	{
		return null;
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public void Encode(Stream outStream)
	{
	}

	public void Encode(Stream outStream, bool forTransfer)
	{
	}

	private static byte[] GetEncodedPublicKey(PgpPublicKey pubKey)
	{
		return null;
	}

	public static bool IsCertification(int signatureType)
	{
		return false;
	}

	public static bool IsSignatureEncodingEqual(PgpSignature sig1, PgpSignature sig2)
	{
		return false;
	}

	public static PgpSignature Join(PgpSignature sig1, PgpSignature sig2)
	{
		return null;
	}
}
