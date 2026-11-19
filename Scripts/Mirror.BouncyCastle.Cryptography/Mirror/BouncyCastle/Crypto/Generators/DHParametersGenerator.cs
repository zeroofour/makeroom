using Mirror.BouncyCastle.Crypto.Parameters;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Generators;

public class DHParametersGenerator
{
	private int size;

	private int certainty;

	private SecureRandom random;

	public virtual void Init(int size, int certainty, SecureRandom random)
	{
	}

	public virtual DHParameters GenerateParameters()
	{
		return null;
	}
}
