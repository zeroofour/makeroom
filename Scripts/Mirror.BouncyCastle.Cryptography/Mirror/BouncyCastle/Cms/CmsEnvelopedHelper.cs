using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Cms;

internal class CmsEnvelopedHelper
{
	internal class CmsAuthenticatedSecureReadable : CmsSecureReadable
	{
		private AlgorithmIdentifier algorithm;

		private IMac mac;

		private CmsReadable readable;

		public AlgorithmIdentifier Algorithm => null;

		public object CryptoObject => null;

		internal CmsAuthenticatedSecureReadable(AlgorithmIdentifier algorithm, CmsReadable readable)
		{
		}

		public CmsReadable GetReadable(KeyParameter sKey)
		{
			return null;
		}
	}

	internal class CmsEnvelopedSecureReadable : CmsSecureReadable
	{
		private AlgorithmIdentifier algorithm;

		private IBufferedCipher cipher;

		private CmsReadable readable;

		public AlgorithmIdentifier Algorithm => null;

		public object CryptoObject => null;

		internal CmsEnvelopedSecureReadable(AlgorithmIdentifier algorithm, CmsReadable readable)
		{
		}

		public CmsReadable GetReadable(KeyParameter sKey)
		{
			return null;
		}
	}

	private static readonly Dictionary<string, int> KeySizes;

	private static readonly Dictionary<string, string> Rfc3211WrapperNames;

	static CmsEnvelopedHelper()
	{
	}

	internal static RecipientInformationStore BuildRecipientInformationStore(Asn1Set recipientInfos, CmsSecureReadable secureReadable)
	{
		return null;
	}

	internal static int GetKeySize(string oid)
	{
		return 0;
	}

	internal static string GetRfc3211WrapperName(string oid)
	{
		return null;
	}

	private static void ReadRecipientInfo(IList<RecipientInformation> infos, RecipientInfo info, CmsSecureReadable secureReadable)
	{
	}
}
