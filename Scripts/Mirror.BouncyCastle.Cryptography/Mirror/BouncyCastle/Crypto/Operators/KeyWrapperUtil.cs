using System.Collections.Generic;

namespace Mirror.BouncyCastle.Crypto.Operators;

internal class KeyWrapperUtil
{
	private static readonly Dictionary<string, WrapperProvider> m_providerMap;

	static KeyWrapperUtil()
	{
	}

	public static IKeyWrapper WrapperForName(string algorithm, ICipherParameters parameters)
	{
		return null;
	}

	public static IKeyUnwrapper UnwrapperForName(string algorithm, ICipherParameters parameters)
	{
		return null;
	}
}
