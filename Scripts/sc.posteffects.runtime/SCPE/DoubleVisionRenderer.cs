using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class DoubleVisionRenderer : PostProcessEffectRenderer<DoubleVision>
{
	private Shader DoubleVisionShader;

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
