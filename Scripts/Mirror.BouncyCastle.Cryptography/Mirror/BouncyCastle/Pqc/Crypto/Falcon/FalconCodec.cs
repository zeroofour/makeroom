namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FalconCodec
{
	internal byte[] max_fg_bits;

	internal byte[] max_FG_bits;

	internal byte[] max_sig_bits;

	internal FalconCodec()
	{
	}

	internal int modq_encode(byte[] outarrsrc, int outarr, int max_out_len, ushort[] xsrc, int x, uint logn)
	{
		return 0;
	}

	internal int modq_decode(ushort[] xsrc, int x, uint logn, byte[] inarrsrc, int inarr, int max_in_len)
	{
		return 0;
	}

	internal int trim_i16_encode(byte[] outarrsrc, int outarr, int max_out_len, short[] xsrc, int x, uint logn, uint bits)
	{
		return 0;
	}

	internal int trim_i16_decode(short[] xsrc, int x, uint logn, uint bits, byte[] inarrsrc, int inarr, int max_in_len)
	{
		return 0;
	}

	internal int trim_i8_encode(byte[] outarrsrc, int outarr, int max_out_len, sbyte[] xsrc, int x, uint logn, uint bits)
	{
		return 0;
	}

	internal int trim_i8_decode(sbyte[] xsrc, int x, uint logn, uint bits, byte[] inarrsrc, int inarr, int max_in_len)
	{
		return 0;
	}

	internal int comp_encode(byte[] outarrsrc, int outarr, int max_out_len, short[] xsrc, int x, uint logn)
	{
		return 0;
	}

	internal int comp_decode(short[] xsrc, int x, uint logn, byte[] inarrsrc, int inarr, int max_in_len)
	{
		return 0;
	}
}
