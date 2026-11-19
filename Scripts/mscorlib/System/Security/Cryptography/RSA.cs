using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class RSA : AsymmetricAlgorithm
{
	public static RSA Create()
	{
		return null;
	}

	public virtual byte[] EncryptValue(byte[] rgb)
	{
		return null;
	}

	public override void FromXmlString(string xmlString)
	{
	}

	public override string ToXmlString(bool includePrivateParameters)
	{
		return null;
	}

	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	public abstract void ImportParameters(RSAParameters parameters);
}
