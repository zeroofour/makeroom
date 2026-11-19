using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(CustomBloomRenderer), PostProcessEvent.AfterStack, "Custom/Bloom", true)]
public sealed class CustomBloom : PostProcessEffectSettings
{
	[Tooltip("Luminance below this value is treated as black (no contribution to bloom).")]
	public FloatParameter minBrightness;

	[Tooltip("Luminance above this value is treated as fully white (maximum contribution).")]
	public FloatParameter maxBrightness;

	[Tooltip("Pixels must exceed this luminance before any bloom is applied.")]
	public FloatParameter threshold;

	[UnityEngine.Rendering.PostProcessing.Min(1f)]
	[Tooltip("How wide the bloom spreads. Each iteration halves the resolution, so higher values = wider glow.")]
	public IntParameter iterations;

	[Tooltip("Overall brightness multiplier of the bloom added on top of the scene.")]
	public FloatParameter intensity;

	[Tooltip("If true, only affects colors where at least one RGB channel exceeds an intensity of 1.0.")]
	public BoolParameter strictHDR;
}
