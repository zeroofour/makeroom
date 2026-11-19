namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FalconFFT
{
	private FprEngine fpre;

	internal FalconFFT()
	{
	}

	internal FalconFFT(FprEngine fprengine)
	{
	}

	internal FalconFPR[] FPC_ADD(FalconFPR a_re, FalconFPR a_im, FalconFPR b_re, FalconFPR b_im)
	{
		return null;
	}

	internal FalconFPR[] FPC_SUB(FalconFPR a_re, FalconFPR a_im, FalconFPR b_re, FalconFPR b_im)
	{
		return null;
	}

	internal FalconFPR[] FPC_MUL(FalconFPR a_re, FalconFPR a_im, FalconFPR b_re, FalconFPR b_im)
	{
		return null;
	}

	internal FalconFPR[] FPC_SQR(FalconFPR d_re, FalconFPR d_im, FalconFPR a_re, FalconFPR a_im)
	{
		return null;
	}

	internal FalconFPR[] FPC_INV(FalconFPR a_re, FalconFPR a_im)
	{
		return null;
	}

	internal FalconFPR[] FPC_DIV(FalconFPR a_re, FalconFPR a_im, FalconFPR b_re, FalconFPR b_im)
	{
		return null;
	}

	internal void FFT(FalconFPR[] fsrc, int f, uint logn)
	{
	}

	internal void iFFT(FalconFPR[] fsrc, int f, uint logn)
	{
	}

	internal void poly_add(FalconFPR[] asrc, int a, FalconFPR[] bsrc, int b, uint logn)
	{
	}

	internal void poly_sub(FalconFPR[] asrc, int a, FalconFPR[] bsrc, int b, uint logn)
	{
	}

	internal void poly_neg(FalconFPR[] asrc, int a, uint logn)
	{
	}

	internal void poly_adj_fft(FalconFPR[] asrc, int a, uint logn)
	{
	}

	internal void poly_mul_fft(FalconFPR[] asrc, int a, FalconFPR[] bsrc, int b, uint logn)
	{
	}

	internal void poly_muladj_fft(FalconFPR[] asrc, int a, FalconFPR[] bsrc, int b, uint logn)
	{
	}

	internal void poly_mulselfadj_fft(FalconFPR[] asrc, int a, uint logn)
	{
	}

	internal void poly_mulconst(FalconFPR[] asrc, int a, FalconFPR x, uint logn)
	{
	}

	internal void poly_div_fft(FalconFPR[] asrc, int a, FalconFPR[] bsrc, int b, uint logn)
	{
	}

	internal void poly_invnorm2_fft(FalconFPR[] dsrc, int d, FalconFPR[] asrc, int a, FalconFPR[] bsrc, int b, uint logn)
	{
	}

	internal void poly_add_muladj_fft(FalconFPR[] dsrc, int d, FalconFPR[] Fsrc, int F, FalconFPR[] Gsrc, int G, FalconFPR[] fsrc, int f, FalconFPR[] gsrc, int g, uint logn)
	{
	}

	internal void poly_mul_autoadj_fft(FalconFPR[] asrc, int a, FalconFPR[] bsrc, int b, uint logn)
	{
	}

	internal void poly_div_autoadj_fft(FalconFPR[] asrc, int a, FalconFPR[] bsrc, int b, uint logn)
	{
	}

	internal void poly_LDL_fft(FalconFPR[] g00src, int g00, FalconFPR[] g01src, int g01, FalconFPR[] g11src, int g11, uint logn)
	{
	}

	internal void poly_LDLmv_fft(FalconFPR[] d11src, int d11, FalconFPR[] l10src, int l10, FalconFPR[] g00src, int g00, FalconFPR[] g01src, int g01, FalconFPR[] g11src, int g11, uint logn)
	{
	}

	internal void poly_split_fft(FalconFPR[] f0src, int f0, FalconFPR[] f1src, int f1, FalconFPR[] fsrc, int f, uint logn)
	{
	}

	internal void poly_merge_fft(FalconFPR[] fsrc, int f, FalconFPR[] f0src, int f0, FalconFPR[] f1src, int f1, uint logn)
	{
	}
}
