using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto;

public class CipherKeyGenerator
{
	protected internal SecureRandom random;

	protected internal int strength;

	private bool uninitialised;

	private int defaultStrength;

	public int DefaultStrength => 0;

	public CipherKeyGenerator()
	{
	}

	internal CipherKeyGenerator(int defaultStrength)
	{
	}

	public void Init(KeyGenerationParameters parameters)
	{
	}

	protected virtual void EngineInit(KeyGenerationParameters parameters)
	{
	}

	public byte[] GenerateKey()
	{
		return null;
	}

	public KeyParameter GenerateKeyParameter()
	{
		return null;
	}

	protected virtual byte[] EngineGenerateKey()
	{
		return null;
	}

	protected virtual KeyParameter EngineGenerateKeyParameter()
	{
		return null;
	}

	protected virtual void EnsureInitialized()
	{
	}
}
