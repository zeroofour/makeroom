using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(PosterizeRenderer), PostProcessEvent.BeforeStack, "SC Post Effects/Retro/Posterize", true)]
public sealed class Posterize : PostProcessEffectSettings
{
	public BoolParameter hsvMode;

	[Range(0f, 256f)]
	public IntParameter levels;

	[Range(2f, 256f)]
	[Header("Levels")]
	public IntParameter hue;

	[Range(2f, 256f)]
	public IntParameter saturation;

	[Range(2f, 256f)]
	public IntParameter value;

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
