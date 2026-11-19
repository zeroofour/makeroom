namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal class SIG
{
	private byte[] r;

	private SIG_FORS[] sig_fors;

	private SIG_XMSS[] sig_ht;

	public byte[] R => null;

	public SIG_FORS[] SIG_FORS => null;

	public SIG_XMSS[] SIG_HT => null;

	public SIG(int n, int k, int a, uint d, uint hPrime, int wots_len, byte[] signature)
	{
	}
}
