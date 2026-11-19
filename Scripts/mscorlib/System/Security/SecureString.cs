namespace System.Security;

[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable
{
	private int length;

	private bool disposed;

	private byte[] data;

	public SecureString()
	{
	}

	[CLSCompliant(false)]
	public unsafe SecureString(char* value, int length)
	{
	}

	public void Dispose()
	{
	}

	private void Encrypt()
	{
	}

	private void Alloc(int length, bool realloc)
	{
	}
}
