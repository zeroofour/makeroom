using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class EdgeDetectionRenderer : PostProcessEffectRenderer<EdgeDetection>
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

	public override DepthTextureMode GetCameraFlags()
	{
		return DepthTextureMode.None;
	}
}
