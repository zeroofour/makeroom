using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class RadialBlurRenderer : PostProcessEffectRenderer<RadialBlur>
{
	private Shader shader;

	public override void Init()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
