using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class LensFlaresRenderer : PostProcessEffectRenderer<LensFlares>
{
	private enum Pass
	{
		LuminanceDiff = 0,
		Ghosting = 1,
		Blur = 2,
		Blend = 3,
		Debug = 4
	}

	private Shader shader;

	private int emissionTex;

	private int flaresTex;

	private RenderTexture aoRT;

	public override void Init()
	{
	}

	public override void Release()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
