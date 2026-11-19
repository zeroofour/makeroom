using Mirror.BouncyCastle.Crypto;
using Mirror.BouncyCastle.Crypto.Generators;
using Mirror.BouncyCastle.Crypto.Macs;
using Mirror.BouncyCastle.Utilities;

namespace Mirror.BouncyCastle.Pqc.Crypto.SphincsPlus;

internal abstract class SphincsPlusEngine
{
	internal class Sha2Engine : SphincsPlusEngine
	{
		private HMac treeHMac;

		private Mgf1BytesGenerator mgf1;

		private byte[] hmacBuf;

		private IDigest msgDigest;

		private byte[] msgDigestBuf;

		private int bl;

		private IDigest sha256;

		private byte[] sha256Buf;

		private IMemoable msgMemo;

		private IMemoable sha256Memo;

		public Sha2Engine(bool robust, int n, uint w, uint d, int a, int k, uint h)
			: base(robust: false, 0, 0u, 0u, 0, 0, 0u)
		{
		}

		public override void Init(byte[] pkSeed)
		{
		}

		public override byte[] F(byte[] pkSeed, Adrs adrs, byte[] m1)
		{
			return null;
		}

		public override void H(byte[] pkSeed, Adrs adrs, byte[] m1, byte[] m2, byte[] output)
		{
		}

		public override IndexedDigest H_msg(byte[] prf, byte[] pkSeed, byte[] pkRoot, byte[] message)
		{
			return null;
		}

		public override void T_l(byte[] pkSeed, Adrs adrs, byte[] m, byte[] output)
		{
		}

		public override void PRF(byte[] pkSeed, byte[] skSeed, Adrs adrs, byte[] prf, int prfOff)
		{
		}

		public override byte[] PRF_msg(byte[] prf, byte[] randomiser, byte[] message)
		{
			return null;
		}

		private byte[] CompressedAdrs(Adrs adrs)
		{
			return null;
		}

		protected byte[] Bitmask(byte[] key, byte[] m)
		{
			return null;
		}

		protected byte[] Bitmask(byte[] key, byte[] m1, byte[] m2)
		{
			return null;
		}

		protected byte[] Bitmask256(byte[] key, byte[] m)
		{
			return null;
		}
	}

	internal class Shake256Engine : SphincsPlusEngine
	{
		private IXof treeDigest;

		private IXof maskDigest;

		public Shake256Engine(bool robust, int n, uint w, uint d, int a, int k, uint h)
			: base(robust: false, 0, 0u, 0u, 0, 0, 0u)
		{
		}

		public override void Init(byte[] pkSeed)
		{
		}

		public override byte[] F(byte[] pkSeed, Adrs adrs, byte[] m1)
		{
			return null;
		}

		public override void H(byte[] pkSeed, Adrs adrs, byte[] m1, byte[] m2, byte[] output)
		{
		}

		public override IndexedDigest H_msg(byte[] R, byte[] pkSeed, byte[] pkRoot, byte[] message)
		{
			return null;
		}

		public override void T_l(byte[] pkSeed, Adrs adrs, byte[] m, byte[] output)
		{
		}

		public override void PRF(byte[] pkSeed, byte[] skSeed, Adrs adrs, byte[] prf, int prfOff)
		{
		}

		public override byte[] PRF_msg(byte[] prf, byte[] randomiser, byte[] message)
		{
			return null;
		}

		protected byte[] Bitmask(byte[] pkSeed, Adrs adrs, byte[] m)
		{
			return null;
		}

		protected byte[] Bitmask(byte[] pkSeed, Adrs adrs, byte[] m1, byte[] m2)
		{
			return null;
		}
	}

	internal class HarakaSEngine : SphincsPlusEngine
	{
		public HarakaSXof harakaSXof;

		public HarakaS256Digest harakaS256Digest;

		public HarakaS512Digest harakaS512Digest;

		public HarakaSEngine(bool robust, int n, uint w, uint d, int a, int k, uint h)
			: base(robust: false, 0, 0u, 0u, 0, 0, 0u)
		{
		}

		public override void Init(byte[] pkSeed)
		{
		}

		public override byte[] F(byte[] pkSeed, Adrs adrs, byte[] m1)
		{
			return null;
		}

		public override void H(byte[] pkSeed, Adrs adrs, byte[] m1, byte[] m2, byte[] output)
		{
		}

		public override IndexedDigest H_msg(byte[] prf, byte[] pkSeed, byte[] pkRoot, byte[] message)
		{
			return null;
		}

		public override void T_l(byte[] pkSeed, Adrs adrs, byte[] m, byte[] output)
		{
		}

		public override void PRF(byte[] pkSeed, byte[] skSeed, Adrs adrs, byte[] prf, int prfOff)
		{
		}

		public override byte[] PRF_msg(byte[] prf, byte[] randomiser, byte[] message)
		{
			return null;
		}

		protected void Bitmask(Adrs adrs, byte[] m)
		{
		}
	}

	internal bool robust;

	internal int N;

	internal uint WOTS_W;

	internal int WOTS_LOGW;

	internal int WOTS_LEN;

	internal int WOTS_LEN1;

	internal int WOTS_LEN2;

	internal uint D;

	internal int A;

	internal int K;

	internal uint FH;

	internal uint H_PRIME;

	internal uint T;

	internal SphincsPlusEngine(bool robust, int n, uint w, uint d, int a, int k, uint h)
	{
	}

	public abstract void Init(byte[] pkSeed);

	public abstract byte[] F(byte[] pkSeed, Adrs adrs, byte[] m1);

	public abstract void H(byte[] pkSeed, Adrs adrs, byte[] m1, byte[] m2, byte[] output);

	public abstract IndexedDigest H_msg(byte[] prf, byte[] pkSeed, byte[] pkRoot, byte[] message);

	public abstract void T_l(byte[] pkSeed, Adrs adrs, byte[] m, byte[] output);

	public abstract void PRF(byte[] pkSeed, byte[] skSeed, Adrs adrs, byte[] prf, int prfOff);

	public abstract byte[] PRF_msg(byte[] prf, byte[] randomiser, byte[] message);
}
