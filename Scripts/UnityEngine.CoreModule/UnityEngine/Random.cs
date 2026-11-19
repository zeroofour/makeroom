using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random
{
	public static float value
	{
		[FreeFunction]
		get
		{
			return 0f;
		}
	}

	public static Vector3 insideUnitSphere
	{
		[FreeFunction]
		get
		{
			return default;
		}
	}

	public static Vector2 insideUnitCircle => default;

	public static Vector3 onUnitSphere
	{
		[FreeFunction]
		get
		{
			return default;
		}
	}

	[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
	[NativeMethod("SetSeed")]
	public static void InitState(int seed)
	{
	}

	[FreeFunction]
	public static float Range(float minInclusive, float maxInclusive)
	{
		return 0f;
	}

	public static int Range(int minInclusive, int maxExclusive)
	{
		return 0;
	}

	[FreeFunction]
	private static int RandomRangeInt(int minInclusive, int maxExclusive)
	{
		return 0;
	}

	[FreeFunction]
	private static void GetRandomUnitCircle(out Vector2 output)
	{
		output = default;
	}

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
	{
		return default;
	}

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
	{
		return default;
	}

	[SpecialName]
	private static void get_insideUnitSphere_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private static void get_onUnitSphere_Injected(out Vector3 ret)
	{
		ret = default;
	}
}
