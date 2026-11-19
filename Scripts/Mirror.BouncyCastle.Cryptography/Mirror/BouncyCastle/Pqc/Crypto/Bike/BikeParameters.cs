using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

public sealed class BikeParameters : ICipherParameters
{
	public static BikeParameters bike128;

	public static BikeParameters bike192;

	public static BikeParameters bike256;

	private readonly string name;

	private readonly int r;

	private readonly int w;

	private readonly int t;

	private readonly int l;

	private readonly int nbIter;

	private readonly int tau;

	private readonly int defaultKeySize;

	private readonly BikeEngine bikeEngine;

	public int R => 0;

	public int RByte => 0;

	public int LByte => 0;

	public int W => 0;

	public int T => 0;

	public int L => 0;

	public int NbIter => 0;

	public int Tau => 0;

	public string Name => null;

	public int DefaultKeySize => 0;

	internal BikeEngine BikeEngine => null;

	private BikeParameters(string name, int r, int w, int t, int l, int nbIter, int tau, int defaultKeySize)
	{
	}
}
