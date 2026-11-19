using System.IO;

namespace Mirror.BouncyCastle.Tls;

public sealed class DigitallySigned
{
	private readonly SignatureAndHashAlgorithm m_algorithm;

	private readonly byte[] m_signature;

	public SignatureAndHashAlgorithm Algorithm => null;

	public byte[] Signature => null;

	public DigitallySigned(SignatureAndHashAlgorithm algorithm, byte[] signature)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static DigitallySigned Parse(TlsContext context, Stream input)
	{
		return null;
	}
}
