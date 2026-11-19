using System;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Common.Controllers.Player;

[DisallowMultipleComponent]
[AddComponentMenu(null)]
public class PlayerControllerRBUI : ControllerUIBase
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

		public Text keyTextJump;
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
	private OptionsTexts optionsTexts;

	public void Refresh(PlayerControllerRBBase.MoveKeys moveKeys, PlayerControllerRBBase.OptionsKeys optionsKeys)
	{
	}
}
