using System.Diagnostics;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine;

public struct RenderTextureDescriptor
{
	private GraphicsFormat _graphicsFormat = GraphicsFormat.None;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GraphicsFormat stencilFormat = GraphicsFormat.None;

	private RenderTextureCreationFlags _flags = (RenderTextureCreationFlags)0;

	public int width { get; set; } = 0;

	public int height { get; set; } = 0;

	public int msaaSamples { get; set; } = 0;

	public int volumeDepth { get; set; } = 0;

	public int mipCount { set; }

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

	public GraphicsFormat depthStencilFormat { get; set; } = GraphicsFormat.None;

	public RenderTextureFormat colorFormat
	{
		get
		{
			return RenderTextureFormat.ARGB32;
		}
		set
		{
		}
	}

	public bool sRGB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int depthBufferBits
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public TextureDimension dimension { get; set; } = TextureDimension.None;

	public ShadowSamplingMode shadowSamplingMode { get; set; } = ShadowSamplingMode.CompareDepths;

	public VRTextureUsage vrUsage { get; set; } = VRTextureUsage.None;

	public RenderTextureMemoryless memoryless { get; set; } = RenderTextureMemoryless.None;

	public bool useMipMap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool autoGenerateMips
	{
		get
		{
			return false;
		}
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

	internal bool createdFromScript
	{
		set
		{
		}
	}

	public bool useDynamicScale
	{
		set
		{
		}
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height)
	{
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat)
	{
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits)
	{
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount)
	{
	}

	public RenderTextureDescriptor(int width, int height, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat colorFormat, [DefaultValue("0")] int depthBufferBits, [DefaultValue("Texture.GenerateAllMips")] int mipCount, [DefaultValue("RenderTextureReadWrite.Linear")] RenderTextureReadWrite readWrite)
	{
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
	{
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
	{
	}

	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
	{
	}
}
