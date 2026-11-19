using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.IO;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.Utilities.IO;

namespace Mirror.BouncyCastle.Cms;

public class CmsEnvelopedDataStreamGenerator : CmsEnvelopedGenerator
{
	private class CmsEnvelopedDataOutputStream : BaseOutputStream
	{
		private readonly CmsEnvelopedGenerator _outer;

		private readonly CipherStream _out;

		private readonly BerSequenceGenerator _cGen;

		private readonly BerSequenceGenerator _envGen;

		private readonly BerSequenceGenerator _eiGen;

		private readonly BerOctetStringGenerator _octGen;

		public CmsEnvelopedDataOutputStream(CmsEnvelopedGenerator outer, CipherStream outStream, BerSequenceGenerator cGen, BerSequenceGenerator envGen, BerSequenceGenerator eiGen, BerOctetStringGenerator octGen)
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

	private object _originatorInfo;

	private object _unprotectedAttributes;

	private int _bufferSize;

	private bool _berEncodeRecipientSet;

	private DerInteger Version => null;

	public CmsEnvelopedDataStreamGenerator()
	{
	}

	public CmsEnvelopedDataStreamGenerator(SecureRandom random)
	{
	}

	public void SetBufferSize(int bufferSize)
	{
	}

	public void SetBerEncodeRecipients(bool berEncodeRecipientSet)
	{
	}

	private Stream Open(Stream outStream, string encryptionOid, CipherKeyGenerator keyGen)
	{
		return null;
	}

	private Stream Open(Stream outStream, AlgorithmIdentifier encAlgID, ICipherParameters cipherParameters, Asn1EncodableVector recipientInfos)
	{
		return null;
	}

	public Stream Open(Stream outStream, string encryptionOid)
	{
		return null;
	}

	public Stream Open(Stream outStream, string encryptionOid, int keySize)
	{
		return null;
	}
}
