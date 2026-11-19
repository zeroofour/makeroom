using System;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.MultipleMatch;

public class MatchGUI : MonoBehaviour
{
	private Guid matchId;

	[Header("GUI Elements")]
	public Image image;

	public Toggle toggleButton;

	public Text matchName;

	public Text playerCount;

	[SerializeField]
	[ReadOnly]
	[Header("Diagnostics")]
	internal CanvasController canvasController;

	public void Awake()
	{
	}

	[ClientCallback]
	public void OnToggleClicked(bool isOn)
	{
	}

	[ClientCallback]
	public Guid GetMatchId()
	{
		return default;
	}

	[ClientCallback]
	public void SetMatchInfo(MatchInfo infos)
	{
	}
}
