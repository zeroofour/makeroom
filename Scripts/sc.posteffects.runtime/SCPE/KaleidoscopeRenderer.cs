using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class KaleidoscopeRenderer : PostProcessEffectRenderer<Kaleidoscope>
{
	private Shader shader;

	private static readonly int _KaleidoscopeSplits;

	public override void Init()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
