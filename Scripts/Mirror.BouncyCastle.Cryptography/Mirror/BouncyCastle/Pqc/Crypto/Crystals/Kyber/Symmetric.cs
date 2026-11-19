using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Digests;
using Mirror.BouncyCastle.Crypto.Modes;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Kyber;

public abstract class Symmetric
{
	internal class ShakeSymmetric : Symmetric
	{
		private ShakeDigest xof;

		private Sha3Digest sha3Digest512;

		private Sha3Digest sha3Digest256;

		private ShakeDigest shakeDigest;

		internal ShakeSymmetric()
			: base(0)
		{
		}

		internal override void Hash_h(byte[] output, byte[] input, int outOffset)
		{
		}

		internal override void Hash_g(byte[] output, byte[] input)
		{
		}

		internal override void XofAbsorb(byte[] seed, byte x, byte y)
		{
		}

		internal override void XofSqueezeBlocks(byte[] output, int outOffset, int outLen)
		{
		}

		internal override void Prf(byte[] output, byte[] seed, byte nonce)
		{
		}

		internal override void Kdf(byte[] output, byte[] input)
		{
		}
	}

	internal class AesSymmetric : Symmetric
	{
		private Sha256Digest sha256Digest;

		private Sha512Digest sha512Digest;

		private SicBlockCipher cipher;

		internal AesSymmetric()
			: base(0)
		{
		}

		private void DoDigest(IDigest digest, byte[] output, byte[] input, int outOffset)
		{
		}

		private void Aes128(byte[] output, int offset, int size)
		{
		}

		internal override void Hash_h(byte[] output, byte[] input, int outOffset)
		{
		}

		internal override void Hash_g(byte[] output, byte[] input)
		{
		}

		internal override void XofAbsorb(byte[] key, byte x, byte y)
		{
		}

		internal override void XofSqueezeBlocks(byte[] output, int outOffset, int outLen)
		{
		}

		internal override void Prf(byte[] output, byte[] key, byte nonce)
		{
		}

		internal override void Kdf(byte[] output, byte[] input)
		{
		}
	}

	internal readonly int XofBlockBytes;

	internal abstract void Hash_h(byte[] output, byte[] input, int outOffset);

	internal abstract void Hash_g(byte[] output, byte[] input);

	internal abstract void XofAbsorb(byte[] seed, byte x, byte y);

	internal abstract void XofSqueezeBlocks(byte[] output, int outOffset, int outLen);

	internal abstract void Prf(byte[] output, byte[] key, byte nonce);

	internal abstract void Kdf(byte[] output, byte[] input);

	private Symmetric(int xofBlockBytes)
	{
	}
}
