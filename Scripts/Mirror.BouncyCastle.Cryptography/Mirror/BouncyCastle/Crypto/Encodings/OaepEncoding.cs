using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Crypto.Encodings;

public class OaepEncoding : IAsymmetricBlockCipher
{
	private readonly IAsymmetricBlockCipher engine;

	private readonly IDigest mgf1Hash;

	private readonly int mgf1NoMemoLimit;

	private readonly byte[] defHash;

	private SecureRandom random;

	private bool forEncryption;

	public string AlgorithmName => null;

	public IAsymmetricBlockCipher UnderlyingCipher => null;

	private static int GetMgf1NoMemoLimit(IDigest d)
	{
		return 0;
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash, byte[] encodingParams)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash, IDigest mgf1Hash, byte[] encodingParams)
	{
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
	}

	public int GetInputBlockSize()
	{
		return 0;
	}

	public int GetOutputBlockSize()
	{
		return 0;
	}

	public byte[] ProcessBlock(byte[] inBytes, int inOff, int inLen)
	{
		return null;
	}

	private byte[] EncodeBlock(byte[] inBytes, int inOff, int inLen)
	{
		return null;
	}

	private byte[] DecodeBlock(byte[] inBytes, int inOff, int inLen)
	{
		return null;
	}

	private void MaskGeneratorFunction(byte[] z, int zOff, int zLen, byte[] mask, int maskOff, int maskLen)
	{
	}

	private void MaskGeneratorFunction1(byte[] z, int zOff, int zLen, byte[] mask, int maskOff, int maskLen)
	{
	}
}
