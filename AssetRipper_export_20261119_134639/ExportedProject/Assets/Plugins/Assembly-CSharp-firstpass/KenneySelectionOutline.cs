using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(KenneySelectionOutlineRenderer), PostProcessEvent.BeforeStack, "Kenney/Selection Outline", true)]
public class KenneySelectionOutline : PostProcessEffectSettings
{
	[Header("Outline")]
	public FloatParameter thickness;

	public ColorParameter color;

	[Header("Fill")]
	public ColorParameter fillColor;

	[Header("Debug")]
	public BoolParameter showBuffer;
}
