namespace Mirror.BouncyCastle.Math.EC;

public abstract class AbstractF2mPoint : ECPointBase
{
	protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: base(null, null, null)
	{
	}

	protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs)
		: base(null, null, null)
	{
	}

	protected override bool SatisfiesCurveEquation()
	{
		return false;
	}

	protected override bool SatisfiesOrder()
	{
		return false;
	}

	public override ECPoint ScaleX(ECFieldElement scale)
	{
		return null;
	}

	public override ECPoint ScaleXNegateY(ECFieldElement scale)
	{
		return null;
	}

	public override ECPoint ScaleY(ECFieldElement scale)
	{
		return null;
	}

	public override ECPoint ScaleYNegateX(ECFieldElement scale)
	{
		return null;
	}

	public override ECPoint Subtract(ECPoint b)
	{
		return null;
	}

	public virtual AbstractF2mPoint Tau()
	{
		return null;
	}

	public virtual AbstractF2mPoint TauPow(int pow)
	{
		return null;
	}
}
