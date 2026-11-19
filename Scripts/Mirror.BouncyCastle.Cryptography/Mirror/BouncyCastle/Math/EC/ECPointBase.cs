namespace Mirror.BouncyCastle.Math.EC;

public abstract class ECPointBase : ECPoint
{
	protected internal ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: base(null, null, null)
	{
	}

	protected internal ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs)
		: base(null, null, null)
	{
	}

	public override byte[] GetEncoded(bool compressed)
	{
		return null;
	}

	public override int GetEncodedLength(bool compressed)
	{
		return 0;
	}

	public override void EncodeTo(bool compressed, byte[] buf, int off)
	{
	}

	public override ECPoint Multiply(BigInteger k)
	{
		return null;
	}
}
