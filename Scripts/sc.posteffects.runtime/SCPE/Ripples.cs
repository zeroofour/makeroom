using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(RipplesRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Ripples", true)]
public sealed class Ripples : PostProcessEffectSettings
{
	public enum RipplesMode
	{
		Radial = 0,
		OmniDirectional = 1
	}

	[Serializable]
	public sealed class RipplesModeParam : ParameterOverride<RipplesMode>
	{
	}

	[DisplayName("Method")]
	public RipplesModeParam mode;

	[DisplayName("Intensity")]
	[Range(0f, 10f)]
	public FloatParameter strength;

	[Range(1f, 10f)]
	[Tooltip("The frequency of the waves")]
	public FloatParameter distance;

	[Tooltip("Speed")]
	[Range(0f, 10f)]
	public FloatParameter speed;

	[Tooltip("Width")]
	[Range(0f, 5f)]
	public FloatParameter width;

	[Range(0f, 5f)]
	[Tooltip("Height")]
	public FloatParameter height;

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
