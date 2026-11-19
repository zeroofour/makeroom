using System;
using Mirror.BouncyCastle.Crypto;

namespace Mirror.BouncyCastle.Pqc.Crypto.Lms;

public sealed class SeedDerive
{
	private readonly byte[] m_I;

	private readonly byte[] m_masterSeed;

	private readonly IDigest m_digest;

	public int J { get; set; }

	public int Q { get; set; }

	[Obsolete("Use 'GetI' instead")]
	public byte[] I => null;

	[Obsolete("Use 'GetMasterSeed' instead")]
	public byte[] MasterSeed => null;

	public SeedDerive(byte[] I, byte[] masterSeed, IDigest digest)
	{
	}

	public byte[] GetI()
	{
		return null;
	}

	public byte[] GetMasterSeed()
	{
		return null;
	}

	public byte[] DeriveSeed(bool incJ, byte[] target, int offset)
	{
		return null;
	}
}
