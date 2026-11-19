namespace Mirror.BouncyCastle.Bcpg.Sig;

public class Features : SignatureSubpacket
{
	public static readonly byte FEATURE_MODIFICATION_DETECTION;

	public static readonly byte FEATURE_AEAD_ENCRYPTED_DATA;

	public static readonly byte FEATURE_VERSION_5_PUBLIC_KEY;

	public bool SupportsModificationDetection => false;

	private static byte[] FeatureToByteArray(byte feature)
	{
		return null;
	}

	public Features(bool critical, bool isLongLength, byte[] data)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public Features(bool critical, byte features)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public Features(bool critical, int features)
		: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
	{
	}

	public bool SupportsFeature(byte feature)
	{
		return false;
	}
}
