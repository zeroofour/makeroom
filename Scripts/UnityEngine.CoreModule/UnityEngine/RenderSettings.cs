using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Camera/RenderSettings.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
public sealed class RenderSettings : Object
{
	[NativeProperty("UseFog")]
	public static bool fog => false;

	[NativeProperty("LinearFogStart")]
	public static float fogStartDistance => 0f;

	[NativeProperty("LinearFogEnd")]
	public static float fogEndDistance => 0f;

	public static FogMode fogMode => (FogMode)0;

	public static Color fogColor => default;

	public static float fogDensity => 0f;

	[NativeProperty("SkyboxMaterial")]
	public static Material skybox => null;

	public static Light sun => null;

	[SpecialName]
	private static void get_fogColor_Injected(out Color ret)
	{
		ret = default;
	}
}
