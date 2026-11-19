using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Cms;

public abstract class RecipientInformation
{
	internal RecipientID rid;

	internal AlgorithmIdentifier keyEncAlg;

	internal CmsSecureReadable secureReadable;

	private byte[] resultMac;

	public RecipientID RecipientID => null;

	public AlgorithmIdentifier KeyEncryptionAlgorithmID => null;

	public string KeyEncryptionAlgOid => null;

	public Asn1Object KeyEncryptionAlgParams => null;

	internal RecipientInformation(AlgorithmIdentifier keyEncAlg, CmsSecureReadable secureReadable)
	{
	}

	internal string GetContentAlgorithmName()
	{
		return null;
	}

	internal CmsTypedStream GetContentFromSessionKey(KeyParameter sKey)
	{
		return null;
	}

	public byte[] GetContent(ICipherParameters key)
	{
		return null;
	}

	public byte[] GetMac()
	{
		return null;
	}

	public abstract CmsTypedStream GetContentStream(ICipherParameters key);
}
