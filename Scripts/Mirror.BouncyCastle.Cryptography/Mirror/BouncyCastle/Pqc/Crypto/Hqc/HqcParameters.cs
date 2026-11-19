using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

public sealed class HqcParameters : ICipherParameters
{
	public static HqcParameters hqc128;

	public static HqcParameters hqc192;

	public static HqcParameters hqc256;

	private string name;

	private int n;

	private int n1;

	private int n2;

	private int k;

	private int g;

	private int delta;

	private int w;

	private int wr;

	private int we;

	private int utilRejectionThreshold;

	private int fft;

	private int[] generatorPoly;

	private int defaultKeySize;

	internal const int PARAM_M = 8;

	internal const int GF_MUL_ORDER = 255;

	private HqcEngine hqcEngine;

	public int N => 0;

	public int K => 0;

	public int Delta => 0;

	public int W => 0;

	public int Wr => 0;

	public int We => 0;

	public int N1 => 0;

	public int N2 => 0;

	public int Sha512Bytes => 0;

	public int NBytes => 0;

	public int N1n2Bytes => 0;

	public int DefaultKeySize => 0;

	public int SaltSizeBytes => 0;

	internal HqcEngine Engine => null;

	private HqcParameters(string name, int n, int n1, int n2, int k, int g, int delta, int w, int wr, int we, int utilRejectionThreshold, int fft, int[] generatorPoly, int defaultKeySize)
	{
	}
}
