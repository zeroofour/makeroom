using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Cms;

internal class CmsAuthEnvelopedData
{
	private class AuthEnvelopedSecureReadable : CmsSecureReadable
	{
		private readonly CmsAuthEnvelopedData parent;

		public AlgorithmIdentifier Algorithm => null;

		public object CryptoObject => null;

		internal AuthEnvelopedSecureReadable(CmsAuthEnvelopedData parent)
		{
		}

		public CmsReadable GetReadable(KeyParameter key)
		{
			return null;
		}
	}

	internal RecipientInformationStore recipientInfoStore;

	internal ContentInfo contentInfo;

	private OriginatorInfo originator;

	private AlgorithmIdentifier authEncAlg;

	private Asn1Set authAttrs;

	private byte[] mac;

	private Asn1Set unauthAttrs;

	public CmsAuthEnvelopedData(byte[] authEnvData)
	{
	}

	public CmsAuthEnvelopedData(Stream authEnvData)
	{
	}

	public CmsAuthEnvelopedData(ContentInfo contentInfo)
	{
	}
}
