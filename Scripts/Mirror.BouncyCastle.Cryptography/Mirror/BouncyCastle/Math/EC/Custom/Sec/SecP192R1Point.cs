namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP192R1Point : AbstractFpPoint
{
	internal SecP192R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: base(null, null, null)
	{
	}

	internal SecP192R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs)
		: base(null, null, null)
	{
	}

	protected override ECPoint Detach()
	{
		return null;
	}

	public override ECPoint Add(ECPoint b)
	{
		return null;
	}

	public override ECPoint Twice()
	{
		return null;
	}

	public override ECPoint TwicePlus(ECPoint b)
	{
		return null;
	}

	public override ECPoint ThreeTimes()
	{
		return null;
	}

	public override ECPoint Negate()
	{
		return null;
	}
}
