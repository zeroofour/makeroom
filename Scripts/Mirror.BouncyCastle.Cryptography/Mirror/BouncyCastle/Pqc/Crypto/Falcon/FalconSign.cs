namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FalconSign
{
	private FalconFFT ffte;

	private FprEngine fpre;

	private FalconCommon common;

	internal FalconSign(FalconCommon common)
	{
	}

	internal uint ffLDL_treesize(uint logn)
	{
		return 0u;
	}

	internal void ffLDL_fft_inner(FalconFPR[] treesrc, int tree, FalconFPR[] g0src, int g0, FalconFPR[] g1src, int g1, uint logn, FalconFPR[] tmpsrc, int tmp)
	{
	}

	internal void ffLDL_fft(FalconFPR[] treesrc, int tree, FalconFPR[] g00src, int g00, FalconFPR[] g01src, int g01, FalconFPR[] g11src, int g11, uint logn, FalconFPR[] tmpsrc, int tmp)
	{
	}

	internal void ffLDL_binary_normalize(FalconFPR[] treesrc, int tree, uint orig_logn, uint logn)
	{
	}

	internal void smallints_to_fpr(FalconFPR[] rsrc, int r, sbyte[] tsrc, int t, uint logn)
	{
	}

	private int skoff_b00(uint logn)
	{
		return 0;
	}

	private int skoff_b01(uint logn)
	{
		return 0;
	}

	private int skoff_b10(uint logn)
	{
		return 0;
	}

	private int skoff_b11(uint logn)
	{
		return 0;
	}

	private int skoff_tree(uint logn)
	{
		return 0;
	}

	internal void ffSampling_fft_dyntree(SamplerZ samp, FalconFPR[] t0src, int t0, FalconFPR[] t1src, int t1, FalconFPR[] g00src, int g00, FalconFPR[] g01src, int g01, FalconFPR[] g11src, int g11, uint orig_logn, uint logn, FalconFPR[] tmpsrc, int tmp)
	{
	}

	internal void ffSampling_fft(SamplerZ samp, FalconFPR[] z0src, int z0, FalconFPR[] z1src, int z1, FalconFPR[] treesrc, int tree, FalconFPR[] t0src, int t0, FalconFPR[] t1src, int t1, uint logn, FalconFPR[] tmpsrc, int tmp)
	{
	}

	internal int do_sign_tree(SamplerZ samp, short[] s2src, int s2, FalconFPR[] ex_keysrc, int expanded_key, ushort[] hmsrc, int hm, uint logn, FalconFPR[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int do_sign_dyn(SamplerZ samp, short[] s2src, int s2, sbyte[] fsrc, int f, sbyte[] gsrc, int g, sbyte[] Fsrc, int F, sbyte[] Gsrc, int G, ushort[] hmsrc, int hm, uint logn, FalconFPR[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal void sign_tree(short[] sigsrc, int sig, SHAKE256 rng, FalconFPR[] ex_keysrc, int expanded_key, ushort[] hmsrc, int hm, uint logn, FalconFPR[] tmpsrc, int tmp)
	{
	}

	internal void sign_dyn(short[] sigsrc, int sig, SHAKE256 rng, sbyte[] fsrc, int f, sbyte[] gsrc, int g, sbyte[] Fsrc, int F, sbyte[] Gsrc, int G, ushort[] hmsrc, int hm, uint logn, FalconFPR[] tmpsrc, int tmp)
	{
	}
}
