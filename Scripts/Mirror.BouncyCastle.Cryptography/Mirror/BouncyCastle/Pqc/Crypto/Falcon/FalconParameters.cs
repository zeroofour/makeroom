using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Falcon;

public sealed class FalconParameters : ICipherParameters
{
	public static readonly FalconParameters falcon_512;

	public static readonly FalconParameters falcon_1024;

	private readonly string name;

	private readonly uint logn;

	private readonly uint nonce_length;

	public int LogN => 0;

	public int NonceLength => 0;

	public string Name => null;

	private FalconParameters(string name, uint logn, uint nonce_length)
	{
	}
}
