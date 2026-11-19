using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(ScanlinesRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Retro/Scanlines", true)]
public sealed class Scanlines : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Tooltip("Intensity")]
	public FloatParameter intensity;

	[DisplayName("Lines")]
	[Range(0f, 2048f)]
	public FloatParameter amount;

	[Tooltip("Animation speed")]
	[Range(0f, 1f)]
	public FloatParameter speed;

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
