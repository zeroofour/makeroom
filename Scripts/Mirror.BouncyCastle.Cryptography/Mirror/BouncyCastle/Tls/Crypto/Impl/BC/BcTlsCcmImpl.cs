using Mirror.BouncyCastle.Crypto.Modes;

namespace Mirror.BouncyCastle.Tls.Crypto.Impl.BC;

internal class BcTlsCcmImpl : BcTlsAeadCipherImpl
{
	internal BcTlsCcmImpl(CcmBlockCipher cipher, bool isEncrypting)
		: base(null, isEncrypting: false)
	{
	}

	public override int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
	{
		return 0;
	}
}
