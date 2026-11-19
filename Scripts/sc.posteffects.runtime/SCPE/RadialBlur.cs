using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(RadialBlurRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Blurring/Radial Blur", true)]
public sealed class RadialBlur : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	public FloatParameter amount;

	[Space]
	[Tooltip("Sets the blur center point (screen center is [0.5, 0.5]).")]
	public Vector2Parameter center;

	[Range(-180f, 180f)]
	public FloatParameter angle;

	[Space]
	[Range(3f, 12f)]
	public IntParameter iterations;

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
