using System;
using System.IO;
using Mirror.BouncyCastle.Utilities;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class LMOtsSignature : IEncodable
{
	private readonly LMOtsParameters m_paramType;

	private readonly byte[] m_C;

	private readonly byte[] m_y;

	public LMOtsParameters ParamType => null;

	[Obsolete("Use 'GetC' instead")]
	public byte[] C => null;

	[Obsolete("Use 'GetY' instead")]
	public byte[] Y => null;

	public LMOtsSignature(LMOtsParameters paramType, byte[] c, byte[] y)
	{
	}

	public static LMOtsSignature GetInstance(object src)
	{
		return null;
	}

	internal static LMOtsSignature Parse(BinaryReader binaryReader)
	{
		return null;
	}

	public byte[] GetC()
	{
		return null;
	}

	public byte[] GetY()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public byte[] GetEncoded()
	{
		return null;
	}
}
