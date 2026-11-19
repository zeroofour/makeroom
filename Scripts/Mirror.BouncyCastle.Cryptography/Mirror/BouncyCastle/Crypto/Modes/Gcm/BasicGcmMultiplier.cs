using System;

namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Obsolete("Will be removed")]
public class BasicGcmMultiplier : IGcmMultiplier
{
	private GcmUtilities.FieldElement H;

	internal static bool IsHardwareAccelerated => false;

	public void Init(byte[] H)
	{
	}

	public void MultiplyH(byte[] x)
	{
	}
}
