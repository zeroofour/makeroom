using System;
using Mirror.BouncyCastle.Bcpg.Sig;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpSignatureSubpacketVector
{
	private readonly SignatureSubpacket[] packets;

	public int Count => 0;

	public static PgpSignatureSubpacketVector FromSubpackets(SignatureSubpacket[] packets)
	{
		return null;
	}

	internal PgpSignatureSubpacketVector(SignatureSubpacket[] packets)
	{
	}

	public SignatureSubpacket GetSubpacket(SignatureSubpacketTag type)
	{
		return null;
	}

	public bool HasSubpacket(SignatureSubpacketTag type)
	{
		return false;
	}

	public SignatureSubpacket[] GetSubpackets(SignatureSubpacketTag type)
	{
		return null;
	}

	public PgpSignatureList GetEmbeddedSignatures()
	{
		return null;
	}

	public NotationData[] GetNotationDataOccurrences()
	{
		return null;
	}

	public NotationData[] GetNotationDataOccurrences(string notationName)
	{
		return null;
	}

	public long GetIssuerKeyId()
	{
		return 0L;
	}

	public bool HasSignatureCreationTime()
	{
		return false;
	}

	public DateTime GetSignatureCreationTime()
	{
		return default;
	}

	public bool HasSignatureExpirationTime()
	{
		return false;
	}

	public long GetSignatureExpirationTime()
	{
		return 0L;
	}

	public long GetKeyExpirationTime()
	{
		return 0L;
	}

	public int[] GetPreferredHashAlgorithms()
	{
		return null;
	}

	public int[] GetPreferredSymmetricAlgorithms()
	{
		return null;
	}

	public int[] GetPreferredCompressionAlgorithms()
	{
		return null;
	}

	public int[] GetPreferredAeadAlgorithms()
	{
		return null;
	}

	public int GetKeyFlags()
	{
		return 0;
	}

	public string GetSignerUserId()
	{
		return null;
	}

	public bool IsPrimaryUserId()
	{
		return false;
	}

	public SignatureSubpacketTag[] GetCriticalTags()
	{
		return null;
	}

	public SignatureTarget GetSignatureTarget()
	{
		return null;
	}

	public Features GetFeatures()
	{
		return null;
	}

	public IssuerFingerprint GetIssuerFingerprint()
	{
		return null;
	}

	public IntendedRecipientFingerprint GetIntendedRecipientFingerprint()
	{
		return null;
	}

	public IntendedRecipientFingerprint[] GetIntendedRecipientFingerprints()
	{
		return null;
	}

	public Exportable GetExportable()
	{
		return null;
	}

	public bool IsExportable()
	{
		return false;
	}

	public PolicyUrl GetPolicyUrl()
	{
		return null;
	}

	public PolicyUrl[] GetPolicyUrls()
	{
		return null;
	}

	public RegularExpression GetRegularExpression()
	{
		return null;
	}

	public RegularExpression[] GetRegularExpressions()
	{
		return null;
	}

	public Revocable GetRevocable()
	{
		return null;
	}

	public bool IsRevocable()
	{
		return false;
	}

	public RevocationKey[] GetRevocationKeys()
	{
		return null;
	}

	public RevocationReason GetRevocationReason()
	{
		return null;
	}

	public TrustSignature GetTrust()
	{
		return null;
	}

	internal SignatureSubpacket[] ToSubpacketArray()
	{
		return null;
	}

	public SignatureSubpacket[] ToArray()
	{
		return null;
	}
}
