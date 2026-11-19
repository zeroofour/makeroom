namespace Mirror.BouncyCastle.Math.EC.Endo;

public class GlvTypeBParameters
{
	protected readonly BigInteger m_beta;

	protected readonly BigInteger m_lambda;

	protected readonly ScalarSplitParameters m_splitParams;

	public virtual BigInteger Beta => null;

	public virtual BigInteger Lambda => null;

	public virtual ScalarSplitParameters SplitParams => null;

	public GlvTypeBParameters(BigInteger beta, BigInteger lambda, ScalarSplitParameters splitParams)
	{
	}
}
