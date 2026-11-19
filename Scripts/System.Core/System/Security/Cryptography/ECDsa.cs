namespace System.Security.Cryptography;

public abstract class ECDsa : AsymmetricAlgorithm
{
	public virtual ECParameters ExportParameters(bool includePrivateParameters)
	{
		return default;
	}
}
