namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

internal class FalconCommon
{
	internal uint[] l2bound;

	internal void hash_to_point_vartime(SHAKE256 sc, ushort[] xsrc, int x, uint logn)
	{
	}

	internal bool is_short(short[] s1src, int s1, short[] s2src, int s2, uint logn)
	{
		return false;
	}

	internal bool is_short_half(uint sqn, short[] s2src, int s2, uint logn)
	{
		return false;
	}
}
