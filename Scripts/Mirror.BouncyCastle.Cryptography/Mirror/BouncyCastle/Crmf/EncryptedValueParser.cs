using Mirror.BouncyCastle.Asn1.Crmf;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Crmf;

public class EncryptedValueParser
{
	private readonly EncryptedValue m_value;

	private readonly IEncryptedValuePadder m_padder;

	public virtual AlgorithmIdentifier IntendedAlg => null;

	public EncryptedValueParser(EncryptedValue value)
	{
	}

	public EncryptedValueParser(EncryptedValue value, IEncryptedValuePadder padder)
	{
	}

	private byte[] UnpadData(byte[] data)
	{
		return null;
	}
}
