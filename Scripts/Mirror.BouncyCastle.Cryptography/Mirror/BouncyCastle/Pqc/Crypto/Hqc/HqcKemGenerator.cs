using System;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Hqc;

public class HqcKemGenerator : IEncapsulatedSecretGenerator
{
	private sealed class SecretWithEncapsulationImpl : ISecretWithEncapsulation, IDisposable
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

		public bool IsDestroyed()
		{
			return false;
		}

		private void CheckDestroyed()
		{
		}
	}

	private SecureRandom sr;

	public HqcKemGenerator(SecureRandom random)
	{
	}

	public ISecretWithEncapsulation GenerateEncapsulated(AsymmetricKeyParameter recipientKey)
	{
		return null;
	}
}
