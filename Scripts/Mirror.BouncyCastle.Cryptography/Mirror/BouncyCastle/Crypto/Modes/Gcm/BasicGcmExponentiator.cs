using System;

namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Obsolete("Will be removed")]
public class BasicGcmExponentiator : IGcmExponentiator
{
	private GcmUtilities.FieldElement x;

	public void Init(byte[] x)
	{
	}

	public void ExponentiateX(long pow, byte[] output)
	{
	}
}
