using UnityEngine;

public class MenuButtons : MonoBehaviour
{
	[Header("Buttons")]
	public GameObject[] buttons;

	[Header("Components")]
	public Sidebar sidebar;

	public PanelOptions panelOptions;

	public ModePhotography modePhotography;

	private void Awake()
	{
	}

	public void ExportToObjective()
	{
	}

	public void SelectMenu()
	{
	}

	public void SelectPhotography()
	{
	}

	public void SelectReturn()
	{
	}

	public void ResetPlacement()
	{
	}

	public void SetStatus(string _status)
	{
	}
}
