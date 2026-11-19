using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur>
{
	private enum Pass
	{
		VelocitySetup = 0,
		TileMax1 = 1,
		TileMax2 = 2,
		TileMaxV = 3,
		NeighborMax = 4,
		Reconstruction = 5
	}

	public override DepthTextureMode GetCameraFlags()
	{
		return DepthTextureMode.None;
	}

	private void CreateTemporaryRT(PostProcessRenderContext context, int nameID, int width, int height, RenderTextureFormat RTFormat)
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
