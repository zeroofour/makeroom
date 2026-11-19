namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

internal sealed class Isogeny
{
	private readonly SikeEngine engine;

	internal Isogeny(SikeEngine engine)
	{
	}

	internal void Double(PointProj P, PointProj Q, ulong[][] A24, uint k)
	{
	}

	internal void CompleteMPoint(ulong[][] A, PointProj P, PointProjFull R)
	{
	}

	internal void Ladder(PointProj P, ulong[] m, ulong[][] A, uint order_bits, PointProj R)
	{
	}

	private void XDblAddProj(PointProj P, PointProj Q, ulong[][] XPQ, ulong[][] ZPQ, ulong[][] A24)
	{
	}

	private void XDblE(PointProj P, PointProj Q, ulong[][] A24, int e)
	{
	}

	internal void XTplEFast(PointProj P, PointProj Q, ulong[][] A2, uint e)
	{
	}

	private void XTplFast(PointProj P, PointProj Q, ulong[][] A2)
	{
	}

	internal void LADDER3PT(ulong[][] xP, ulong[][] xQ, ulong[][] xPQ, ulong[] m, uint AliceOrBob, PointProj R, ulong[][] A)
	{
	}

	internal void CompletePoint(PointProj P, PointProjFull R)
	{
	}

	internal void SwapPoints(PointProj P, PointProj Q, ulong option)
	{
	}

	internal void XDblAdd(PointProj P, PointProj Q, ulong[][] xPQ, ulong[][] A24)
	{
	}

	internal void XDblE(PointProj P, PointProj Q, ulong[][] A24plus, ulong[][] C24, uint e)
	{
	}

	internal void XDbl(PointProj P, PointProj Q, ulong[][] A24plus, ulong[][] C24)
	{
	}

	private void XTpl(PointProj P, PointProj Q, ulong[][] A24minus, ulong[][] A24plus)
	{
	}

	internal void XTplE(PointProj P, PointProj Q, ulong[][] A24minus, ulong[][] A24plus, uint e)
	{
	}

	internal void GetA(ulong[][] xP, ulong[][] xQ, ulong[][] xR, ulong[][] A)
	{
	}

	internal void JInv(ulong[][] A, ulong[][] C, ulong[][] jinv)
	{
	}

	internal void Get3Isog(PointProj P, ulong[][] A24minus, ulong[][] A24plus, ulong[][][] coeff)
	{
	}

	internal void Eval3Isog(PointProj Q, ulong[][][] coeff)
	{
	}

	internal void Inv3Way(ulong[][] z1, ulong[][] z2, ulong[][] z3)
	{
	}

	internal void Get2Isog(PointProj P, ulong[][] A, ulong[][] C)
	{
	}

	internal void Eval2Isog(PointProj P, PointProj Q)
	{
	}

	internal void Get4Isog(PointProj P, ulong[][] A24plus, ulong[][] C24, ulong[][][] coeff)
	{
	}

	internal void Eval4Isog(PointProj P, ulong[][][] coeff)
	{
	}
}
