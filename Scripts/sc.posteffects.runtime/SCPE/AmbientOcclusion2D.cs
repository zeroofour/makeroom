using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(AmbientOcclusion2DRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Rendering/Ambient Occlusion 2D", true)]
public sealed class AmbientOcclusion2D : PostProcessEffectSettings
{
	[DisplayName("Debug")]
	[Tooltip("Shows only the effect, to alow for finetuning")]
	public BoolParameter aoOnly;

	[Tooltip("Intensity")]
	[Range(0f, 1f)]
	[Header("Luminance-Based Amient Occlusion")]
	public FloatParameter intensity;

	[Range(0.01f, 1f)]
	[Tooltip("Luminance threshold, pixels above this threshold will contribute to the effect")]
	public FloatParameter luminanceThreshold;

	[Range(0f, 3f)]
	[Tooltip("Distance")]
	public FloatParameter distance;

	[Header("Blur")]
	[Range(0f, 3f)]
	[DisplayName("Blur")]
	[Tooltip("The amount of blurring that must be performed")]
	public FloatParameter blurAmount;

	[Range(1f, 8f)]
	[Tooltip("The number of times the effect is blurred. More iterations provide a smoother effect but induce more drawcalls.")]
	public IntParameter iterations;

	[Tooltip("Every step halves the resolution of the blur effect. Lower resolution provides a smoother blur but may induce flickering.")]
	[Range(1f, 4f)]
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
