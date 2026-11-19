using System;

namespace Mirror.BouncyCastle.Asn1;

internal abstract class Asn1Type
{
	internal readonly Type m_platformType;

	internal Type PlatformType => null;

	internal Asn1Type(Type platformType)
	{
	}

	public sealed override bool Equals(object that)
	{
		return false;
	}

	public sealed override int GetHashCode()
	{
		return 0;
	}
}
