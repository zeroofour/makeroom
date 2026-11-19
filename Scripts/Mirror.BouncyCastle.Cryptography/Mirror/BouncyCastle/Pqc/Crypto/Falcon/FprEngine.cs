namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FprEngine
{
	internal FalconFPR[] fpr_gm_tab;

	internal FalconFPR[] fpr_p2_tab;

	internal FalconFPR fpr_log2;

	internal FalconFPR fpr_inv_log2;

	internal FalconFPR fpr_bnorm_max;

	internal FalconFPR fpr_zero;

	internal FalconFPR fpr_one;

	internal FalconFPR fpr_two;

	internal FalconFPR fpr_onehalf;

	internal FalconFPR fpr_invsqrt2;

	internal FalconFPR fpr_invsqrt8;

	internal FalconFPR fpr_ptwo31;

	internal FalconFPR fpr_ptwo31m1;

	internal FalconFPR fpr_mtwo31m1;

	internal FalconFPR fpr_ptwo63m1;

	internal FalconFPR fpr_mtwo63m1;

	internal FalconFPR fpr_ptwo63;

	internal FalconFPR fpr_q;

	internal FalconFPR fpr_inverse_of_q;

	internal FalconFPR fpr_inv_2sqrsigma0;

	internal FalconFPR[] fpr_inv_sigma;

	internal FalconFPR[] fpr_sigma_min;

	internal FalconFPR Fpr(double v)
	{
		return default;
	}

	internal FalconFPR fpr_of(long i)
	{
		return default;
	}

	internal long fpr_rint(FalconFPR x)
	{
		return 0L;
	}

	internal long fpr_floor(FalconFPR x)
	{
		return 0L;
	}

	internal long fpr_trunc(FalconFPR x)
	{
		return 0L;
	}

	internal FalconFPR fpr_add(FalconFPR x, FalconFPR y)
	{
		return default;
	}

	internal FalconFPR fpr_sub(FalconFPR x, FalconFPR y)
	{
		return default;
	}

	internal FalconFPR fpr_neg(FalconFPR x)
	{
		return default;
	}

	internal FalconFPR fpr_half(FalconFPR x)
	{
		return default;
	}

	internal FalconFPR fpr_double(FalconFPR x)
	{
		return default;
	}

	internal FalconFPR fpr_mul(FalconFPR x, FalconFPR y)
	{
		return default;
	}

	internal FalconFPR fpr_sqr(FalconFPR x)
	{
		return default;
	}

	internal FalconFPR fpr_inv(FalconFPR x)
	{
		return default;
	}

	internal FalconFPR fpr_div(FalconFPR x, FalconFPR y)
	{
		return default;
	}

	internal FalconFPR fpr_sqrt(FalconFPR x)
	{
		return default;
	}

	internal bool fpr_lt(FalconFPR x, FalconFPR y)
	{
		return false;
	}

	internal ulong fpr_expm_p63(FalconFPR x, FalconFPR ccs)
	{
		return 0uL;
	}
}
