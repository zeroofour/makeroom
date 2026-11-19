using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(SpeedLinesRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Speed Lines", true)]
public sealed class SpeedLines : PostProcessEffectSettings
{
	[Tooltip("Assign any grayscale texture with a vertically repeating pattern and a falloff from left to right")]
	public TextureParameter noiseTex;

	[Range(0f, 1f)]
	public FloatParameter intensity;

	[Tooltip("Determines the radial tiling of the noise texture")]
	[Range(0f, 1f)]
	public FloatParameter size;

	[Range(0f, 1f)]
	public FloatParameter falloff;

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
