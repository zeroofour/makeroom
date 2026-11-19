using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(MosaicRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Stylized/Mosaic", true)]
public sealed class Mosaic : PostProcessEffectSettings
{
	public enum MosaicMode
	{
		Triangles = 0,
		Hexagons = 1,
		Circles = 2
	}

	[Serializable]
	public sealed class MosaicModeParam : ParameterOverride<MosaicMode>
	{
	}

	[Tooltip(null)]
	[DisplayName("Method")]
	public MosaicModeParam mode;

	[Tooltip("Size")]
	[Range(0f, 1f)]
	public FloatParameter size;

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
