using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Graphics/TextureFormat.h")]
[NativeHeader("Runtime/Graphics/Format.h")]
public class GraphicsFormatUtility
{
	private static readonly GraphicsFormat[] tableNoStencil;

	private static readonly GraphicsFormat[] tableStencil;

	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction(IsThreadSafe = true)]
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB)
	{
		return GraphicsFormat.None;
	}

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction]
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB)
	{
		return GraphicsFormat.None;
	}

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction(IsThreadSafe = true)]
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static int GetDepthBits(GraphicsFormat format)
	{
		return 0;
	}

	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static bool IsSRGBFormat(GraphicsFormat format)
	{
		return false;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format)
	{
		return RenderTextureFormat.ARGB32;
	}

	[FreeFunction("IsAnyCompressedTextureFormat", true)]
	internal static bool IsCompressedTextureFormat(TextureFormat format)
	{
		return false;
	}

	[FreeFunction(IsThreadSafe = true)]
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage)
	{
		return false;
	}

	internal static bool CanDecompressFormat(GraphicsFormat format)
	{
		return false;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static bool HasAlphaChannel(GraphicsFormat format)
	{
		return false;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static bool IsDepthFormat(GraphicsFormat format)
	{
		return false;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static bool IsStencilFormat(GraphicsFormat format)
	{
		return false;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static bool IsPVRTCFormat(GraphicsFormat format)
	{
		return false;
	}

	public static bool IsCrunchFormat(TextureFormat format)
	{
		return false;
	}
}
