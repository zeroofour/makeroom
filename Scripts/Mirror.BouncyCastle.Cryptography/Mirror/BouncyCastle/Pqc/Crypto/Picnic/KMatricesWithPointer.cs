namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

internal class KMatricesWithPointer : KMatrices
{
	private int matrixPointer;

	internal int GetMatrixPointer()
	{
		return 0;
	}

	internal void SetMatrixPointer(int matrixPointer)
	{
	}

	internal KMatricesWithPointer(KMatrices m)
		: base(0, 0, 0, null)
	{
	}
}
