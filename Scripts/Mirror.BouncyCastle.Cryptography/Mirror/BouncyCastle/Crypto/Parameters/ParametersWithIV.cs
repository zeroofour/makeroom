namespace Mirror.BouncyCastle.Crypto.Parameters;

public class ParametersWithIV : ICipherParameters
{
	private readonly ICipherParameters m_parameters;

	private readonly byte[] m_iv;

	public int IVLength => 0;

	public ICipherParameters Parameters => null;

	internal static ICipherParameters ApplyOptionalIV(ICipherParameters parameters, byte[] iv)
	{
		return null;
	}

	public ParametersWithIV(ICipherParameters parameters, byte[] iv)
	{
	}

	public ParametersWithIV(ICipherParameters parameters, byte[] iv, int ivOff, int ivLen)
	{
	}

	private ParametersWithIV(ICipherParameters parameters, int ivLength)
	{
	}

	public void CopyIVTo(byte[] buf, int off, int len)
	{
	}

	public byte[] GetIV()
	{
		return null;
	}
}
