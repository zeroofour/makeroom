using System.IO;
using Mirror.BouncyCastle.Math;

namespace Mirror.BouncyCastle.Tls;

public sealed class ServerSrpParams
{
	private BigInteger m_N;

	private BigInteger m_g;

	private BigInteger m_B;

	private byte[] m_s;

	public BigInteger B => null;

	public BigInteger G => null;

	public BigInteger N => null;

	public byte[] S => null;

	public ServerSrpParams(BigInteger N, BigInteger g, byte[] s, BigInteger B)
	{
	}

	public void Encode(Stream output)
	{
	}

	public static ServerSrpParams Parse(Stream input)
	{
		return null;
	}
}
