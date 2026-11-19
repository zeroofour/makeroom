using System;
using UnityEngine;

[CreateAssetMenu(fileName = "InputPromptCollection", menuName = "Data/Input Prompt Collection", order = 1)]
public class InputPromptCollection : ScriptableObject
{
	[Serializable]
	public class InputAction
	{
		public string id;

		public string title;

		public InputActionVisual[] visuals;
	}

	[Serializable]
	public class InputActionVisual
	{
		public string name;

		public InputDeviceType device;

		public Sprite icon;
	}

	public InputAction[] inputPrompts;
}
