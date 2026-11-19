using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class TiltShiftRenderer : PostProcessEffectRenderer<TiltShift>
{
	private enum Pass
	{
		FragHorizontal = 0,
		FragHorizontalHQ = 1,
		FragRadial = 2,
		FragRadialHQ = 3,
		FragDebug = 4
	}

	private Shader shader;

	public override void Init()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
