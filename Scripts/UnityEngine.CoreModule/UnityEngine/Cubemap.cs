using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
[ExcludeFromPreset]
public sealed class Cubemap : Texture
{
	public override bool isReadable => false;

	[FreeFunction("CubemapScripting::Create")]
	private static bool Internal_CreateImpl([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
	{
		return false;
	}

	private static void Internal_Create([Writable] Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
	{
	}

	internal bool ValidateFormat(TextureFormat format, int width)
	{
		return false;
	}

	internal bool ValidateFormat(GraphicsFormat format, int width)
	{
		return false;
	}

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags)
	{
	}

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags)
	{
	}

	public Cubemap(int width, TextureFormat format, int mipCount)
	{
	}

	[ExcludeFromDocs]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount)
	{
	}

	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
	{
	}

	internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
	{
	}

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain)
	{
	}

	private static void ValidateIsNotCrunched(TextureCreationFlags flags)
	{
	}
}
