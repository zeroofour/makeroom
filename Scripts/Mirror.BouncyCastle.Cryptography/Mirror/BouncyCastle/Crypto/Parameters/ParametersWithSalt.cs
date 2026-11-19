namespace Mirror.BouncyCastle.Crypto.Parameters;

public class ParametersWithSalt : ICipherParameters
{
	private readonly ICipherParameters m_parameters;

	private readonly byte[] m_salt;

	public ICipherParameters Parameters => null;

	public ParametersWithSalt(ICipherParameters parameters, byte[] salt)
	{
	}

	public ParametersWithSalt(ICipherParameters parameters, byte[] salt, int saltOff, int saltLen)
	{
	}

	public byte[] GetSalt()
	{
		return null;
	}
}
