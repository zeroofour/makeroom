using System.Collections.Generic;
using System.IO;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;
using Mirror.BouncyCastle.Utilities.IO;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class CmsSignedDataStreamGenerator : CmsSignedGenerator
{
	private class SignerInfoGeneratorImpl
	{
		private readonly CmsSignedDataStreamGenerator outer;

		private readonly SignerIdentifier _signerIdentifier;

		internal readonly DerObjectIdentifier m_digestOid;

		private readonly DerObjectIdentifier m_encOid;

		private readonly CmsAttributeTableGenerator _sAttr;

		private readonly CmsAttributeTableGenerator _unsAttr;

		private readonly string _encName;

		private readonly ISigner _sig;

		internal SignerInfoGeneratorImpl(CmsSignedDataStreamGenerator outer, AsymmetricKeyParameter key, SignerIdentifier signerIdentifier, DerObjectIdentifier digestOid, DerObjectIdentifier encOid, CmsAttributeTableGenerator sAttr, CmsAttributeTableGenerator unsAttr)
		{
		}

		internal SignerInfo Generate(DerObjectIdentifier contentType, byte[] calculatedDigest)
		{
			return null;
		}
	}

	private class CmsSignedDataOutputStream : BaseOutputStream
	{
		private readonly CmsSignedDataStreamGenerator outer;

		private Stream _out;

		private DerObjectIdentifier _contentOID;

		private BerSequenceGenerator _sGen;

		private BerSequenceGenerator _sigGen;

		private BerSequenceGenerator _eiGen;

		private BerOctetStringGenerator _octGen;

		public CmsSignedDataOutputStream(CmsSignedDataStreamGenerator outer, Stream outStream, string contentOID, BerSequenceGenerator sGen, BerSequenceGenerator sigGen, BerSequenceGenerator eiGen, BerOctetStringGenerator octGen)
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

		private void DoClose()
		{
		}

		private static void WriteToGenerator(Asn1Generator ag, Asn1Encodable ae)
		{
		}
	}

	private readonly List<SignerInfoGeneratorImpl> m_signerInfoGens;

	private readonly HashSet<DerObjectIdentifier> m_messageDigestOids;

	private readonly IDictionary<string, IDigest> m_messageDigests;

	private readonly IDictionary<string, byte[]> m_messageHashes;

	private bool _messageDigestsLocked;

	private int _bufferSize;

	public CmsSignedDataStreamGenerator()
	{
	}

	public CmsSignedDataStreamGenerator(SecureRandom random)
	{
	}

	public void SetBufferSize(int bufferSize)
	{
	}

	public void AddDigests(params string[] digestOids)
	{
	}

	public void AddDigests(IEnumerable<string> digestOids)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOid)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOid, string digestOid)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOid, AttributeTable signedAttr, AttributeTable unsignedAttr)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOid, string digestOid, AttributeTable signedAttr, AttributeTable unsignedAttr)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOid, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOid, string digestOid)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid, AttributeTable signedAttr, AttributeTable unsignedAttr)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
	}

	public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOid, string digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
	}

	private void DoAddSigner(AsymmetricKeyParameter privateKey, SignerIdentifier signerIdentifier, DerObjectIdentifier encryptionOid, DerObjectIdentifier digestOid, CmsAttributeTableGenerator signedAttrGenerator, CmsAttributeTableGenerator unsignedAttrGenerator)
	{
	}

	internal override void AddSignerCallback(SignerInformation si)
	{
	}

	public Stream Open(Stream outStream)
	{
		return null;
	}

	public Stream Open(Stream outStream, bool encapsulate)
	{
		return null;
	}

	public Stream Open(Stream outStream, bool encapsulate, Stream dataOutputStream)
	{
		return null;
	}

	public Stream Open(Stream outStream, string signedContentType, bool encapsulate)
	{
		return null;
	}

	public Stream Open(Stream outStream, string signedContentType, bool encapsulate, Stream dataOutputStream)
	{
		return null;
	}

	private void RegisterDigestOid(DerObjectIdentifier digestOid)
	{
	}

	private void ConfigureDigest(DerObjectIdentifier digestOid)
	{
	}

	internal void Generate(Stream outStream, string eContentType, bool encapsulate, Stream dataOutputStream, CmsProcessable content)
	{
	}

	private DerInteger CalculateVersion(DerObjectIdentifier contentOid)
	{
		return null;
	}

	private bool CheckForVersion3(IList<SignerInformation> signerInfos)
	{
		return false;
	}

	private static Stream AttachDigestsToOutputStream(IEnumerable<IDigest> digests, Stream s)
	{
		return null;
	}

	private static Stream GetSafeOutputStream(Stream s)
	{
		return null;
	}

	private static Stream GetSafeTeeOutputStream(Stream s1, Stream s2)
	{
		return null;
	}
}
