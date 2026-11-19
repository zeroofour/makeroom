namespace Mirror.BouncyCastle.Math.EC;

public abstract class AbstractFpPoint : ECPointBase
{
	protected internal override bool CompressionYTilde => false;

	protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: base(null, null, null)
	{
	}

	protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs)
		: base(null, null, null)
	{
	}

	protected override bool SatisfiesCurveEquation()
	{
		return false;
	}

	public override ECPoint Subtract(ECPoint b)
	{
		return null;
	}
}
