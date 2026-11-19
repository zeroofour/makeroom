using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Picnic;

public sealed class PicnicParameters : ICipherParameters
{
	private class L1Constants
	{
		internal static readonly LowmcConstants Instance;
	}

	private class L3Constants
	{
		internal static readonly LowmcConstants Instance;
	}

	private class L5Constants
	{
		internal static readonly LowmcConstants Instance;
	}

	public static PicnicParameters picnicl1fs;

	public static PicnicParameters picnicl1ur;

	public static PicnicParameters picnicl3fs;

	public static PicnicParameters picnicl3ur;

	public static PicnicParameters picnicl5fs;

	public static PicnicParameters picnicl5ur;

	public static PicnicParameters picnic3l1;

	public static PicnicParameters picnic3l3;

	public static PicnicParameters picnic3l5;

	public static PicnicParameters picnicl1full;

	public static PicnicParameters picnicl3full;

	public static PicnicParameters picnicl5full;

	private string name;

	private int param;

	public string Name => null;

	private PicnicParameters(string name, int param)
	{
	}

	internal PicnicEngine GetEngine()
	{
		return null;
	}
}
