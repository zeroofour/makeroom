using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(SharpenRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Image/Sharpen", true)]
public sealed class Sharpen : PostProcessEffectSettings
{
	public enum Method
	{
		[InspectorName("Luminance Enhancement (4 samples)")]
		LuminanceEnhancement = 0,
		[InspectorName("Contrast Adaptive (9 samples)")]
		ContrastAdaptive = 1
	}

	[Serializable]
	public sealed class MethodParam : ParameterOverride<Method>
	{
	}

	public MethodParam mode;

	[Range(0f, 1f)]
	public FloatParameter amount;

	[Range(0.1f, 2f)]
	public FloatParameter radius;

	[Range(0f, 1f)]
	public FloatParameter contrast;

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
