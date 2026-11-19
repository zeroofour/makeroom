using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Crmf;

public class CertificateRequestMessageBuilder
{
	private readonly List<IControl> m_controls;

	private readonly X509ExtensionsGenerator m_extGenerator;

	private readonly CertTemplateBuilder m_templateBuilder;

	private readonly BigInteger m_certReqID;

	private ISignatureFactory m_popSigner;

	private PKMacBuilder m_pkMacBuilder;

	private char[] m_password;

	private GeneralName m_sender;

	private int m_popoType;

	private PopoPrivKey m_popoPrivKey;

	private Asn1Null m_popRaVerified;

	private PKMacValue m_agreeMac;

	private AttributeTypeAndValue[] m_regInfo;

	public CertificateRequestMessageBuilder(BigInteger certReqId)
	{
	}

	public CertificateRequestMessageBuilder SetRegInfo(AttributeTypeAndValue[] regInfo)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetPublicKey(SubjectPublicKeyInfo publicKeyInfo)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetIssuer(X509Name issuer)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetSubject(X509Name subject)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetSerialNumber(BigInteger serialNumber)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetSerialNumber(DerInteger serialNumber)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetValidity(DateTime? notBefore, DateTime? notAfter)
	{
		return null;
	}

	public CertificateRequestMessageBuilder AddExtension(DerObjectIdentifier oid, bool critical, Asn1Encodable value)
	{
		return null;
	}

	public CertificateRequestMessageBuilder AddExtension(DerObjectIdentifier oid, bool critical, byte[] value)
	{
		return null;
	}

	public CertificateRequestMessageBuilder AddControl(IControl control)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionSignKeySigner(ISignatureFactory popoSignatureFactory)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionSubsequentMessage(SubsequentMessage msg)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionSubsequentMessage(int type, SubsequentMessage msg)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionAgreeMac(PKMacValue macValue)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetProofOfPossessionRaVerified()
	{
		return null;
	}

	[Obsolete("Use 'SetAuthInfoPKMacBuilder' instead")]
	public CertificateRequestMessageBuilder SetAuthInfoPKMAC(PKMacBuilder pkmacFactory, char[] password)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetAuthInfoPKMacBuilder(PKMacBuilder pkmacFactory, char[] password)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetAuthInfoSender(X509Name sender)
	{
		return null;
	}

	public CertificateRequestMessageBuilder SetAuthInfoSender(GeneralName sender)
	{
		return null;
	}

	public CertificateRequestMessage Build()
	{
		return null;
	}

	private static Time CreateTime(DateTime? dateTime)
	{
		return null;
	}
}
