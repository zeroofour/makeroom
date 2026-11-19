using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType.Dot)]
public class Time
{
	[NativeProperty("CurTime")]
	public static float time => 0f;

	public static float deltaTime => 0f;

	public static float unscaledTime => 0f;

	[NativeProperty("UnscaledTime")]
	public static double unscaledTimeAsDouble => 0.0;

	public static float fixedUnscaledTime => 0f;

	public static float unscaledDeltaTime => 0f;

	public static float fixedDeltaTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static int frameCount => 0;

	[NativeProperty("RenderFrameCount")]
	public static int renderedFrameCount => 0;

	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup => 0f;
}
