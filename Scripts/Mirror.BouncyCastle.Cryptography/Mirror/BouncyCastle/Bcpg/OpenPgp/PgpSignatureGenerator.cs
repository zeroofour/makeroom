using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpSignatureGenerator
{
	private static readonly SignatureSubpacket[] EmptySignatureSubpackets;

	private readonly PublicKeyAlgorithmTag keyAlgorithm;

	private readonly HashAlgorithmTag hashAlgorithm;

	private PgpPrivateKey privKey;

	private ISigner sig;

	private IDigest dig;

	private int signatureType;

	private byte lastb;

	private SignatureSubpacket[] unhashed;

	private SignatureSubpacket[] hashed;

	public PgpSignatureGenerator(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
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

	public void SetHashedSubpackets(PgpSignatureSubpacketVector hashedPackets)
	{
	}

	public void SetUnhashedSubpackets(PgpSignatureSubpacketVector unhashedPackets)
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

	public PgpSignature GenerateCertification(string id, PgpPublicKey pubKey)
	{
		return null;
	}

	public PgpSignature GenerateCertification(PgpUserAttributeSubpacketVector userAttributes, PgpPublicKey pubKey)
	{
		return null;
	}

	public PgpSignature GenerateCertification(PgpPublicKey masterKey, PgpPublicKey pubKey)
	{
		return null;
	}

	public PgpSignature GenerateCertification(PgpPublicKey pubKey)
	{
		return null;
	}

	private static byte[] GetEncodedPublicKey(PgpPublicKey pubKey)
	{
		return null;
	}

	private static bool IsPacketPresent(SignatureSubpacket[] packets, SignatureSubpacketTag type)
	{
		return false;
	}

	private static SignatureSubpacket[] InsertSubpacket(SignatureSubpacket[] packets, SignatureSubpacket subpacket)
	{
		return null;
	}

	private void UpdateWithIdData(int header, byte[] idBytes)
	{
	}

	private void UpdateWithPublicKey(PgpPublicKey key)
	{
	}
}
