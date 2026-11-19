using UnityEngine;

[CreateAssetMenu(fileName = "Objective", menuName = "Data/Objective", order = 1)]
public class Objective : ScriptableObject
{
	public enum Type
	{
		Default = 0,
		Cleaning = 1,
		Unpacking = 2
	}

	[Header("Properties")]
	public string title;

	public Type type;

	public bool cleaning;

	[Header("Reward")]
	public string unlock;

	public string unlockName;

	public Chapter[] chapters;

	[Header("Diorama")]
	public DioramaData diorama;
}
