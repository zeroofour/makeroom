using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Serialization;

namespace SCPE;

[Serializable]
[PostProcess(typeof(RefractionRenderer), PostProcessEvent.AfterStack, "SC Post Effects/Screen/Refraction", true)]
public sealed class Refraction : PostProcessEffectSettings
{
	[FormerlySerializedAs("refractionTex")]
	[Tooltip("Takes a normal map to perturb the image")]
	public TextureParameter normalMap;

	[Range(0f, 1f)]
	[Tooltip("Amount")]
	public FloatParameter amount;

	public ColorParameter tint;

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
