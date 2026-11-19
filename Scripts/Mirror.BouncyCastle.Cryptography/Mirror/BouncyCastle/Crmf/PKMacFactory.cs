using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.BouncyCastle.Crmf;

internal sealed class PKMacFactory : IMacFactory
{
	private readonly KeyParameter m_key;

	private readonly PbmParameter m_parameters;

	public object AlgorithmDetails => null;

	internal PKMacFactory(byte[] key, PbmParameter parameters)
	{
	}

	public IStreamCalculator<IBlockResult> CreateCalculator()
	{
		return null;
	}
}
