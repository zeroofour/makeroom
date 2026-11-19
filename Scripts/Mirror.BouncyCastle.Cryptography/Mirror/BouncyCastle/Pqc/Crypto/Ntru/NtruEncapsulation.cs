using System;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Ntru;

internal sealed class NtruEncapsulation : ISecretWithEncapsulation, IDisposable
{
	private readonly byte[] _sharedKey;

	private readonly byte[] _ciphertext;

	private bool _hasBeenDestroyed;

	internal NtruEncapsulation(byte[] sharedKey, byte[] ciphertext)
	{
	}

	public void Dispose()
	{
	}

	public byte[] GetSecret()
	{
		return null;
	}

	public byte[] GetEncapsulation()
	{
		return null;
	}

	private void CheckDestroyed()
	{
	}

	public bool IsDestroyed()
	{
		return false;
	}
}
