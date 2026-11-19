using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(ColorSplitRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Retro/Color Split", true)]
public sealed class ColorSplit : PostProcessEffectSettings
{
	public enum SplitMode
	{
		[InspectorName("Horizontal")]
		Single = 0,
		[InspectorName("Horizontal + Vertical")]
		Double = 1
	}

	[Serializable]
	public sealed class SplitModeParam : ParameterOverride<SplitMode>
	{
	}

	[Tooltip("Box filtered methods provide a subtle blur effect and are less efficient")]
	[DisplayName("Method")]
	public SplitModeParam mode;

	[Tooltip("The amount by which the color channels offset")]
	[Range(0f, 1f)]
	public FloatParameter offset;

	[Tooltip("0=Full screen. 1=Limit to screen edges")]
	[Range(0f, 1f)]
	public FloatParameter edgeMasking;

	[Range(0f, 3f)]
	[Tooltip("Luminance threshold, pixels above this threshold will contribute to the effect")]
	public FloatParameter luminanceThreshold;

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
