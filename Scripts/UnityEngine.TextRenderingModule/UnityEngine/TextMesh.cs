using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/TextRendering/Public/TextMesh.h")]
[NativeClass("TextRenderingPrivate::TextMesh")]
[RequireComponent(typeof(Transform), typeof(MeshRenderer))]
public sealed class TextMesh : Component
{
	public string text
	{
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
