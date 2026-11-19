using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(SketchRenderer), PostProcessEvent.BeforeStack, "SC Post Effects/Stylized/Sketch", true)]
public sealed class Sketch : PostProcessEffectSettings
{
	public enum SketchProjectionMode
	{
		WorldSpace = 0,
		ScreenSpace = 1
	}

	[Serializable]
	public sealed class SketchProjectioParameter : ParameterOverride<SketchProjectionMode>
	{
	}

	public enum SketchMode
	{
		EffectOnly = 0,
		Multiply = 1,
		Add = 2
	}

	[Serializable]
	public sealed class SketchModeParameter : ParameterOverride<SketchMode>
	{
	}

	[Tooltip("The Red channel is used for darker shades, whereas the Green channel is for lighter.")]
	public TextureParameter strokeTex;

	[Tooltip("Choose the type of UV space being used")]
	[Space]
	public SketchProjectioParameter projectionMode;

	[Tooltip("Choose one of the different modes")]
	public SketchModeParameter blendMode;

	[Space]
	[Range(0f, 1f)]
	public FloatParameter intensity;

	public Vector2Parameter brightness;

	[Range(1f, 32f)]
	public FloatParameter tiling;

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
