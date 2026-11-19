using Mirror.BouncyCastle.Asn1.Cmp;
using Mirror.BouncyCastle.Asn1.X509;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crmf;

public class PKMacBuilder
{
	private AlgorithmIdentifier owf;

	private AlgorithmIdentifier mac;

	private IPKMacPrimitivesProvider provider;

	private SecureRandom random;

	private PbmParameter parameters;

	private int iterationCount;

	private int saltLength;

	private readonly int maxIterations;

	public PKMacBuilder()
	{
	}

	public PKMacBuilder(IPKMacPrimitivesProvider provider)
	{
	}

	public PKMacBuilder(IPKMacPrimitivesProvider provider, AlgorithmIdentifier digestAlgorithmIdentifier, AlgorithmIdentifier macAlgorithmIdentifier)
	{
	}

	public PKMacBuilder(IPKMacPrimitivesProvider provider, int maxIterations)
	{
	}

	private PKMacBuilder(AlgorithmIdentifier digestAlgorithmIdentifier, int iterationCount, AlgorithmIdentifier macAlgorithmIdentifier, IPKMacPrimitivesProvider provider)
	{
	}

	public PKMacBuilder SetSaltLength(int saltLength)
	{
		return null;
	}

	public PKMacBuilder SetIterationCount(int iterationCount)
	{
		return null;
	}

	public PKMacBuilder SetSecureRandom(SecureRandom random)
	{
		return null;
	}

	public PKMacBuilder SetParameters(PbmParameter parameters)
	{
		return null;
	}

	public IMacFactory Get(AlgorithmIdentifier algorithm, char[] password)
	{
		return null;
	}

	public IMacFactory Build(char[] password)
	{
		return null;
	}

	private void CheckIterationCountCeiling(int iterationCount)
	{
	}

	private IMacFactory GenCalculator(PbmParameter parameters, char[] password)
	{
		return null;
	}

	private IMacFactory GenCalculator(PbmParameter parameters, byte[] pw)
	{
		return null;
	}

	private PbmParameter GenParameters()
	{
		return null;
	}
}
