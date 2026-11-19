using System.IO;
using Mirror.BouncyCastle.Asn1.X509;

namespace Mirror.BouncyCastle.Tls;

public sealed class TrustedAuthority
{
	private readonly short m_identifierType;

	private readonly object m_identifier;

	public short IdentifierType => 0;

	public object Identifier => null;

	public X509Name X509Name => null;

	public TrustedAuthority(short identifierType, object identifier)
	{
	}

	public byte[] GetCertSha1Hash()
	{
		return null;
	}

	public byte[] GetKeySha1Hash()
	{
		return null;
	}

	public void Encode(Stream output)
	{
	}

	public static TrustedAuthority Parse(Stream input)
	{
		return null;
	}

	private void CheckCorrectType(short expectedIdentifierType)
	{
	}

	private static bool IsCorrectType(short identifierType, object identifier)
	{
		return false;
	}

	private static bool IsSha1Hash(object identifier)
	{
		return false;
	}
}
