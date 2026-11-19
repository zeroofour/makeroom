using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[ExcludeFromPreset]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
public sealed class Sprite : Object
{
	public Bounds bounds => default;

	public Rect rect => default;

	public Vector4 border => default;

	public Texture2D texture => null;

	public float pixelsPerUnit
	{
		[NativeMethod("GetPixelsToUnits")]
		get
		{
			return 0f;
		}
	}

	public Texture2D associatedAlphaSplitTexture
	{
		[NativeMethod("GetAlphaTexture")]
		get
		{
			return null;
		}
	}

	public Vector2 pivot
	{
		[NativeMethod("GetPivotInPixels")]
		get
		{
			return default;
		}
	}

	public bool packed => false;

	public SpritePackingMode packingMode => SpritePackingMode.Tight;

	public SpritePackingRotation packingRotation => SpritePackingRotation.None;

	public Rect textureRect => default;

	public Vector2[] vertices
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public ushort[] triangles
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public Vector2[] uv
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	[RequiredByNativeCode]
	private Sprite()
	{
	}

	internal int GetPackingMode()
	{
		return 0;
	}

	internal int GetPackingRotation()
	{
		return 0;
	}

	internal int GetPacked()
	{
		return 0;
	}

	internal Rect GetTextureRect()
	{
		return default;
	}

	internal Vector4 GetInnerUVs()
	{
		return default;
	}

	internal Vector4 GetOuterUVs()
	{
		return default;
	}

	internal Vector4 GetPadding()
	{
		return default;
	}

	[FreeFunction("SpritesBindings::CreateSprite")]
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
	{
		return null;
	}

	private void GetTextureRect_Injected(out Rect ret)
	{
		ret = default;
	}

	private void GetInnerUVs_Injected(out Vector4 ret)
	{
		ret = default;
	}

	private void GetOuterUVs_Injected(out Vector4 ret)
	{
		ret = default;
	}

	private void GetPadding_Injected(out Vector4 ret)
	{
		ret = default;
	}

	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape)
	{
		return null;
	}

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default;
	}

	[SpecialName]
	private void get_rect_Injected(out Rect ret)
	{
		ret = default;
	}

	[SpecialName]
	private void get_border_Injected(out Vector4 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void get_pivot_Injected(out Vector2 ret)
	{
		ret = default;
	}
}
