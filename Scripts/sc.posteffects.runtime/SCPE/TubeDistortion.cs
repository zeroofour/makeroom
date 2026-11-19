using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(TubeDistortionRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Tube Distortion", true)]
public sealed class TubeDistortion : PostProcessEffectSettings
{
	public enum DistortionMode
	{
		Buldged = 0,
		Pinched = 1,
		Beveled = 2
	}

	[Serializable]
	public sealed class DistortionModeParam : ParameterOverride<DistortionMode>
	{
	}

	public DistortionModeParam mode;

	[Range(0f, 1f)]
	public FloatParameter amount;

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
