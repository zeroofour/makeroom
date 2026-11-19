namespace Mirror.BouncyCastle.Crypto.Engines;

public class AesWrapEngine : Rfc3394WrapEngine
{
	public AesWrapEngine()
		: base(null)
	{
	}

	public AesWrapEngine(bool useReverseDirection)
		: base(null)
	{
	}
}
