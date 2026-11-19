namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FalconKeygen
{
	private readonly FprEngine fpre;

	private readonly FalconFFT ffte;

	private readonly FalconSmallPrime[] PRIMES;

	private readonly FalconCodec codec;

	private readonly FalconVrfy vrfy;

	internal ushort[] REV10;

	internal ulong[] gauss_1024_12289;

	internal int[] MAX_BL_SMALL;

	internal int[] MAX_BL_LARGE;

	internal int[] BITLENGTH_avg;

	internal int[] BITLENGTH_std;

	internal const int DEPTH_INT_FG = 4;

	internal FalconKeygen()
	{
	}

	internal FalconKeygen(FalconCodec codec, FalconVrfy vrfy)
	{
	}

	internal uint modp_set(int x, uint p)
	{
		return 0u;
	}

	internal int modp_norm(uint x, uint p)
	{
		return 0;
	}

	internal uint modp_ninv31(uint p)
	{
		return 0u;
	}

	internal uint modp_R(uint p)
	{
		return 0u;
	}

	internal uint modp_add(uint a, uint b, uint p)
	{
		return 0u;
	}

	internal uint modp_sub(uint a, uint b, uint p)
	{
		return 0u;
	}

	internal uint modp_montymul(uint a, uint b, uint p, uint p0i)
	{
		return 0u;
	}

	internal uint modp_R2(uint p, uint p0i)
	{
		return 0u;
	}

	internal uint modp_Rx(uint x, uint p, uint p0i, uint R2)
	{
		return 0u;
	}

	internal uint modp_div(uint a, uint b, uint p, uint p0i, uint R)
	{
		return 0u;
	}

	internal void modp_mkgm2(uint[] gmsrc, int gm, uint[] igmsrc, int igm, uint logn, uint g, uint p, uint p0i)
	{
	}

	internal void modp_NTT2_ext(uint[] asrc, int a, int stride, uint[] gmsrc, int gm, uint logn, uint p, uint p0i)
	{
	}

	internal void modp_iNTT2_ext(uint[] asrc, int a, int stride, uint[] igmsrc, int igm, uint logn, uint p, uint p0i)
	{
	}

	internal void modp_NTT2(uint[] asrc, int a, uint[] gmsrc, int gm, uint logn, uint p, uint p0i)
	{
	}

	internal void modp_iNTT2(uint[] asrc, int a, uint[] igmsrc, int igm, uint logn, uint p, uint p0i)
	{
	}

	internal void modp_poly_rec_res(uint[] fsrc, int f, uint logn, uint p, uint p0i, uint R2)
	{
	}

	internal uint zint_sub(uint[] asrc, int a, uint[] bsrc, int b, int len, uint ctl)
	{
		return 0u;
	}

	internal uint zint_mul_small(uint[] msrc, int m, int mlen, uint x)
	{
		return 0u;
	}

	internal uint zint_mod_small_uint(uint[] dsrc, int d, int dlen, uint p, uint p0i, uint R2)
	{
		return 0u;
	}

	internal uint zint_mod_small_signed(uint[] dsrc, int d, int dlen, uint p, uint p0i, uint R2, uint Rx)
	{
		return 0u;
	}

	internal void zint_add_mul_small(uint[] xsrc, int x, uint[] ysrc, int y, int len, uint s)
	{
	}

	internal void zint_norm_zero(uint[] xsrc, int x, uint[] psrc, int p, int len)
	{
	}

	internal void zint_rebuild_CRT(uint[] xxsrc, int xx, int xlen, int xstride, int num, FalconSmallPrime[] primes, int normalize_signed, uint[] tmpsrc, int tmp)
	{
	}

	internal void zint_negate(uint[] asrc, int a, int len, uint ctl)
	{
	}

	internal uint zint_co_reduce(uint[] asrc, int a, uint[] bsrc, int b, int len, long xa, long xb, long ya, long yb)
	{
		return 0u;
	}

	internal void zint_finish_mod(uint[] asrc, int a, int len, uint[] msrc, int m, uint neg)
	{
	}

	internal void zint_co_reduce_mod(uint[] asrc, int a, uint[] bsrc, int b, uint[] msrc, int m, int len, uint m0i, long xa, long xb, long ya, long yb)
	{
	}

	internal int zint_bezout(uint[] usrc, int u, uint[] vsrc, int v, uint[] xsrc, int x, uint[] ysrc, int y, int len, uint[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal void zint_add_scaled_mul_small(uint[] xsrc, int x, int xlen, uint[] ysrc, int y, int ylen, int k, uint sch, uint scl)
	{
	}

	internal void zint_sub_scaled(uint[] xsrc, int x, int xlen, uint[] ysrc, int y, int ylen, uint sch, uint scl)
	{
	}

	internal int zint_one_to_plain(uint[] xsrc, int x)
	{
		return 0;
	}

	internal void poly_big_to_fp(FalconFPR[] dsrc, int d, uint[] fsrc, int f, int flen, int fstride, uint logn)
	{
	}

	internal int poly_big_to_small(sbyte[] dsrc, int d, uint[] ssrc, int s, int lim, uint logn)
	{
		return 0;
	}

	internal void poly_sub_scaled(uint[] Fsrc, int F, int Flen, int Fstride, uint[] fsrc, int f, int flen, int fstride, int[] ksrc, int k, uint sch, uint scl, uint logn)
	{
	}

	internal void poly_sub_scaled_ntt(uint[] Fsrc, int F, int Flen, int Fstride, uint[] fsrc, int f, int flen, int fstride, int[] ksrc, int k, uint sch, uint scl, uint logn, uint[] tmpsrc, int tmp)
	{
	}

	internal ulong get_rng_u64(SHAKE256 rng)
	{
		return 0uL;
	}

	internal int mkgauss(SHAKE256 rng, uint logn)
	{
		return 0;
	}

	internal uint poly_small_sqnorm(sbyte[] fsrc, int f, uint logn)
	{
		return 0u;
	}

	internal void poly_small_to_fp(FalconFPR[] xsrc, int x, sbyte[] fsrc, int f, uint logn)
	{
	}

	internal void make_fg_step(uint[] datasrc, int data, uint logn, uint depth, int in_ntt, int out_ntt)
	{
	}

	internal void make_fg(uint[] datasrc, int data, sbyte[] fsrc, int f, sbyte[] gsrc, int g, uint logn, uint depth, int out_ntt)
	{
	}

	internal int solve_NTRU_deepest(uint logn_top, sbyte[] fsrc, int f, sbyte[] gsrc, int g, uint[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int solve_NTRU_intermediate(uint logn_top, sbyte[] fsrc, int f, sbyte[] gsrc, int g, uint depth, uint[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int solve_NTRU_binary_depth1(uint logn_top, sbyte[] fsrc, int f, sbyte[] gsrc, int g, uint[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int solve_NTRU_binary_depth0(uint logn, sbyte[] fsrc, int f, sbyte[] gsrc, int g, uint[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int solve_NTRU(uint logn, sbyte[] Fsrc, int F, sbyte[] Gsrc, int G, sbyte[] fsrc, int f, sbyte[] gsrc, int g, int lim, uint[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal void poly_small_mkgauss(SHAKE256 rng, sbyte[] fsrc, int f, uint logn)
	{
	}

	internal void keygen(SHAKE256 rng, sbyte[] fsrc, int f, sbyte[] gsrc, int g, sbyte[] Fsrc, int F, sbyte[] Gsrc, int G, ushort[] hsrc, int h, uint logn)
	{
	}
}
