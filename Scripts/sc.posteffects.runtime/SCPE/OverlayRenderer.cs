using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class OverlayRenderer : PostProcessEffectRenderer<Overlay>
{
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
}
