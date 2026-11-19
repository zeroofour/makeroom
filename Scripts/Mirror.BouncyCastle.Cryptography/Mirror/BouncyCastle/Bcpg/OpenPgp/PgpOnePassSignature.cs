using System.IO;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpOnePassSignature
{
	private readonly OnePassSignaturePacket sigPack;

	private readonly int signatureType;

	private ISigner sig;

	private byte lastb;

	public long KeyId => 0L;

	public int SignatureType => 0;

	public HashAlgorithmTag HashAlgorithm => (HashAlgorithmTag)0;

	public PublicKeyAlgorithmTag KeyAlgorithm => (PublicKeyAlgorithmTag)0;

	private static OnePassSignaturePacket Cast(Packet packet)
	{
		return null;
	}

	internal PgpOnePassSignature(BcpgInputStream bcpgInput)
	{
	}

	internal PgpOnePassSignature(OnePassSignaturePacket sigPack)
	{
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

	public bool Verify(PgpSignature pgpSig)
	{
		return false;
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public void Encode(Stream outStr)
	{
	}
}
