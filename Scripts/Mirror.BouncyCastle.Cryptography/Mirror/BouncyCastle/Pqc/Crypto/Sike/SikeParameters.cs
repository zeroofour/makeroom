using System;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

[Obsolete("Will be removed")]
public sealed class SikeParameters
{
	private class SikeP434Engine
	{
		internal static readonly SikeEngine Instance;
	}

	private class SikeP503Engine
	{
		internal static readonly SikeEngine Instance;
	}

	private class SikeP610Engine
	{
		internal static readonly SikeEngine Instance;
	}

	private class SikeP751Engine
	{
		internal static readonly SikeEngine Instance;
	}

	private class SikeP434CompressedEngine
	{
		internal static readonly SikeEngine Instance;
	}

	private class SikeP503CompressedEngine
	{
		internal static readonly SikeEngine Instance;
	}

	private class SikeP610CompressedEngine
	{
		internal static readonly SikeEngine Instance;
	}

	private class SikeP751CompressedEngine
	{
		internal static readonly SikeEngine Instance;
	}

	public static readonly SikeParameters sikep434;

	public static readonly SikeParameters sikep503;

	public static readonly SikeParameters sikep610;

	public static readonly SikeParameters sikep751;

	public static readonly SikeParameters sikep434_compressed;

	public static readonly SikeParameters sikep503_compressed;

	public static readonly SikeParameters sikep610_compressed;

	public static readonly SikeParameters sikep751_compressed;

	private readonly int ver;

	private readonly bool isCompressed;

	private readonly string name;

	public string Name => null;

	public int DefaultKeySize => 0;

	private SikeParameters(int ver, bool isCompressed, string name)
	{
	}

	internal SikeEngine GetEngine()
	{
		return null;
	}
}
