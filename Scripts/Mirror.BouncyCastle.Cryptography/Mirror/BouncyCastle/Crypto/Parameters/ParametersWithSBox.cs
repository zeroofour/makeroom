namespace Mirror.BouncyCastle.Crypto.Parameters;

public class ParametersWithSBox : ICipherParameters
{
	private readonly ICipherParameters m_parameters;

	private readonly byte[] m_sBox;

	public ICipherParameters Parameters => null;

	public ParametersWithSBox(ICipherParameters parameters, byte[] sBox)
	{
	}

	public byte[] GetSBox()
	{
		return null;
	}
}
