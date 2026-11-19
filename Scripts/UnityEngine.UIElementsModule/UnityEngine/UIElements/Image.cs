namespace UnityEngine.UIElements;

public class Image : VisualElement
{
	public new class UxmlFactory : UxmlFactory<Image, UxmlTraits>
	{
	}

	public new class UxmlTraits : VisualElement.UxmlTraits
	{
	}

	private ScaleMode m_ScaleMode;

	private Texture m_Image;

	private Sprite m_Sprite;

	private VectorImage m_VectorImage;

	private Rect m_UV;

	private Color m_TintColor;

	private bool m_ImageIsInline;

	private bool m_ScaleModeIsInline;

	private bool m_TintColorIsInline;

	public static readonly string ussClassName;

	private static CustomStyleProperty<Texture2D> s_ImageProperty;

	private static CustomStyleProperty<Sprite> s_SpriteProperty;

	private static CustomStyleProperty<VectorImage> s_VectorImageProperty;

	private static CustomStyleProperty<string> s_ScaleModeProperty;

	private static CustomStyleProperty<Color> s_TintColorProperty;

	public Texture image => null;

	public Sprite sprite => null;

	public VectorImage vectorImage => null;

	public Rect sourceRect => default;

	public Rect uv => default;

	public ScaleMode scaleMode => ScaleMode.StretchToFill;

	public Color tintColor => default;

	private Vector2 GetTextureDisplaySize(Texture texture)
	{
		return default;
	}

	private Vector2 GetTextureDisplaySize(Sprite sprite)
	{
		return default;
	}

	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default;
	}

	private void OnGenerateVisualContent(MeshGenerationContext mgc)
	{
	}

	private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
	{
	}

	private void SetScaleMode(ScaleMode mode)
	{
	}

	private Rect GetSourceRect()
	{
		return default;
	}
}
