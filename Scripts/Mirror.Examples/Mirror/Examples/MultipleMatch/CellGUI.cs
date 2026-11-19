using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.MultipleMatch;

public class CellGUI : MonoBehaviour
{
	public MatchController matchController;

	public CellValue cellValue;

	[Header("GUI References")]
	public Image image;

	public Button button;

	[Header("Diagnostics")]
	[SerializeField]
	[ReadOnly]
	internal NetworkIdentity playerIdentity;

	public void Awake()
	{
	}

	[ClientCallback]
	public void MakePlay()
	{
	}

	[ClientCallback]
	public void SetPlayer(NetworkIdentity playerIdentity)
	{
	}
}
