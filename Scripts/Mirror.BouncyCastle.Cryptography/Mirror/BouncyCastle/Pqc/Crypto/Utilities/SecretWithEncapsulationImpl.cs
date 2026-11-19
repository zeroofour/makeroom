using System;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Utilities;

public class SecretWithEncapsulationImpl : ISecretWithEncapsulation, IDisposable
{
	private bool hasBeenDestroyed;

	private byte[] sessionKey;

	private byte[] cipher_text;

	public SecretWithEncapsulationImpl(byte[] sessionKey, byte[] cipher_text)
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

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public bool IsDestroyed()
	{
		return false;
	}

	private void CheckDestroyed()
	{
	}
}
