using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Graphics/Renderer.h")]
public class Renderer : Component
{
	public Bounds bounds
	{
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = true)]
		get
		{
			return default;
		}
	}

	public bool enabled
	{
		set
		{
		}
	}

	public ShadowCastingMode shadowCastingMode
	{
		set
		{
		}
	}

	public int sortingLayerID => 0;

	public int sortingOrder => 0;

	internal int sortingGroupID => 0;

	internal int sortingGroupOrder => 0;

	public bool isPartOfStaticBatch
	{
		[NativeName("IsPartOfStaticBatch")]
		get
		{
			return false;
		}
	}

	public Material[] materials
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material sharedMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Material[] sharedMaterials
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
	private Material GetMaterial()
	{
		return null;
	}

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
	private Material GetSharedMaterial()
	{
		return null;
	}

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
	private void SetMaterial(Material m)
	{
	}

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
	private Material[] GetMaterialArray()
	{
		return null;
	}

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
	private void SetMaterialArray([NotNull("ArgumentNullException")] Material[] m)
	{
	}

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = true)]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
	{
	}

	public void SetPropertyBlock(MaterialPropertyBlock properties)
	{
	}

	[NativeName("GetMaterialArray")]
	private Material[] GetSharedMaterialArray()
	{
		return null;
	}

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default;
	}
}
