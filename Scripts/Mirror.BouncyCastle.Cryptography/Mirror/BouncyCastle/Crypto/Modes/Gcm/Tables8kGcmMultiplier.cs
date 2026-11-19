using System;

namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Obsolete("Will be removed")]
public class Tables8kGcmMultiplier : IGcmMultiplier
{
	private byte[] H;

	private GcmUtilities.FieldElement[][] T;

	public void Init(byte[] H)
	{
	}

	public void MultiplyH(byte[] x)
	{
	}
}
