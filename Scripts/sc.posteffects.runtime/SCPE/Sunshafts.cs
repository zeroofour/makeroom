using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(SunshaftsRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Environment/Sun Shafts", true)]
public sealed class Sunshafts : PostProcessEffectSettings
{
	public enum BlendMode
	{
		Additive = 0,
		Screen = 1
	}

	public enum SunShaftsResolution
	{
		Full = 1,
		Half = 2,
		Third = 3,
		Quarter = 4
	}

	[Serializable]
	public sealed class SunShaftsSourceParameter : ParameterOverride<BlendMode>
	{
	}

	[Serializable]
	public sealed class SunShaftsResolutionParameter : ParameterOverride<SunShaftsResolution>
	{
	}

	[Tooltip("Use the color of the Directional Light that's set as the caster")]
	public BoolParameter useCasterColor;

	[Tooltip("Use the intensity of the Directional Light that's set as the caster")]
	public BoolParameter useCasterIntensity;

	[DisplayName("Intensity")]
	[UnityEngine.Rendering.PostProcessing.Min(0f)]
	public FloatParameter sunShaftIntensity;

	[Tooltip("Additive mode adds the sunshaft color to the image, while Screen mode perserves color values")]
	public SunShaftsSourceParameter blendMode;

	[DisplayName("Resolution")]
	[Tooltip("Low, quater resolution\n\nNormal, half resolution\n\nHigh, full resolution\n\nLower resolutions may induce jittering")]
	public SunShaftsResolutionParameter resolution;

	[Tooltip("Enabling this option doubles the amount of blurring performed. Resulting in smoother sunshafts at a higher performance cost.")]
	public BoolParameter highQuality;

	[ColorUsage(true, true)]
	[DisplayName("Sky color threshold")]
	[Tooltip("Any color values over this threshold will contribute to the sunshafts effect")]
	public ColorParameter sunThreshold;

	public ColorParameter sunColor;

	[Range(0.1f, 1f)]
	[Tooltip("The degree to which the shafts’ brightness diminishes with distance from the caster")]
	public FloatParameter falloff;

	[Tooltip("The length of the sunrays from the caster's position to the camera")]
	[UnityEngine.Rendering.PostProcessing.Min(0f)]
	public FloatParameter length;

	[Range(0f, 1f)]
	public FloatParameter noiseStrength;

	public static Vector3 sunPosition;

	[SerializeField]
	public Shader shader;

	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	private void Reset()
	{
	}

	private bool SerializeShader()
	{
		return false;
	}
}
