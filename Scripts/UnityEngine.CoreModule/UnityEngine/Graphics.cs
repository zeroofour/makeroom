using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine;

[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount;

	internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts;

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount")]
	private static int Internal_GetMaxDrawMeshInstanceCount()
	{
		return 0;
	}

	[FreeFunction("GraphicsScripting::SetNullRT")]
	private static void Internal_SetNullRT()
	{
	}

	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = true, ThrowsException = true)]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
	}

	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
	[FreeFunction("GraphicsScripting::DrawTexture")]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args)
	{
	}

	[FreeFunction("GraphicsScripting::DrawMeshInstanced")]
	private static void Internal_DrawMeshInstanced([NotNull("NullExceptionObject")] Mesh mesh, int submeshIndex, [NotNull("NullExceptionObject")] Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
	{
	}

	[FreeFunction("GraphicsScripting::BlitMaterial")]
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, [NotNull("ArgumentNullException")] Material mat, int pass, bool setRT)
	{
	}

	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit2(Texture source, RenderTexture dest)
	{
	}

	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
	{
	}

	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
	{
	}

	public static void SetRenderTarget(RenderTexture rt, [DefaultValue("0")] int mipLevel, [DefaultValue("CubemapFace.Unknown")] CubemapFace face, [DefaultValue("0")] int depthSlice)
	{
	}

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, [DefaultValue("matrices.Length")] int count, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("ShadowCastingMode.On")] ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("0")] int layer, [DefaultValue("null")] Camera camera, [DefaultValue("LightProbeUsage.BlendProbes")] LightProbeUsage lightProbeUsage, [DefaultValue("null")] LightProbeProxyVolume lightProbeProxyVolume)
	{
	}

	public static void Blit(Texture source, RenderTexture dest)
	{
	}

	public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue("-1")] int pass)
	{
	}

	public static void Blit(Texture source, RenderTexture dest, Material mat)
	{
	}

	[ExcludeFromDocs]
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
	{
	}

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt)
	{
	}

	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
	{
	}
}
