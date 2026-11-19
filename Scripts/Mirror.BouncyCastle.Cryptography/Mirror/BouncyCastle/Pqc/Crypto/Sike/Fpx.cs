using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

internal sealed class Fpx
{
	private readonly SikeEngine engine;

	internal Fpx(SikeEngine engine)
	{
	}

	private void mp_shiftl1(ulong[] x, uint nwords)
	{
	}

	internal void sqr_Fp2_cycl(ulong[][] a, ulong[] one)
	{
	}

	internal void mont_n_way_inv(ulong[][][] vec, uint n, ulong[][][] output)
	{
	}

	internal void fpcopy(ulong[] a, long aOffset, ulong[] c)
	{
	}

	internal void mp2_add(ulong[][] a, ulong[][] b, ulong[][] c)
	{
	}

	internal void fp2correction(ulong[][] a)
	{
	}

	internal ulong mp_add(ulong[] a, ulong[] b, ulong[] c, uint nwords)
	{
		return 0uL;
	}

	private ulong mp_add(ulong[] a, uint aOffset, ulong[] b, ulong[] c, uint cOffset, uint nwords)
	{
		return 0uL;
	}

	private ulong mp_add(ulong[] a, uint aOffset, ulong[] b, uint bOffset, ulong[] c, uint cOffset, uint nwords)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ulong is_digit_lessthan_ct(ulong x, ulong y)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ulong is_digit_nonzero_ct(ulong x)
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ulong is_digit_zero_ct(ulong x)
	{
		return 0uL;
	}

	internal void fp2neg(ulong[][] a)
	{
	}

	internal bool is_felm_zero(ulong[] x)
	{
		return false;
	}

	private bool is_felm_lt(ulong[] x, ulong[] y)
	{
		return false;
	}

	private static bool is_felm_even(ulong[] x)
	{
		return false;
	}

	internal bool is_sqr_fp2(ulong[][] a, ulong[] s)
	{
		return false;
	}

	private uint fpinv_mont_bingcd_partial(ulong[] a, ulong[] x1)
	{
		return 0u;
	}

	private void power2_setup(ulong[] x, int mark, uint nwords)
	{
	}

	private void fpinv_mont_bingcd(ulong[] a)
	{
	}

	internal void fp2inv_mont_bingcd(ulong[][] a)
	{
	}

	internal void fp2div2(ulong[][] a, ulong[][] c)
	{
	}

	private void fpdiv2_PRIME(ulong[] a, ulong[] c)
	{
	}

	private void mp_subPRIME_p2(ulong[] a, ulong[] b, ulong[] c)
	{
	}

	private void mp_subPRIME_p4(ulong[] a, ulong[] b, ulong[] c)
	{
	}

	private ulong digit_x_digit(ulong a, ulong b, out ulong low)
	{
		low = default;
		return 0uL;
	}

	private void rdc_mont(ulong[] ma, ulong[] mc)
	{
	}

	internal static bool subarrayEquals(ulong[] a, ulong[] b, uint length)
	{
		return false;
	}

	internal static bool subarrayEquals(ulong[][] a, ulong[][] b, uint length)
	{
		return false;
	}

	internal static bool subarrayEquals(ulong[][] a, ulong[][] b, uint bOffset, uint length)
	{
		return false;
	}

	internal static bool subarrayEquals(ulong[][] a, ulong[] b, uint bOffset, uint length)
	{
		return false;
	}

	internal void sqrt_Fp2(ulong[][] u, ulong[][] y)
	{
	}

	internal void fp2sqr_mont(ulong[][] a, ulong[][] c)
	{
	}

	internal void fpaddPRIME(ulong[] a, ulong[] b, ulong[] c)
	{
	}

	internal void cube_Fp2_cycl(ulong[][] a, ulong[] one)
	{
	}

	internal void fpsubPRIME(ulong[] a, ulong[] b, uint bOffset, ulong[] c)
	{
	}

	internal void fpsubPRIME(ulong[] a, uint aOffset, ulong[] b, ulong[] c)
	{
	}

	internal void fpsubPRIME(ulong[] a, ulong[] b, ulong[] c)
	{
	}

	internal void fpnegPRIME(ulong[] a)
	{
	}

	internal void from_fp2mont(ulong[][] ma, ulong[][] c)
	{
	}

	internal void fp2_encode(ulong[][] x, byte[] enc, uint encOffset)
	{
	}

	internal void fp2_decode(byte[] x, ulong[][] dec, uint xOffset)
	{
	}

	internal void to_Montgomery_mod_order(ulong[] a, ulong[] mc, ulong[] order, ulong[] Montgomery_rprime, ulong[] Montgomery_Rprime)
	{
	}

	internal void Montgomery_multiply_mod_order(ulong[] ma, ulong[] mb, ulong[] mc, ulong[] order, ulong[] Montgomery_rprime)
	{
	}

	internal void inv_mod_orderA(ulong[] a, ulong[] c)
	{
	}

