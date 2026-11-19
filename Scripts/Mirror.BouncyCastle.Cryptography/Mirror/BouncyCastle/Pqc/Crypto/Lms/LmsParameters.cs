namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LmsParameters
{
	private readonly LMSigParameters m_lmSigParameters;

	private readonly LMOtsParameters m_lmOtsParameters;

	public LMSigParameters LMSigParameters => null;

	public LMOtsParameters LMOtsParameters => null;

	public LmsParameters(LMSigParameters lmSigParameters, LMOtsParameters lmOtsParameters)
	{
	}
}
