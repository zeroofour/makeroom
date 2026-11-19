using UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(KenneyOutlineRenderer), PostProcessEvent.AfterStack, "Kenney/Outline", true)]
public class KenneyOutline : PostProcessEffectSettings
{
	public FloatParameter thickness;

	public FloatParameter depthMultiplier;

	public FloatParameter depthBias;

	public FloatParameter normalMultiplier;

	public FloatParameter normalBias;

	public ColorParameter color;
}
