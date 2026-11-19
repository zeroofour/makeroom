using System;
using System.Security.Cryptography;

namespace Mirror.SimpleWeb;

internal sealed class MaskHelper : IDisposable
{
	private readonly byte[] maskBuffer;

	private readonly RNGCryptoServiceProvider random;

	public void Dispose()
	{
	}

	public int WriteMask(byte[] buffer, int offset)
	{
		return 0;
	}
}
