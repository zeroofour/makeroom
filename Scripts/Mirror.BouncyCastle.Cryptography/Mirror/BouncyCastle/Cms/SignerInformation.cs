using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cms;

public class SignerInformation
{
	private SignerID sid;

	private CmsProcessable content;

	private byte[] signature;

	private DerObjectIdentifier contentType;

	private byte[] calculatedDigest;

	private byte[] resultDigest;

	private Mirror.BouncyCastle.Asn1.Cms.AttributeTable signedAttributeTable;

	private Mirror.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributeTable;

	private readonly bool isCounterSignature;

	protected SignerInfo info;

	protected AlgorithmIdentifier digestAlgorithm;

	protected AlgorithmIdentifier encryptionAlgorithm;

	protected readonly Asn1Set signedAttributeSet;

	protected readonly Asn1Set unsignedAttributeSet;

	public bool IsCounterSignature => false;

	public DerObjectIdentifier ContentType => null;

	public SignerID SignerID => null;

	public int Version => 0;

	public AlgorithmIdentifier DigestAlgorithmID => null;

	public string DigestAlgOid => null;

	public Asn1Object DigestAlgParams => null;

	public AlgorithmIdentifier EncryptionAlgorithmID => null;

	public string EncryptionAlgOid => null;

	public Asn1Object EncryptionAlgParams => null;

	public Mirror.BouncyCastle.Asn1.Cms.AttributeTable SignedAttributes => null;

	public Mirror.BouncyCastle.Asn1.Cms.AttributeTable UnsignedAttributes => null;

	internal SignerInformation(SignerInfo info, DerObjectIdentifier contentType, CmsProcessable content, byte[] calculatedDigest)
	{
	}

	protected SignerInformation(SignerInformation baseInfo)
	{
	}

	public byte[] GetContentDigest()
	{
		return null;
	}

	public byte[] GetSignature()
	{
		return null;
	}

	public SignerInformationStore GetCounterSignatures()
	{
		return null;
	}

	public virtual byte[] GetEncodedSignedAttributes()
	{
		return null;
	}

	private bool DoVerify(AsymmetricKeyParameter publicKey)
	{
		return false;
	}

	private bool IsNull(Asn1Encodable o)
	{
		return false;
	}

	private DigestInfo DerDecode(byte[] encoding)
	{
		return null;
	}

	private bool VerifyDigest(byte[] digest, AsymmetricKeyParameter publicKey, byte[] signature)
	{
		return false;
	}

	public bool Verify(AsymmetricKeyParameter pubKey)
	{
		return false;
	}

	public bool Verify(X509Certificate cert)
	{
		return false;
	}

	public SignerInfo ToSignerInfo()
	{
		return null;
	}

	private Asn1Object GetSingleValuedSignedAttribute(DerObjectIdentifier attrOID, string printableName)
	{
		return null;
	}

	private Mirror.BouncyCastle.Asn1.Cms.Time GetSigningTime()
	{
		return null;
	}

	public static SignerInformation ReplaceUnsignedAttributes(SignerInformation signerInformation, Mirror.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributes)
	{
		return null;
	}

	public static SignerInformation AddCounterSigners(SignerInformation signerInformation, SignerInformationStore counterSigners)
	{
		return null;
	}
}
