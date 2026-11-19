using Mirror.BouncyCastle.Crypto.Digests;
using Mirror.BouncyCastle.Crypto.Modes;

namespace Mirror.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;

public abstract class Symmetric
{
	internal class AesSymmetric : Symmetric
	{
		private SicBlockCipher cipher;

		public AesSymmetric()
			: base(0, 0)
		{
		}

		private void Aes128(byte[] output, int offset, int size)
		{
		}

		private void StreamInit(byte[] key, ushort nonce)
		{
		}

		internal override void Stream128Init(byte[] seed, ushort nonce)
		{
		}

		internal override void Stream256Init(byte[] seed, ushort nonce)
		{
		}

		internal override void Stream128SqueezeBlocks(byte[] output, int offset, int size)
		{
		}

		internal override void Stream256SqueezeBlocks(byte[] output, int offset, int size)
		{
		}
	}

	internal class ShakeSymmetric : Symmetric
	{
		private ShakeDigest digest128;

		private ShakeDigest digest256;

		public ShakeSymmetric()
			: base(0, 0)
		{
		}

		private void StreamInit(ShakeDigest digest, byte[] seed, ushort nonce)
		{
		}

		internal override void Stream128Init(byte[] seed, ushort nonce)
		{
		}

		internal override void Stream256Init(byte[] seed, ushort nonce)
		{
		}

		internal override void Stream128SqueezeBlocks(byte[] output, int offset, int size)
		{
		}

		internal override void Stream256SqueezeBlocks(byte[] output, int offset, int size)
		{
		}
	}

	public int Stream128BlockBytes;

	public int Stream256BlockBytes;

	private Symmetric(int stream128, int stream256)
	{
	}

	internal abstract void Stream128Init(byte[] seed, ushort nonce);

	internal abstract void Stream256Init(byte[] seed, ushort nonce);

	internal abstract void Stream128SqueezeBlocks(byte[] output, int offset, int size);

	internal abstract void Stream256SqueezeBlocks(byte[] output, int offset, int size);
}
