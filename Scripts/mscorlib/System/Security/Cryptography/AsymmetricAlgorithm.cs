using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class AsymmetricAlgorithm : IDisposable
{
	protected int KeySizeValue;

	protected KeySizes[] LegalKeySizesValue;

	public virtual int KeySize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void Dispose()
	{
	}

	public void Clear()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public virtual void FromXmlString(string xmlString)
	{
	}

	public virtual string ToXmlString(bool includePrivateParameters)
	{
		return null;
	}
}
