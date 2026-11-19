using System.Collections.Generic;
using Mirror.BouncyCastle.Asn1;
using Mirror.BouncyCastle.Asn1.Cms;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Cms;

public class KeyAgreeRecipientInformation : RecipientInformation
{
	private readonly KeyAgreeRecipientInfo m_info;

	private readonly Asn1OctetString m_encryptedKey;

	internal static void ReadRecipientInfo(IList<RecipientInformation> infos, KeyAgreeRecipientInfo info, CmsSecureReadable secureReadable)
	{
	}

	internal KeyAgreeRecipientInformation(KeyAgreeRecipientInfo info, RecipientID rid, Asn1OctetString encryptedKey, CmsSecureReadable secureReadable)
		: base(null, null)
	{
	}

	private AsymmetricKeyParameter GetSenderPublicKey(AsymmetricKeyParameter receiverPrivateKey, OriginatorIdentifierOrKey originator)
	{
		return null;
	}

	private AsymmetricKeyParameter GetPublicKeyFromOriginatorPublicKey(AsymmetricKeyParameter receiverPrivateKey, OriginatorPublicKey originatorPublicKey)
	{
		return null;
	}

	private AsymmetricKeyParameter GetPublicKeyFromOriginatorID(OriginatorID origID)
	{
		return null;
	}

	private KeyParameter CalculateAgreedWrapKey(DerObjectIdentifier wrapAlgOid, AsymmetricKeyParameter senderPublicKey, AsymmetricKeyParameter receiverPrivateKey)
	{
		return null;
	}

	private KeyParameter UnwrapSessionKey(DerObjectIdentifier wrapAlgOid, KeyParameter agreedKey)
	{
		return null;
	}

	internal KeyParameter GetSessionKey(AsymmetricKeyParameter receiverPrivateKey)
	{
		return null;
	}

	public override CmsTypedStream GetContentStream(ICipherParameters key)
	{
		return null;
	}
}
