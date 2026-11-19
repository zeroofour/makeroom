namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FalconVrfy
{
	private FalconCommon common;

	private const int Q = 12289;

	private const int Q0I = 12287;

	private const int R = 4091;

	private const int R2 = 10952;

	internal ushort[] GMb;

	internal ushort[] iGMb;

	internal FalconVrfy()
	{
	}

	internal FalconVrfy(FalconCommon common)
	{
	}

	internal uint mq_conv_small(int x)
	{
		return 0u;
	}

	internal uint mq_add(uint x, uint y)
	{
		return 0u;
	}

	internal uint mq_sub(uint x, uint y)
	{
		return 0u;
	}

	internal uint mq_rshift1(uint x)
	{
		return 0u;
	}

	internal uint mq_montymul(uint x, uint y)
	{
		return 0u;
	}

	internal uint mq_montysqr(uint x)
	{
		return 0u;
	}

	internal uint mq_div_12289(uint x, uint y)
	{
		return 0u;
	}

	internal void mq_NTT(ushort[] asrc, int a, uint logn)
	{
	}

	internal void mq_iNTT(ushort[] asrc, int a, uint logn)
	{
	}

	internal void mq_poly_tomonty(ushort[] fsrc, int f, uint logn)
	{
	}

	internal void mq_poly_montymul_ntt(ushort[] fsrc, int f, ushort[] gsrc, int g, uint logn)
	{
	}

	internal void mq_poly_sub(ushort[] fsrc, int f, ushort[] gsrc, int g, uint logn)
	{
	}

	internal void to_ntt_monty(ushort[] hsrc, int h, uint logn)
	{
	}

	internal bool verify_raw(ushort[] c0src, int c0, short[] s2src, int s2, ushort[] hsrc, int h, uint logn, ushort[] tmpsrc, int tmp)
	{
		return false;
	}

	internal int compute_public(ushort[] hsrc, int h, sbyte[] fsrc, int f, sbyte[] gsrc, int g, uint logn, ushort[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int complete_private(sbyte[] Gsrc, int G, sbyte[] fsrc, int f, sbyte[] gsrc, int g, sbyte[] Fsrc, int F, uint logn, ushort[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int is_invertible(short[] s2src, int s2, uint logn, ushort[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int verify_recover(ushort[] hsrc, int h, ushort[] c0src, int c0, short[] s1src, int s1, short[] s2src, int s2, uint logn, ushort[] tmpsrc, int tmp)
	{
		return 0;
	}

	internal int count_nttzero(short[] sigsrc, int sig, uint logn, ushort[] tmpsrc, int tmp)
	{
		return 0;
	}
}
