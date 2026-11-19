using System;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Common.Controllers.Flyer;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
public class FlyerControllerUI : ControllerUIBase
{
	[Serializable]
	public struct MoveTexts
	{
		public Text keyTextTurnLeft;

		public Text keyTextForward;

		public Text keyTextTurnRight;

		public Text keyTextStrafeLeft;

		public Text keyTextBack;

		public Text keyTextStrafeRight;
	}

	[Serializable]
	public struct FlightTexts
	{
		public Text keyTextPitchDown;

		public Text keyTextPitchUp;

		public Text keyTextRollLeft;

		public Text keyTextRollRight;

		public Text keyTextAutoLevel;
	}

	[Serializable]
	public struct OptionsTexts
	{
		public Text keyTextMouseSteer;

		public Text keyTextAutoRun;

		public Text keyTextToggleUI;
	}

	[SerializeField]
	private MoveTexts moveTexts;

	[SerializeField]
	private FlightTexts flightTexts;

	[SerializeField]
	private OptionsTexts optionsTexts;

	public void Refresh(FlyerControllerBase.MoveKeys moveKeys, FlyerControllerBase.FlightKeys flightKeys, FlyerControllerBase.OptionsKeys optionsKeys)
	{
	}
}
