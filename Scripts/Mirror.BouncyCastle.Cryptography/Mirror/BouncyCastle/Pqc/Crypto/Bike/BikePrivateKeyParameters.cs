namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

public sealed class BikePrivateKeyParameters : BikeKeyParameters
{
	internal readonly byte[] m_h0;

	internal readonly byte[] m_h1;

	internal readonly byte[] m_sigma;

	public BikePrivateKeyParameters(BikeParameters bikeParameters, byte[] h0, byte[] h1, byte[] sigma)
		: base(isPrivate: false, null)
	{
	}

	public byte[] GetEncoded()
	{
		return null;
	}

	public byte[] GetH0()
	{
		return null;
	}

	public byte[] GetH1()
	{
		return null;
	}

	public byte[] GetSigma()
	{
		return null;
	}
}
