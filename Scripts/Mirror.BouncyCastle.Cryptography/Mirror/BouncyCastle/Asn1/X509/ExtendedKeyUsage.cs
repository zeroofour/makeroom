using System.Collections.Generic;

namespace Mirror.BouncyCastle.Asn1.X509;

public class ExtendedKeyUsage : Asn1Encodable
{
	internal readonly HashSet<DerObjectIdentifier> m_usageTable;

	internal readonly Asn1Sequence seq;

	public int Count => 0;

	public static ExtendedKeyUsage GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return null;
	}

	public static ExtendedKeyUsage GetInstance(object obj)
	{
		return null;
	}

	public static ExtendedKeyUsage FromExtensions(X509Extensions extensions)
	{
		return null;
	}

	private ExtendedKeyUsage(Asn1Sequence seq)
	{
	}

	public ExtendedKeyUsage(params KeyPurposeID[] usages)
	{
	}

	public ExtendedKeyUsage(IEnumerable<DerObjectIdentifier> usages)
	{
	}

	public bool HasKeyPurposeId(KeyPurposeID keyPurposeId)
	{
		return false;
	}

	public IList<DerObjectIdentifier> GetAllUsages()
	{
		return null;
	}

	public override Asn1Object ToAsn1Object()
	{
		return null;
	}
}
