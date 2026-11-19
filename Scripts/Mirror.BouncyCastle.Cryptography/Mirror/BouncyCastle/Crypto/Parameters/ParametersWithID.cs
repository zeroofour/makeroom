namespace Mirror.BouncyCastle.Crypto.Parameters;

public class ParametersWithID : ICipherParameters
{
	private readonly ICipherParameters m_parameters;

	private readonly byte[] m_id;

	public ICipherParameters Parameters => null;

	public ParametersWithID(ICipherParameters parameters, byte[] id)
	{
	}

	public ParametersWithID(ICipherParameters parameters, byte[] id, int idOff, int idLen)
	{
	}

	public byte[] GetID()
	{
		return null;
	}
}
