using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

public class NtruKemExtractor : IEncapsulatedSecretExtractor
{
	private readonly NtruParameters _parameters;

	private readonly NtruPrivateKeyParameters _ntruPrivateKey;

	public int EncapsulationLength => 0;

	public NtruKemExtractor(NtruPrivateKeyParameters ntruPrivateKey)
	{
	}

	public byte[] ExtractSecret(byte[] encapsulation)
	{
		return null;
	}

	private static void Cmov(byte[] r, byte[] x, byte b)
	{
	}
}
