using Mirror;
using StinkySteak.NetcodeBenchmark;
using UnityEngine;

namespace StinkySteak.MirrorBenchmark;

public class GUIGame : BaseGUIGame
{
	[SerializeField]
	private NetworkManager _networkManagerPrefab;

	private NetworkManager _networkManager;

	protected override void Initialize()
	{
	}

	private void RegisterPrefabs(StressTestEssential[] stressTestEssential)
	{
	}

	protected override void OnCustomGUI()
	{
	}

	protected override void StressTest(StressTestEssential stressTest)
	{
	}

	protected override void UpdateNetworkStats()
	{
	}
}
