namespace Mirror.BouncyCastle.Pqc.Crypto.Frodo;

public abstract class FrodoMatrixGenerator
{
	internal class Shake128MatrixGenerator : FrodoMatrixGenerator
	{
		public Shake128MatrixGenerator(int n, int q)
			: base(0, 0)
		{
		}

		internal override short[] GenMatrix(byte[] seedA)
		{
			return null;
		}
	}

	internal class Aes128MatrixGenerator : FrodoMatrixGenerator
	{
		public Aes128MatrixGenerator(int n, int q)
			: base(0, 0)
		{
		}

		internal override short[] GenMatrix(byte[] seedA)
		{
			return null;
		}
	}

	private int n;

	private int q;

	public FrodoMatrixGenerator(int n, int q)
	{
	}

	internal abstract short[] GenMatrix(byte[] seedA);
}
