using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Digests;
using Mirror.BouncyCastle.Crypto.Modes;

namespace Mirror.BouncyCastle.Pqc.Crypto.Saber;

public abstract class Symmetric
{
	protected internal class ShakeSymmetric : Symmetric
	{
		private readonly Sha3Digest sha3Digest256;

		private readonly Sha3Digest sha3Digest512;

		private readonly IXof shakeDigest;

		internal ShakeSymmetric()
		{
		}

		internal override void Hash_h(byte[] output, byte[] input, int outputOffset)
		{
		}

		internal override void Hash_g(byte[] output, byte[] input)
		{
		}

		internal override void Prf(byte[] output, byte[] input, int inLen, int outputLen)
		{
		}
	}

	internal class AesSymmetric : Symmetric
	{
		private readonly Sha256Digest sha256Digest;

		private readonly Sha512Digest sha512Digest;

		private readonly SicBlockCipher cipher;

		protected internal AesSymmetric()
		{
		}

		internal override void Hash_h(byte[] output, byte[] input, int outputOffset)
		{
		}

		internal override void Hash_g(byte[] output, byte[] input)
		{
		}

		internal override void Prf(byte[] output, byte[] input, int inLen, int outputLen)
		{
		}
	}

	internal abstract void Hash_h(byte[] output, byte[] input, int outputOffset);

	internal abstract void Hash_g(byte[] output, byte[] input);

	internal abstract void Prf(byte[] output, byte[] input, int inLen, int outputLen);
}
