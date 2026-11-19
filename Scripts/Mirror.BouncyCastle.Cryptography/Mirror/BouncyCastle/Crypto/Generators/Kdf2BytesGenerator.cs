namespace Mirror.BouncyCastle.Crypto.Generators;

public sealed class Kdf2BytesGenerator : BaseKdfBytesGenerator
{
	public Kdf2BytesGenerator(IDigest digest)
		: base(0, null)
	{
	}
}
