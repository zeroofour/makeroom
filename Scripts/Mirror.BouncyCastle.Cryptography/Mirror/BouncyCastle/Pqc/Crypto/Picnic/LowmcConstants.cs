namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

internal abstract class LowmcConstants
{
	internal KMatrices _LMatrix;

	internal KMatrices _KMatrix;

	internal KMatrices RConstants;

	internal KMatrices LMatrix_full;

	internal KMatrices LMatrix_inv;

	internal KMatrices KMatrix_full;

	internal KMatrices KMatrix_inv;

	internal KMatrices RConstants_full;

	private KMatricesWithPointer GET_MAT(KMatrices m, int r)
	{
		return null;
	}

	internal KMatricesWithPointer LMatrix(PicnicEngine engine, int round)
	{
		return null;
	}

	internal KMatricesWithPointer LMatrixInv(PicnicEngine engine, int round)
	{
		return null;
	}

	internal KMatricesWithPointer KMatrix(PicnicEngine engine, int round)
	{
		return null;
	}

	internal KMatricesWithPointer KMatrixInv(PicnicEngine engine, int round)
	{
		return null;
	}

	internal KMatricesWithPointer RConstant(PicnicEngine engine, int round)
	{
		return null;
	}
}
