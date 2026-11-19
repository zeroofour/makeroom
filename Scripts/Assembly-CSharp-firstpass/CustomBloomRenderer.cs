using UnityEngine.Rendering.PostProcessing;

public sealed class CustomBloomRenderer : PostProcessEffectRenderer<CustomBloom>
{
	private const int k_MaxIterations = 16;

	private static readonly int[] k_DownIDs;

	private static readonly int[] k_UpIDs;

	private const int k_PassThreshold = 0;

	private const int k_PassDownsample = 1;

	private const int k_PassUpsample = 2;

	private const int k_PassComposite = 3;

	private static readonly int k_BloomTex;

	private static readonly int k_TexelSize;

	private static readonly int k_Threshold;

	private static readonly int k_MinBrightness;

	private static readonly int k_MaxBrightness;

	private static readonly int k_Intensity;

	private static readonly int k_StrictHDR;

	static CustomBloomRenderer()
	{
	}

	public override void Render(PostProcessRenderContext _context)
	{
	}
}
