using Mirror.BouncyCastle.Math.EC;

namespace Mirror.BouncyCastle.Asn1.X9;

public abstract class X9ECParametersHolder
{
	private ECCurve m_curve;

	private X9ECParameters m_parameters;

	public ECCurve Curve => null;

	public X9ECParameters Parameters => null;

	protected virtual ECCurve CreateCurve()
	{
		return null;
	}

	protected abstract X9ECParameters CreateParameters();
}
