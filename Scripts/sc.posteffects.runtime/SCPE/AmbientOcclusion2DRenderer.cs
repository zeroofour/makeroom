using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class AmbientOcclusion2DRenderer : PostProcessEffectRenderer<AmbientOcclusion2D>
{
	private enum Pass
	{
		LuminanceDiff = 0,
		Blur = 1,
		Blend = 2,
		Debug = 3
	}

	private Shader shader;

	private int aoTexID;

	private int screenCopyID;

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
