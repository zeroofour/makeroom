using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Asn1.Tsp;

public class EvidenceRecord : Asn1Encodable
{
	private static readonly DerObjectIdentifier Oid;

	private readonly DerInteger m_version;

	private readonly Asn1Sequence m_digestAlgorithms;

	private readonly CryptoInfos m_cryptoInfos;

	private readonly EncryptionInfo m_encryptionInfo;

	private readonly ArchiveTimeStampSequence m_archiveTimeStampSequence;

	public virtual ArchiveTimeStampSequence ArchiveTimeStampSequence => null;

	public static EvidenceRecord GetInstance(object obj)
	{
		return null;
	}

	public static EvidenceRecord GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit)
	{
		return null;
	}

	private EvidenceRecord(EvidenceRecord evidenceRecord, ArchiveTimeStampSequence replacementSequence, ArchiveTimeStamp newChainTimeStamp)
	{
	}

	public EvidenceRecord(CryptoInfos cryptoInfos, EncryptionInfo encryptionInfo, ArchiveTimeStamp archiveTimeStamp)
	{
	}

	public EvidenceRecord(AlgorithmIdentifier[] digestAlgorithms, CryptoInfos cryptoInfos, EncryptionInfo encryptionInfo, ArchiveTimeStampSequence archiveTimeStampSequence)
	{
	}

	private EvidenceRecord(Asn1Sequence sequence)
	{
	}

	public virtual AlgorithmIdentifier[] GetDigestAlgorithms()
	{
		return null;
	}

	public virtual EvidenceRecord AddArchiveTimeStamp(ArchiveTimeStamp ats, bool newChain)
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
