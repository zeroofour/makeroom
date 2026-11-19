using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace SCPE;

[Serializable]
[PostProcess(typeof(DangerRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Danger", true)]
public sealed class Danger : PostProcessEffectSettings
{
	public TextureParameter overlayTex;

	public ColorParameter color;

	[Range(0f, 1f)]
	[DisplayName("Opacity")]
	public FloatParameter intensity;

	[Range(0f, 1f)]
	[Tooltip("Size")]
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
