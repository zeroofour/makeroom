namespace Mirror.BouncyCastle.Crypto.Generators;

public class Poly1305KeyGenerator : CipherKeyGenerator
{
	private const byte R_MASK_LOW_2 = 252;

	private const byte R_MASK_HIGH_4 = 15;

	protected override void EngineInit(KeyGenerationParameters param)
	{
	}

	protected override byte[] EngineGenerateKey()
	{
		return null;
	}

	public static void Clamp(byte[] key)
	{
	}

	public static void CheckKey(byte[] key)
	{
	}

	private static void CheckMask(byte b, byte mask)
	{
	}
}
