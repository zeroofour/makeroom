using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Bcpg;

public sealed class EdSecretBcpgKey : BcpgObject, IBcpgKey
{
	internal readonly MPInteger m_x;

	public string Format => null;

	public BigInteger X => null;

	public EdSecretBcpgKey(BcpgInputStream bcpgIn)
	{
	}

	public EdSecretBcpgKey(BigInteger x)
	{
	}

	public override byte[] GetEncoded()
	{
		return null;
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
	}
}
