using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Parameters;

public class ParametersWithRandom : ICipherParameters
{
	private readonly ICipherParameters m_parameters;

	private readonly SecureRandom m_random;

	public ICipherParameters Parameters => null;

	public SecureRandom Random => null;

	public ParametersWithRandom(ICipherParameters parameters)
	{
	}

	public ParametersWithRandom(ICipherParameters parameters, SecureRandom random)
	{
	}
}
