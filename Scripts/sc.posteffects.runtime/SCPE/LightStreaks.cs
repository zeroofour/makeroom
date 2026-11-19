using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(LightStreaksRenderer), PostProcessEvent.BeforeStack, "SC Post Effects/Rendering/Light Streaks", true)]
public sealed class LightStreaks : PostProcessEffectSettings
{
	public enum Quality
	{
		Performance = 0,
		Appearance = 1
	}

	[Serializable]
	public sealed class BlurMethodParameter : ParameterOverride<Quality>
	{
	}

	[Tooltip("Choose between Box and Gaussian blurring methods.\n\nBox blurring is more efficient but has a limited blur range")]
	[DisplayName("Quality")]
	public BlurMethodParameter quality;

	[Range(0f, 1f)]
	[Tooltip("Shows only the effect, to allow for finetuning")]
	[DisplayName("Streaks Only")]
	public BoolParameter debug;

	[Tooltip("Intensity")]
	[Range(0f, 1f)]
	[Header("Anamorphic Lensfares")]
	public FloatParameter intensity;

	[Tooltip("Luminance threshold, pixels above this threshold (material's emission value) will contribute to the effect")]
	[Range(0.01f, 5f)]
	public FloatParameter luminanceThreshold;

	[Tooltip("Negative values become horizontal whereas postive values are vertical")]
	[Range(-1f, 1f)]
	public FloatParameter direction;

	[Tooltip("The amount of blurring that must be performed")]
	[DisplayName("Amount")]
	[Header("Blur")]
	[Range(0f, 10f)]
	public FloatParameter blur;

	[Range(1f, 8f)]
	[Tooltip("The number of times the effect is blurred. More iterations provide a smoother effect but induce more drawcalls.")]
	public IntParameter iterations;

	[Range(1f, 4f)]
	[Tooltip("Every step halfs the resolution of the blur effect. Lower resolution provides a smoother blur but may induce flickering")]
	public IntParameter downscaling;

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
