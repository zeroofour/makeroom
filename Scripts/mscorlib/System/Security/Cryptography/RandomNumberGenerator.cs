using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public abstract class RandomNumberGenerator : IDisposable
{
	public static RandomNumberGenerator Create()
	{
		return null;
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public abstract void GetBytes(byte[] data);

	public virtual void GetBytes(byte[] data, int offset, int count)
	{
	}
}
