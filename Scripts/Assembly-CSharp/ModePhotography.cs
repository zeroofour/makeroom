using SCPE;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ModePhotography : Mode
{
	[Header("Components")]
	public CanvasGroup flash;

	public PostProcessVolume volume;

	public GameObject buttonFolder;

	[Header("Switchers")]
	public Switcher switcherResolution;

	public Switcher switcherLogo;

	public Switcher switcherOutlines;

	public Switcher switcherColorFilter;

	[Header("Checkboxes")]
	public SwitcherToggle switcherCameraMode;

	public SwitcherToggle switcherTiltShift;

	public SwitcherToggle switcherPainting;

	private KenneyOutline outline;

	private LUT colorFilter;

	private TiltShift tiltShift;

	private Kuwahara painting;

	private LibraryData library;

	private float outlineThickness;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void StatePrepare()
	{
	}

	public void StateReset()
	{
	}

	public void Apply()
	{
	}

	public override void Open()
	{
	}

	public override void Close()
	{
	}

	public void Focus()
	{
	}

	public void OpenFolder()
	{
	}

	public void TakePhotograph()
	{
	}
}
