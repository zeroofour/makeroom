using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(KaleidoscopeRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Misc/Kaleidoscope", false)]
public sealed class Kaleidoscope : PostProcessEffectSettings
{
	[Range(0f, 10f)]
	[Tooltip("The number of times the screen is split up")]
	public IntParameter radialSplits;

	[Range(1f, 6f)]
	public IntParameter horizontalSplits;

	[Range(1f, 6f)]
	public IntParameter verticalSplits;

	[Tooltip("Sets the pivot point (screen center is [0.5, 0.5]).")]
	public Vector2Parameter center;

	[Space]
	public BoolParameter maintainAspectRatio;

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