	internal void multiply(ulong[] a, ulong[] b, ulong[] c, uint nwords)
	{
	}

	private bool is_zero_mod_order(ulong[] x)
	{
		return false;
	}

	private bool is_even_mod_order(ulong[] x)
	{
		return false;
	}

	private bool is_lt_mod_order(ulong[] x, ulong[] y)
	{
		return false;
	}

	private bool is_zero(ulong[] a, uint nwords)
	{
		return false;
	}

	private uint Montgomery_inversion_mod_order_bingcd_partial(ulong[] a, ulong[] x1, ulong[] order)
	{
		return 0u;
	}

	internal void Montgomery_inversion_mod_order_bingcd(ulong[] a, ulong[] c, ulong[] order, ulong[] Montgomery_rprime, ulong[] Montgomery_Rprime)
	{
	}

	internal void from_Montgomery_mod_order(ulong[] ma, ulong[] c, ulong[] order, ulong[] Montgomery_rprime)
	{
	}

	internal uint mod3(ulong[] a)
	{
		return 0u;
	}

	internal void to_fp2mont(ulong[][] a, ulong[][] mc)
	{
	}

	private void to_mont(ulong[] a, ulong[] mc)
	{
	}

	internal void fpcorrectionPRIME(ulong[] a)
	{
	}

	internal byte cmp_f2elm(ulong[][] x, ulong[][] y)
	{
		return 0;
	}

	internal void encode_to_bytes(ulong[] x, byte[] enc, uint encOffset, uint nbytes)
	{
	}

	internal void decode_to_digits(byte[] x, uint xOffset, ulong[] dec, uint nbytes, uint ndigits)
	{
	}

	internal void fp2_conj(ulong[][] v, ulong[][] r)
	{
	}

	private void from_mont(ulong[] ma, ulong[] c)
	{
	}

	private void mp_shiftr1(ulong[] x)
	{
	}

	private void mp_shiftr1(ulong[] x, uint nwords)
	{
	}

	internal void fp2copy(ulong[][] a, ulong[][] c)
	{
	}

	internal void fp2copy(ulong[][] a, uint aOffset, ulong[][] c)
	{
	}

	internal void fp2copy(ulong[] a, uint aOffset, ulong[][] c)
	{
	}

	internal void fpzero(ulong[] a)
	{
	}

	internal void mp2_sub_p2(ulong[][] a, ulong[][] b, ulong[][] c)
	{
	}

	internal void mp_mul(ulong[] a, ulong[] b, ulong[] c, uint nwords)
	{
	}

	internal void mp_mul(ulong[] a, uint aOffset, ulong[] b, ulong[] c, uint nwords)
	{
	}

	internal void fp2mul_mont(ulong[][] a, ulong[][] b, ulong[][] c)
	{
	}

	internal void fp2mul_mont(ulong[][] a, ulong[][] b, uint bOffset, ulong[][] c)
	{
	}

	internal void fp2mul_mont(ulong[][] a, ulong[] b, uint bOffset, ulong[][] c)
	{
	}

	private void mp_dblsubfast(ulong[] a, ulong[] b, ulong[] c)
	{
	}

	internal ulong mp_sub(ulong[] a, ulong[] b, ulong[] c, uint nwords)
	{
		return 0uL;
	}

	internal bool is_orderelm_lt(ulong[] x, ulong[] y)
	{
		return false;
	}

	private void mp_subaddfast(ulong[] a, ulong[] b, ulong[] c)
	{
	}

	internal void fpsqr_mont(ulong[] ma, ulong[] mc)
	{
	}

	private void fpinv_mont(ulong[] a)
	{
	}

	internal void fp2inv_mont(ulong[][] a)
	{
	}

	internal void mul3(byte[] a)
	{
	}

	internal byte ct_compare(byte[] a, byte[] b, uint len)
	{
		return 0;
	}

	internal void ct_cmov(byte[] r, byte[] a, uint len, byte selector)
	{
	}

	internal void copy_words(ulong[] a, ulong[] c, uint nwords)
	{
	}

	internal void fp2shl(ulong[][] a, uint k, ulong[][] c)
	{
	}

	internal void copy_words(PointProj a, PointProj c)
	{
	}

	internal void Montgomery_neg(ulong[] a, ulong[] order)
	{
	}

	internal void fp2add(ulong[][] a, ulong[][] b, ulong[][] c)
	{
	}

	internal void fp2sub(ulong[][] a, ulong[][] b, ulong[][] c)
	{
	}

	private void mp2_sub_p4(ulong[][] a, ulong[][] b, ulong[][] c)
	{
	}

	internal void fpmul_mont(ulong[] ma, ulong[] mb, ulong[] mc)
	{
	}

	internal void fpmul_mont(ulong[] ma, uint maOffset, ulong[] mb, ulong[] mc)
	{
	}

	private void fpinv_chain_mont(ulong[] a)
	{
	}
}
