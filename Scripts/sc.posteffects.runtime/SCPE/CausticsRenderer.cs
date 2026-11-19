using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class CausticsRenderer : PostProcessEffectRenderer<Caustics>
{
	private Shader shader;

	private static Matrix4x4 lightToLocalMatrix;

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
