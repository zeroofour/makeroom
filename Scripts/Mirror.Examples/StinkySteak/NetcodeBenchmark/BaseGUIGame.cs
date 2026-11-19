using System;
using StinkySteak.SimulationTimer;
using UnityEngine;

namespace StinkySteak.NetcodeBenchmark;

public class BaseGUIGame : MonoBehaviour
{
	[Serializable]
	public struct StressTestEssential
	{
		public int SpawnCount;

		public GameObject Prefab;
	}

	[Space]
	protected string _textLatency;

	[SerializeField]
	private float _updateLatencyTextInterval;

	private StinkySteak.SimulationTimer.SimulationTimer _timerUpdateLatencyText;

	[SerializeField]
	[Header("Stress Test 1: Move Y")]
	protected StressTestEssential _test_1;

	[SerializeField]
	[Header("Stress Test 2: Move All Axis")]
	protected StressTestEssential _test_2;

	[Header("Stress Test 3: Move Wander")]
	[SerializeField]
	protected StressTestEssential _test_3;

	private void Start()
	{
	}

	protected virtual void Initialize()
	{
	}

	protected virtual void OnCustomGUI()
	{
	}

	protected virtual void OnGUI()
	{
	}

	protected virtual void StartClient()
	{
	}

	protected virtual void StartServer()
	{
	}

	private void StressTest_1()
	{
	}

	private void StressTest_2()
	{
	}

	private void StressTest_3()
	{
	}

	protected virtual void StressTest(StressTestEssential stressTest)
	{
	}

	private void LateUpdate()
	{
	}

	protected virtual void UpdateNetworkStats()
	{
	}
}
