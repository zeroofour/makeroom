using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(PixelizeRenderer), PostProcessEvent.BeforeStack, "SC Post Effects/Retro/Pixelize", true)]
public sealed class Pixelize : PostProcessEffectSettings
{
	public enum Resolution
	{
		Custom = 1,
		[InspectorName("600p")]
		Sixhundred = 600,
		[InspectorName("480p")]
		FourEighty = 480,
		[InspectorName("240p")]
		TwoFourty = 240,
		[InspectorName("200p")]
		TwoHundred = 200,
		[InspectorName("160p")]
		HundredSixty = 160
	}

	[Serializable]
	public sealed class ResolutionPreset : ParameterOverride<Resolution>
	{
	}

	[Range(0f, 1f)]
	[Tooltip("Amount")]
	public FloatParameter amount;

	[UnityEngine.Rendering.PostProcessing.Min(0f)]
	public IntParameter resolution;

	public ResolutionPreset resolutionPreset;

	[Tooltip("When disabled, pixels will retain a square aspect ratio")]
	public BoolParameter preserveAspectRatio;

	[Tooltip("When enabled, pixels are shifted by half. Mostly has a visible effect on extremely low resolutions")]
	public BoolParameter centerPixel;

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
