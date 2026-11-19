namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

public sealed class BikePublicKeyParameters : BikeKeyParameters
{
	internal readonly byte[] m_publicKey;

	public BikePublicKeyParameters(BikeParameters param, byte[] publicKey)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
