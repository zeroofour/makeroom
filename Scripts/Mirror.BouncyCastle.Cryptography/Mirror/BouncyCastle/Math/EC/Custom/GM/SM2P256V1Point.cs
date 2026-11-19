namespace Mirror.BouncyCastle.Math.EC.Custom.GM;

internal class SM2P256V1Point : AbstractFpPoint
{
	internal SM2P256V1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: base(null, null, null)
	{
	}

	internal SM2P256V1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs)
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
