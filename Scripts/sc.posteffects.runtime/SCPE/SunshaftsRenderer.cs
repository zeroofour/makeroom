using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class SunshaftsRenderer : PostProcessEffectRenderer<Sunshafts>
{
	private enum Pass
	{
		SkySource = 0,
		RadialBlur = 1,
		Blend = 2
	}

	private Shader shader;

	private int sunshaftBufferID;

	private int blurredID;

	private int blurredID2;

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
