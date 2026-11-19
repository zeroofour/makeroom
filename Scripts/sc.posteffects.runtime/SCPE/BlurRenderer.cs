using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class BlurRenderer : PostProcessEffectRenderer<Blur>
{
	private enum Pass
	{
		Blend = 0,
		BlendDepthFade = 1,
		Gaussian = 2,
		Box = 3
	}

	private Shader shader;

	private int blurredID;

	private int blurredID2;

	public override void Init()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
