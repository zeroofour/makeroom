using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(DoubleVisionRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Blurring/Double Vision", true)]
public sealed class DoubleVision : PostProcessEffectSettings
{
	public enum Mode
	{
		FullScreen = 0,
		Edges = 1
	}

	[Serializable]
	public sealed class DoubleVisionMode : ParameterOverride<Mode>
	{
	}

	[DisplayName("Method")]
	[Tooltip("Choose to apply the effect over the entire screen or just the edges")]
	public DoubleVisionMode mode;

	[Tooltip("Intensity")]
	[Range(0f, 1f)]
	public FloatParameter intensity;

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
