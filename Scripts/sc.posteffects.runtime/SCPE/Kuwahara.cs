using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(KuwaharaRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Stylized/Kuwahara", true)]
public sealed class Kuwahara : PostProcessEffectSettings
{
	public enum KuwaharaMode
	{
		FullScreen = 0,
		DepthFade = 1
	}

	[Serializable]
	public sealed class KuwaharaModeParam : ParameterOverride<KuwaharaMode>
	{
	}

	[Tooltip("Choose to apply the effect to the entire screen, or fade in/out over a distance")]
	[DisplayName("Method")]
	public KuwaharaModeParam mode;

	[Range(0f, 16f)]
	[DisplayName("Radius")]
	public IntParameter radius;

	public FloatParameter startFadeDistance;

	public FloatParameter endFadeDistance;

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
