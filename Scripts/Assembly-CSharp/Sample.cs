using UnityEngine;

[CreateAssetMenu(fileName = "Sample", menuName = "Data/Sample", order = 1)]
public class Sample : ScriptableObject
{
	[Header("Properties")]
	public string title;

	public string author;

	[Header("Diorama")]
	public DioramaData diorama;
}
