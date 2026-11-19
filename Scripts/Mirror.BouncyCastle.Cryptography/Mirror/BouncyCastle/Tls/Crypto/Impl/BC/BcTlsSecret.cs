using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsSecret : AbstractTlsSecret
{
	private static readonly byte[] Ssl3Const;

	protected readonly BcTlsCrypto m_crypto;

	protected override AbstractTlsCrypto Crypto => null;

	public static BcTlsSecret Convert(BcTlsCrypto crypto, TlsSecret secret)
	{
		return null;
	}

	private static byte[] GenerateSsl3Constants()
	{
		return null;
	}

	public BcTlsSecret(BcTlsCrypto crypto, byte[] data)
		: base(null)
	{
	}

	public override TlsSecret DeriveUsingPrf(int prfAlgorithm, string label, byte[] seed, int length)
	{
		return null;
	}

	public override TlsSecret HkdfExpand(int cryptoHashAlgorithm, byte[] info, int length)
	{
		return null;
	}

	public override TlsSecret HkdfExtract(int cryptoHashAlgorithm, TlsSecret ikm)
	{
		return null;
	}

	protected virtual void HmacHash(int cryptoHashAlgorithm, byte[] secret, int secretOff, int secretLen, byte[] seed, byte[] output)
	{
	}

	protected virtual byte[] Prf(int prfAlgorithm, string label, byte[] seed, int length)
	{
		return null;
	}

	protected virtual byte[] Prf_Ssl(byte[] seed, int length)
	{
		return null;
	}

	protected virtual byte[] Prf_1_0(byte[] labelSeed, int length)
	{
		return null;
	}

	protected virtual byte[] Prf_1_2(int prfAlgorithm, byte[] labelSeed, int length)
	{
		return null;
	}

	protected virtual void UpdateMac(IMac mac)
	{
	}
}
