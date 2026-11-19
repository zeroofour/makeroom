using System;

namespace Mirror.BouncyCastle.Utilities;

public static class Objects
{
	public static int GetHashCode(object obj)
	{
		return 0;
	}

	internal static TValue EnsureSingletonInitialized<TValue, TArg>(ref TValue value, TArg arg, Func<TArg, TValue> initialize) where TValue : class
	{
		return null;
	}
}
