using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
public sealed class SpriteRenderer : Renderer
{
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent;

	public Sprite sprite
	{
		set
		{
		}
	}

	public Vector2 size
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

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

	[RequiredByNativeCode]
	private void InvokeSpriteChanged()
	{
	}

	[SpecialName]
	private void get_size_Injected(out Vector2 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_size_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_color_Injected(out Color ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_color_Injected(ref Color value)
	{
	}
}
