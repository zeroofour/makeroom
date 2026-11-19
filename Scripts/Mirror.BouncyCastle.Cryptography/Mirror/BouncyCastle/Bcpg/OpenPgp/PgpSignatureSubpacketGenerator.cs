using System;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Bcpg.OpenPgp;

public class PgpSignatureSubpacketGenerator
{
	private readonly List<SignatureSubpacket> list;

	public PgpSignatureSubpacketGenerator()
	{
	}

	public PgpSignatureSubpacketGenerator(PgpSignatureSubpacketVector sigSubV)
	{
	}

	public void SetRevocable(bool isCritical, bool isRevocable)
	{
	}

	public void SetExportable(bool isCritical, bool isExportable)
	{
	}

	public void SetFeature(bool isCritical, byte feature)
	{
	}

	public void SetTrust(bool isCritical, int depth, int trustAmount)
	{
	}

	public void SetKeyExpirationTime(bool isCritical, long seconds)
	{
	}

	public void SetSignatureExpirationTime(bool isCritical, long seconds)
	{
	}

	public void SetSignatureCreationTime(bool isCritical, DateTime date)
	{
	}

	public void SetPreferredHashAlgorithms(bool isCritical, int[] algorithms)
	{
	}

	public void SetPreferredSymmetricAlgorithms(bool isCritical, int[] algorithms)
	{
	}

	public void SetPreferredCompressionAlgorithms(bool isCritical, int[] algorithms)
	{
	}

	public void SetPreferredAeadAlgorithms(bool isCritical, int[] algorithms)
	{
	}

	public void AddPolicyUrl(bool isCritical, string policyUrl)
	{
	}

	public void SetKeyFlags(bool isCritical, int flags)
	{
	}

	[Obsolete("Use 'AddSignerUserId' instead")]
	public void SetSignerUserId(bool isCritical, string userId)
	{
	}

	public void AddSignerUserId(bool isCritical, string userId)
	{
	}

	public void SetSignerUserId(bool isCritical, byte[] rawUserId)
	{
	}

	[Obsolete("Use 'AddEmbeddedSignature' instead")]
	public void SetEmbeddedSignature(bool isCritical, PgpSignature pgpSignature)
	{
	}

	public void AddEmbeddedSignature(bool isCritical, PgpSignature pgpSignature)
	{
	}

	public void SetPrimaryUserId(bool isCritical, bool isPrimaryUserId)
	{
	}

	[Obsolete("Use 'AddNotationData' instead")]
	public void SetNotationData(bool isCritical, bool isHumanReadable, string notationName, string notationValue)
	{
	}

	public void AddNotationData(bool isCritical, bool isHumanReadable, string notationName, string notationValue)
	{
	}

	public void SetRevocationReason(bool isCritical, RevocationReasonTag reason, string description)
	{
	}

	[Obsolete("Use 'AddRevocationKey' instead")]
	public void SetRevocationKey(bool isCritical, PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
	{
	}

	public void AddRevocationKey(bool isCritical, PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
	{
	}

	public void SetIssuerKeyID(bool isCritical, long keyID)
	{
	}

	public void SetSignatureTarget(bool isCritical, int publicKeyAlgorithm, int hashAlgorithm, byte[] hashData)
	{
	}

	public void SetIssuerFingerprint(bool isCritical, PgpSecretKey secretKey)
	{
	}

	public void SetIssuerFingerprint(bool isCritical, PgpPublicKey publicKey)
	{
	}

	public void AddIntendedRecipientFingerprint(bool isCritical, PgpPublicKey publicKey)
	{
	}

	public void AddCustomSubpacket(SignatureSubpacket subpacket)
	{
	}

	public bool RemovePacket(SignatureSubpacket packet)
	{
		return false;
	}

	public bool HasSubpacket(SignatureSubpacketTag type)
	{
		return false;
	}

	public SignatureSubpacket[] GetSubpackets(SignatureSubpacketTag type)
	{
		return null;
	}

	public PgpSignatureSubpacketVector Generate()
	{
		return null;
	}
}
