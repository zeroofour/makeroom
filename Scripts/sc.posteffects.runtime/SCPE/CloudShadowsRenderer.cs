using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class CloudShadowsRenderer : PostProcessEffectRenderer<CloudShadows>
{
	private Shader shader;

	private static Matrix4x4 lightToLocalMatrix;

	public override void Init()
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
