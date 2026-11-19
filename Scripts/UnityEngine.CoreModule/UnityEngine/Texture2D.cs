using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Texture2D.h")]
[HelpURL("Textures")]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[UsedByNativeCode]
public sealed class Texture2D : Texture
{
	internal const int streamingMipmapsPriorityMin = -128;

	internal const int streamingMipmapsPriorityMax = 127;

	public TextureFormat format
	{
		[NativeName("GetTextureFormat")]
		get
		{
			return (TextureFormat)0;
		}
	}

	[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
	public static Texture2D whiteTexture => null;

	[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
	public static Texture2D normalTexture => null;

	public override bool isReadable => false;

	[FreeFunction("Texture2DScripting::Create")]
	private static bool Internal_CreateImpl([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
	{
		return false;
	}

	private static void Internal_Create([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
	{
	}

	[NativeName("Apply")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
	{
	}

	[NativeName("Reinitialize")]
	private bool ReinitializeImpl(int width, int height)
	{
		return false;
	}

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color)
	{
	}

	[NativeName("GetPixel")]
	private Color GetPixelImpl(int image, int mip, int x, int y)
	{
		return default;
	}

	[NativeName("GetPixelBilinear")]
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v)
	{
		return default;
	}

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithFormat", HasExplicitThis = true)]
	private bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap)
	{
		return false;
	}

	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = true)]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
	{
	}

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = true, ThrowsException = true)]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame)
	{
	}

	private IntPtr GetWritableImageData(int frame)
	{
		return (IntPtr)0;
	}

	private ulong GetRawImageDataSize()
	{
		return 0uL;
	}

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = true, ThrowsException = true)]
	private void SetAllPixels32([Unmarshalled] Color32[] colors, int miplevel)
	{
	}

	[FreeFunction("Texture2DScripting::SetBlockOfPixels32", HasExplicitThis = true, ThrowsException = true)]
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, [Unmarshalled] Color32[] colors, int miplevel)
	{
	}

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = true, ThrowsException = true)]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel)
	{
		return null;
	}

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = true, ThrowsException = true)]
	public Color32[] GetPixels32([DefaultValue("0")] int miplevel)
	{
		return null;
	}

	[ExcludeFromDocs]
	public Color32[] GetPixels32()
	{
		return null;
	}

	internal bool ValidateFormat(TextureFormat format, int width, int height)
	{
		return false;
	}

	internal bool ValidateFormat(GraphicsFormat format, int width, int height)
	{
		return false;
	}

	internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags)
	{
	}

	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex)
	{
	}

	public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear)
	{
	}

	public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("true")] bool mipChain, [DefaultValue("false")] bool linear)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height)
	{
	}

	[ExcludeFromDocs]
	public void SetPixel(int x, int y, Color color)
	{
	}

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel)
	{
	}

	[ExcludeFromDocs]
	public void SetPixels(Color[] colors)
	{
	}

	[ExcludeFromDocs]
	public Color GetPixel(int x, int y)
	{
		return default;
	}

	[ExcludeFromDocs]
	public Color GetPixelBilinear(float u, float v)
	{
		return default;
	}

	public NativeArray<T> GetRawTextureData<T>() where T : struct
	{
		return default;
	}

	public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
	{
	}

	[ExcludeFromDocs]
	public void Apply()
	{
	}

	public bool Reinitialize(int width, int height)
	{
		return false;
	}

	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap)
	{
		return false;
	}

	public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
	{
	}

	[ExcludeFromDocs]
	public void ReadPixels(Rect source, int destX, int destY)
	{
	}

	public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
	{
	}

	[ExcludeFromDocs]
	public void SetPixels32(Color32[] colors)
	{
	}

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, [DefaultValue("0")] int miplevel)
	{
	}

	[ExcludeFromDocs]
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors)
	{
	}

	public Color[] GetPixels([DefaultValue("0")] int miplevel)
	{
		return null;
	}

	[ExcludeFromDocs]
	public Color[] GetPixels()
	{
		return null;
	}

	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color)
	{
	}

	private void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret)
	{
		ret = default;
	}

	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret)
	{
		ret = default;
	}

	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps)
	{
	}
}
