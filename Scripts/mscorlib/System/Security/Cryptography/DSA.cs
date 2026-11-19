using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class DSA : AsymmetricAlgorithm
{
	public static DSA Create()
	{
		return null;
	}

	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	public override void FromXmlString(string xmlString)
	{
	}

	public override string ToXmlString(bool includePrivateParameters)
	{
		return null;
	}

	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	public abstract void ImportParameters(DSAParameters parameters);
}
