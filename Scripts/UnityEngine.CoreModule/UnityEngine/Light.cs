using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Camera/Light.h")]
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Transform))]
public sealed class Light : Behaviour
{
	private int m_BakedIndex;

	[NativeProperty("LightType")]
	public LightType type => LightType.Spot;

	public float spotAngle => 0f;

	public Color color
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float colorTemperature => 0f;

	public bool useColorTemperature => false;

	public float intensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float bounceIntensity => 0f;

	public float range
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public LightBakingOutput bakingOutput => default;

	public LightShadows shadows
	{
		[NativeMethod("GetShadowType")]
		get
		{
			return LightShadows.None;
		}
	}

	public float cookieSize => 0f;

	public Texture cookie => null;

	[SpecialName]
	private void get_color_Injected(out Color ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_color_Injected(ref Color value)
	{
	}

	[SpecialName]
	private void get_bakingOutput_Injected(out LightBakingOutput ret)
	{
		ret = default;
	}
}
