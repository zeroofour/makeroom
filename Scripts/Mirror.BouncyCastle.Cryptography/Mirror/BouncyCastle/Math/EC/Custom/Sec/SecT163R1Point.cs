namespace Mirror.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT163R1Point : AbstractF2mPoint
{
	public override ECFieldElement YCoord => null;

	protected internal override bool CompressionYTilde => false;

	internal SecT163R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: base(null, null, null)
	{
	}

	internal SecT163R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs)
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

	public override ECPoint Negate()
	{
		return null;
	}
}
