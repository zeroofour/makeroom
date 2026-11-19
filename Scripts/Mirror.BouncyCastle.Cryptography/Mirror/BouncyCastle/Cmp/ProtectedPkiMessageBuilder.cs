using System;
using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crmf;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.X509;

namespace Mirror.BouncyCastle.Cmp;

public sealed class ProtectedPkiMessageBuilder
{
	private readonly PkiHeaderBuilder m_hdrBuilder;

	private readonly List<InfoTypeAndValue> m_generalInfos;

	private readonly List<X509Certificate> m_extraCerts;

	private PkiBody m_body;

	public ProtectedPkiMessageBuilder(GeneralName sender, GeneralName recipient)
	{
	}

	public ProtectedPkiMessageBuilder(int pvno, GeneralName sender, GeneralName recipient)
	{
	}

	public ProtectedPkiMessageBuilder SetTransactionId(byte[] tid)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetFreeText(PkiFreeText freeText)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder AddGeneralInfo(InfoTypeAndValue genInfo)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetMessageTime(DateTime time)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetMessageTime(Asn1GeneralizedTime generalizedTime)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetRecipKID(byte[] id)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetRecipNonce(byte[] nonce)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetSenderKID(byte[] id)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetSenderNonce(byte[] nonce)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetBody(PkiBody body)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetBody(int bodyType, CertificateReqMessages certificateReqMessages)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetBody(int bodyType, CertificateRepMessage certificateRepMessage)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder SetBody(int bodyType, CertificateConfirmationContent certificateConfirmationContent)
	{
		return null;
	}

	public ProtectedPkiMessageBuilder AddCmpCertificate(X509Certificate certificate)
	{
		return null;
	}

	public ProtectedPkiMessage Build(ISignatureFactory signatureFactory)
	{
		return null;
	}

	public ProtectedPkiMessage Build(IMacFactory macFactory)
	{
		return null;
	}

	private void FinalizeHeader(AlgorithmIdentifier algorithmIdentifier)
	{
	}

	private ProtectedPkiMessage FinalizeMessage(PkiHeader header, DerBitString protection)
	{
		return null;
	}
}
