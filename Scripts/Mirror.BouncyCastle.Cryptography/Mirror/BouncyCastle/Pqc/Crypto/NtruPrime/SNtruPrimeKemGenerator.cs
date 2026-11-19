using System;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.NtruPrime;

public class SNtruPrimeKemGenerator : IEncapsulatedSecretGenerator
{
	public class SecretWithEncapsulationImpl : ISecretWithEncapsulation, IDisposable
	{
		private bool hasBeenDestroyed;

		private byte[] sessionKey;

		private byte[] cipherText;

		public SecretWithEncapsulationImpl(byte[] sessionKey, byte[] cipherText)
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

	private SecureRandom sr;

	public SNtruPrimeKemGenerator(SecureRandom sr)
	{
	}

	public ISecretWithEncapsulation GenerateEncapsulated(AsymmetricKeyParameter recipientKey)
	{
		return null;
	}
}
