using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public sealed class SNtruPrimeParameters : ICipherParameters
{
	private string name;

	private int p;

	private int q;

	private int _roundedBytes;

	private bool m_LPR;

	private int _w;

	private int _rqBytes;

	private int _tau0;

	private int _tau1;

	private int _tau2;

	private int _tau3;

	private int _skBytes;

	private int _pkBytes;

	private int _ctBytes;

	private int _defaultKeySize;

	private NtruPrimeEngine _primeEngine;

	public static SNtruPrimeParameters sntrup653;

	public static SNtruPrimeParameters sntrup761;

	public static SNtruPrimeParameters sntrup857;

	public static SNtruPrimeParameters sntrup953;

	public static SNtruPrimeParameters sntrup1013;

	public static SNtruPrimeParameters sntrup1277;

	public int P => 0;

	public bool LPR => false;

	public int Q => 0;

	public int DefaultKeySize => 0;

	internal NtruPrimeEngine PrimeEngine => null;

	private SNtruPrimeParameters(string name, int p, int q, bool LPR, int w, int tau0, int tau1, int tau2, int tau3, int skBytes, int pkBytes, int ctBytes, int roundedBytes, int rqBytes, int defaultKeySize)
	{
	}
}
