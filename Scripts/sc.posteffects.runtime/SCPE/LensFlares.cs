using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(LensFlaresRenderer), PostProcessEvent.BeforeStack, "SC Post Effects/Rendering/Lens Flares", true)]
public sealed class LensFlares : PostProcessEffectSettings
{
	public BoolParameter debug;

	[Space]
	[Range(0f, 1f)]
	[DisplayName("Intensity")]
	public FloatParameter intensity;

	[Tooltip("Luminance threshold, pixels above this threshold will contribute to the effect")]
	[Range(0.01f, 5f)]
	[DisplayName("Threshold")]
	public FloatParameter luminanceThreshold;

	[Range(1f, 4f)]
	[Header("Flares")]
	[DisplayName("Number")]
	public IntParameter iterations;

	[Range(1f, 2f)]
	[DisplayName("Distance")]
	[Tooltip("Offsets the Flares towards the edge of the screen")]
	public FloatParameter distance;

	[Range(1f, 10f)]
	[Tooltip("Fades out the Flares towards the edge of the screen")]
	[DisplayName("Falloff")]
	public FloatParameter falloff;

	[DisplayName("Size")]
	[Range(0f, 1f)]
	[Tooltip("Creates a halo at the center of the screen when looking directly at a bright spot")]
	[Header("Halo")]
	public FloatParameter haloSize;

	[Range(0f, 100f)]
	[DisplayName("Width")]
	public FloatParameter haloWidth;

	[DisplayName("Mask")]
	[Tooltip("Use a texture to mask out the effect")]
	[Header("Colors and masking")]
	public TextureParameter maskTex;

	[Range(0f, 20f)]
	[DisplayName("Chromatic Abberation")]
	[Tooltip("Refracts the color channels")]
	public FloatParameter chromaticAbberation;

	[DisplayName("Gradient")]
	[Tooltip("Color the flares from the center of the screen to the outer edges")]
	public TextureParameter colorTex;

	[DisplayName("Blur")]
	[Header("Blur")]
	[Tooltip("The amount of blurring that must be performed")]
	[Range(1f, 8f)]
	public FloatParameter blur;

	[Range(1f, 12f)]
	[DisplayName("Iterations")]
	[Tooltip("The number of times the effect is blurred. More iterations provide a smoother effect but induce more drawcalls.")]
	public IntParameter passes;

	[SerializeField]
	public Shader shader;

	private void Reset()
	{
	}

	private bool SerializeShader()
	{
		return false;
	}
}
