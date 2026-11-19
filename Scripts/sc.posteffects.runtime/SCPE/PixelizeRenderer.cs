using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

public sealed class PixelizeRenderer : PostProcessEffectRenderer<Pixelize>
{
	private Shader shader;

	private static readonly int _PixelizeParams;

	private static Vector4 pixelizeParams;

	public override void Init()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
