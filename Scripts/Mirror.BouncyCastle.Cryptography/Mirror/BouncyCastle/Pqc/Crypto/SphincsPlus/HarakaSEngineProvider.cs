namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal sealed class HarakaSEngineProvider : ISphincsPlusEngineProvider
{
	private readonly bool robust;

	private readonly int n;

	private readonly uint w;

	private readonly uint d;

	private readonly int a;

	private readonly int k;

	private readonly uint h;

	public int N => 0;

	public HarakaSEngineProvider(bool robust, int n, uint w, uint d, int a, int k, uint h)
	{
	}

	public SphincsPlusEngine Get()
	{
		return null;
	}
}
