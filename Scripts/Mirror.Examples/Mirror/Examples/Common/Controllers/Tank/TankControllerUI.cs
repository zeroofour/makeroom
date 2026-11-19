using System;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Common.Controllers.Tank;

[DisallowMultipleComponent]
[AddComponentMenu(null)]
public class TankControllerUI : ControllerUIBase
{
	[Serializable]
	public struct MoveTexts
	{
		public Text keyTextTurnLeft;

		public Text keyTextForward;

		public Text keyTextTurnRight;

		public Text keyTextBack;

		public Text keyTextShoot;
	}

	public struct OtherTexts
	{
		public Text keyTextShoot;
	}

	[Serializable]
	public struct OptionsTexts
	{
		public Text keyTextMouseLock;

		public Text keyTextAutoRun;

		public Text keyTextToggleUI;
	}

	[SerializeField]
	private MoveTexts moveTexts;

	[SerializeField]
	private OtherTexts otherKeys;

	[SerializeField]
	private OptionsTexts optionsTexts;

	public void Refresh(TankControllerBase.MoveKeys moveKeys, TankControllerBase.OptionsKeys optionsKeys)
	{
	}
}
