using UnityEngine;

public class ScenarioManager : MonoBehaviour
{
	private Scenario[] scenarios;

	private Scenario scenario;

	private int step;

	public static ScenarioManager instance { get; private set; }

	private void Awake()
	{
	}

	public void Set(string _name)
	{
	}

	public void Step()
	{
	}

	public void RenderChecklist()
	{
	}

	public Scenario GetScenario(string _name)
	{
		return null;
	}

	public void Reset()
	{
	}
}
