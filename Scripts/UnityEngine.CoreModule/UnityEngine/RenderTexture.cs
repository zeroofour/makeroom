using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
public class RenderTexture : Texture
{
	public override int width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override int height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override TextureDimension dimension
	{
		get
		{
			return TextureDimension.None;
		}
		set
		{
		}
	}

	[NativeProperty("ColorFormat")]
	public GraphicsFormat graphicsFormat
	{
		get
		{
			return GraphicsFormat.None;
		}
		set
		{
		}
	}

	[NativeProperty("MipMap")]
	public bool useMipMap
	{
		set
		{
		}
	}

	public RenderTextureFormat format => RenderTextureFormat.ARGB32;

	public GraphicsFormat depthStencilFormat
	{
		set
		{
		}
	}

	public bool autoGenerateMips
	{
		set
		{
		}
	}

	public int volumeDepth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int antiAliasing
	{
		set
		{
		}
	}

	public bool enableRandomWrite
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool useDynamicScale
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static RenderTexture active
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RenderBuffer colorBuffer => default;

	public RenderBuffer depthBuffer => default;

	public RenderTextureDescriptor descriptor => default;

	[FreeFunction("RenderTexture::GetActive")]
	private static RenderTexture GetActive()
	{
		return null;
	}

	[FreeFunction("RenderTextureScripting::SetActive")]
	private static void SetActive(RenderTexture rt)
	{
	}

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = true)]
	private RenderBuffer GetColorBuffer()
	{
		return default;
	}

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = true)]
	private RenderBuffer GetDepthBuffer()
	{
		return default;
	}

	private void SetMipMapCount(int count)
	{
	}

	public bool Create()
	{
		return false;
	}

	public void Release()
	{
	}

	public bool IsCreated()
	{
		return false;
	}

	internal void SetSRGBReadWrite(bool srgb)
	{
	}

	[FreeFunction("RenderTextureScripting::Create")]
	private static void Internal_Create([Writable] RenderTexture rt)
	{
	}

	[NativeName("SetRenderTextureDescFromScript")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
	{
	}

	[NativeName("GetRenderTextureDesc")]
	private RenderTextureDescriptor GetDescriptor()
	{
		return default;
	}

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
	{
		return null;
	}

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	public static void ReleaseTemporary(RenderTexture temp)
	{
	}

	[RequiredByNativeCode]
	protected internal RenderTexture()
	{
	}

	public RenderTexture(RenderTextureDescriptor desc)
	{
	}

	public RenderTexture(RenderTexture textureToCopy)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, DefaultFormat format)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
	{
	}

	public RenderTexture(int width, int height, int depth, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
	{
	}

	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
	{
	}

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap)
	{
		return GraphicsFormat.None;
	}

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
	{
	}

	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
	{
		return GraphicsFormat.None;
	}

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc)
	{
		return null;
	}

	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false)
	{
		return null;
	}

	public static RenderTexture GetTemporary(int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing, [DefaultValue("RenderTextureMemoryless.None")] RenderTextureMemoryless memorylessMode, [DefaultValue("VRTextureUsage.None")] VRTextureUsage vrUsage, [DefaultValue("false")] bool useDynamicScale)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
	{
		return null;
	}

	private void GetColorBuffer_Injected(out RenderBuffer ret)
	{
		ret = default;
	}

	private void GetDepthBuffer_Injected(out RenderBuffer ret)
	{
		ret = default;
	}

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc)
	{
	}

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret)
	{
		ret = default;
	}

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc)
	{
		return null;
	}
}
