using System;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Common.Controllers.Tank;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
public class TurretUI : ControllerUIBase
{
	[Serializable]
	public struct MoveTexts
	{
		public Text keyTextPitchUp;

		public Text keyTextPitchDown;

		public Text keyTextTurnLeft;

		public Text keyTextTurnRight;
	}

	[SerializeField]
	private MoveTexts moveTexts;

	public void Refresh(TankTurretBase.MoveKeys moveKeys, TankTurretBase.OptionsKeys optionsKeys)
	{
	}
}
