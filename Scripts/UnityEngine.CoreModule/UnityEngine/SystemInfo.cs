using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
public sealed class SystemInfo
{
	public static OperatingSystemFamily operatingSystemFamily => OperatingSystemFamily.Other;

	public static string deviceUniqueIdentifier => null;

	public static DeviceType deviceType => DeviceType.Unknown;

	public static GraphicsDeviceType graphicsDeviceType => GraphicsDeviceType.OpenGL2;

	public static bool graphicsUVStartsAtTop => false;

	public static int graphicsShaderLevel => 0;

	public static bool supportsMotionVectors => false;

	public static bool supports3DRenderTextures => false;

	public static CopyTextureSupport copyTextureSupport => CopyTextureSupport.None;

	public static bool supportsComputeShaders => false;

	public static bool supportsInstancing => false;

	public static int supportedRenderTargetCount => 0;

	public static bool usesReversedZBuffer => false;

	public static int maxTextureSize => 0;

	internal static int maxRenderTextureSize => 0;

	public static long maxGraphicsBufferSize => 0L;

	public static bool usesLoadStoreActions => false;

	private static bool IsValidEnumValue(Enum value)
	{
		return false;
	}

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
	{
		return false;
	}

	public static bool SupportsTextureFormat(TextureFormat format)
	{
		return false;
	}

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	private static OperatingSystemFamily GetOperatingSystemFamily()
	{
		return OperatingSystemFamily.Other;
	}

	[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
	private static string GetDeviceUniqueIdentifier()
	{
		return null;
	}

	[FreeFunction("systeminfo::GetDeviceType")]
	private static DeviceType GetDeviceType()
	{
		return DeviceType.Unknown;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	private static GraphicsDeviceType GetGraphicsDeviceType()
	{
		return GraphicsDeviceType.OpenGL2;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	private static bool GetGraphicsUVStartsAtTop()
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	private static int GetGraphicsShaderLevel()
	{
		return 0;
	}

	[FreeFunction("SupportsMotionVectors")]
	private static bool SupportsMotionVectors()
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::Supports3DRenderTextures")]
	private static bool Supports3DRenderTextures()
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	private static CopyTextureSupport GetCopyTextureSupport()
	{
		return CopyTextureSupport.None;
	}

	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	private static bool SupportsComputeShaders()
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
	private static bool SupportsInstancing()
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
	private static int SupportedRenderTargetCount()
	{
		return 0;
	}

	[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
	private static bool UsesReversedZBuffer()
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	private static bool HasRenderTextureNative(RenderTextureFormat format)
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	private static bool SupportsTextureFormatNative(TextureFormat format)
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	private static int GetMaxTextureSize()
	{
		return 0;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	private static int GetMaxRenderTextureSize()
	{
		return 0;
	}

	[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
	private static long MaxGraphicsBufferSize()
	{
		return 0L;
	}

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
	private static bool UsesLoadStoreActions()
	{
		return false;
	}
}
