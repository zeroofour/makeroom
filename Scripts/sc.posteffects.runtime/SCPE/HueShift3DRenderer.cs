using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class HueShift3DRenderer : PostProcessEffectRenderer<HueShift3D>
{
	private enum Pass
	{
		ColorSpectrum = 0,
		GradientTexture = 1
	}

	private Shader shader;

	public override void Init()
	{
	}

	public override void Release()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}

	public override DepthTextureMode GetCameraFlags()
	{
		return DepthTextureMode.None;
	}
}
