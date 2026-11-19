using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Bcpg;

public class ECSecretBcpgKey : BcpgObject, IBcpgKey
{
	internal readonly MPInteger m_x;

	public string Format => null;

	public virtual BigInteger X => null;

	public ECSecretBcpgKey(BcpgInputStream bcpgIn)
	{
	}

	public ECSecretBcpgKey(BigInteger x)
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
