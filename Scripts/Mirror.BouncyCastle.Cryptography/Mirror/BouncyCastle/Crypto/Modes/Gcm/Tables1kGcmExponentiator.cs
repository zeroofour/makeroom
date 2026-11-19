using System;
using System.Collections.Generic;

namespace Mirror.BouncyCastle.Crypto.Modes.Gcm;

[Obsolete("Will be removed")]
public class Tables1kGcmExponentiator : IGcmExponentiator
{
	private IList<GcmUtilities.FieldElement> lookupPowX2;

	public void Init(byte[] x)
	{
	}

	public void ExponentiateX(long pow, byte[] output)
	{
	}

	private void EnsureAvailable(int bit)
	{
	}
}
