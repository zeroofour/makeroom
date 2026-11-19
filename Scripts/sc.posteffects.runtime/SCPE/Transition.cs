using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(TransitionRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Transition", false)]
public sealed class Transition : PostProcessEffectSettings
{
	public TextureParameter gradientTex;

	[Tooltip("Progress")]
	[Range(0f, 1f)]
	public FloatParameter progress;

	public BoolParameter invert;

	public ColorParameter color;

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
