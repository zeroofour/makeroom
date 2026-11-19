using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(BlurRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Blurring/Blur", true)]
public sealed class Blur : PostProcessEffectSettings
{
	public enum BlurMethod
	{
		[InspectorName("Gaussian (7 samples)")]
		Gaussian = 0,
		[InspectorName("Box (4 samples)")]
		Box = 1
	}

	[Serializable]
	public sealed class BlurMethodParameter : ParameterOverride<BlurMethod>
	{
	}

	[DisplayName("Method")]
	[Tooltip("Box blurring uses fewer texture samples but has a limited blur range")]
	public BlurMethodParameter mode;

	[Tooltip("When enabled, the amount of blur passes is doubled")]
	public BoolParameter highQuality;

	public BoolParameter distanceFade;

	public FloatParameter startFadeDistance;

	public FloatParameter endFadeDistance;

	[Tooltip("The amount of blurring that must be performed")]
	[Range(0f, 5f)]
	[Space]
	public FloatParameter amount;

	[Tooltip("The number of times the effect is blurred. More iterations provide a smoother effect but induce more drawcalls.")]
	[Range(1f, 12f)]
	public IntParameter iterations;

	[Range(1f, 4f)]
	[Tooltip("Every step halfs the resolution of the blur effect. Lower resolution provides a smoother blur but may induce flickering.")]
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
