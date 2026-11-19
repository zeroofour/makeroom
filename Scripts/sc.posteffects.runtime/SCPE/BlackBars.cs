using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(BlackBarsRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Black Bars", true)]
public sealed class BlackBars : PostProcessEffectSettings
{
	public enum Direction
	{
		Horizontal = 0,
		Vertical = 1
	}

	[Serializable]
	public sealed class DirectionParam : ParameterOverride<Direction>
	{
	}

	[DisplayName("Direction")]
	[Tooltip(null)]
	public DirectionParam mode;

	[Tooltip("Size")]
	[Range(0f, 1f)]
	public FloatParameter size;

	[Tooltip("Max Size")]
	[Range(0f, 1f)]
	public FloatParameter maxSize;

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
