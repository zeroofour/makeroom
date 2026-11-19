using System;

namespace UnityEngine.Rendering;

public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
{
	public const int AllDepthSlices = -1;

	private BuiltinRenderTextureType m_Type = BuiltinRenderTextureType.None;

	private int m_NameID = 0;

	private int m_InstanceID = 0;

	private IntPtr m_BufferPointer = (IntPtr)0;

	private int m_MipLevel = 0;

	private CubemapFace m_CubeFace = CubemapFace.PositiveX;

	private int m_DepthSlice = 0;

	public RenderTargetIdentifier(BuiltinRenderTextureType type)
	{
	}

	public RenderTargetIdentifier(int nameID)
	{
	}

	public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
	}

	public RenderTargetIdentifier(Texture tex)
	{
	}

	public RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
	}

	public static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
	{
		return default;
	}

	public static implicit operator RenderTargetIdentifier(int nameID)
	{
		return default;
	}

	public static implicit operator RenderTargetIdentifier(Texture tex)
	{
		return default;
	}

	public static implicit operator RenderTargetIdentifier(RenderBuffer buf)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool Equals(RenderTargetIdentifier rhs)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
