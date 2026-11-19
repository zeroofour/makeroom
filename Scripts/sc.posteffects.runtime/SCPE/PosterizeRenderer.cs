using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class PosterizeRenderer : PostProcessEffectRenderer<Posterize>
{
	private Shader shader;

	public override void Init()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
