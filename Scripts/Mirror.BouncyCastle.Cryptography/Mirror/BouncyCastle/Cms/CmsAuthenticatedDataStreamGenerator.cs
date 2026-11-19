using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Cms;

public class CmsAuthenticatedDataStreamGenerator : CmsAuthenticatedGenerator
{
	private class CmsAuthenticatedDataOutputStream : BaseOutputStream
	{
		private readonly Stream macStream;

		private readonly IMac mac;

		private readonly BerSequenceGenerator cGen;

		private readonly BerSequenceGenerator authGen;

		private readonly BerSequenceGenerator eiGen;

		private readonly BerOctetStringGenerator octGen;

		public CmsAuthenticatedDataOutputStream(Stream macStream, IMac mac, BerSequenceGenerator cGen, BerSequenceGenerator authGen, BerSequenceGenerator eiGen, BerOctetStringGenerator octGen)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	private int _bufferSize;

	private bool _berEncodeRecipientSet;

	public CmsAuthenticatedDataStreamGenerator()
	{
	}

	public CmsAuthenticatedDataStreamGenerator(SecureRandom random)
	{
	}

	public void SetBufferSize(int bufferSize)
	{
	}

	public void SetBerEncodeRecipients(bool berEncodeRecipientSet)
	{
	}

	private Stream Open(Stream outStr, string macOid, CipherKeyGenerator keyGen)
	{
		return null;
	}

	protected Stream Open(Stream outStr, AlgorithmIdentifier macAlgId, ICipherParameters cipherParameters, Asn1EncodableVector recipientInfos)
	{
		return null;
	}

	public Stream Open(Stream outStr, string encryptionOid)
	{
		return null;
	}

	public Stream Open(Stream outStr, string encryptionOid, int keySize)
	{
		return null;
	}
}
