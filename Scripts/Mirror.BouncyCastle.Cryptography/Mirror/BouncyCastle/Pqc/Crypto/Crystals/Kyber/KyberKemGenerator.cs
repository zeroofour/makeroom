using System;
using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

public sealed class KyberKemGenerator : IEncapsulatedSecretGenerator
{
	private sealed class SecretWithEncapsulationImpl : ISecretWithEncapsulation, IDisposable
	{
		private bool m_hasBeenDestroyed;

		private byte[] m_sessionKey;

		private byte[] m_cipherText;

		internal SecretWithEncapsulationImpl(byte[] sessionKey, byte[] cipher_text)
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

		internal bool IsDestroyed()
		{
			return false;
		}

		private void CheckDestroyed()
		{
		}
	}

	private SecureRandom m_random;

	public KyberKemGenerator(SecureRandom random)
	{
	}

	public ISecretWithEncapsulation GenerateEncapsulated(AsymmetricKeyParameter recipientKey)
	{
		return null;
	}
}
