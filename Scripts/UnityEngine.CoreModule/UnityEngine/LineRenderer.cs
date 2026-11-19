using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/LineRenderer.h")]
public sealed class LineRenderer : Renderer
{
	public float startWidth
	{
		set
		{
		}
	}

	public float endWidth
	{
		set
		{
		}
	}

	public Color startColor
	{
		set
		{
		}
	}

	public Color endColor
	{
		set
		{
		}
	}

	[NativeProperty("PositionsCount")]
	public int positionCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void SetPosition(int index, Vector3 position)
	{
	}

	[SpecialName]
	private void set_startColor_Injected(ref Color value)
	{
	}

	[SpecialName]
	private void set_endColor_Injected(ref Color value)
	{
	}

	private void SetPosition_Injected(int index, ref Vector3 position)
	{
	}
}
