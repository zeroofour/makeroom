using System;
using UnityEngine;

namespace StinkySteak.NetcodeBenchmark;

[CreateAssetMenu(fileName = "BehaviourConfig", menuName = "Netcode Benchmark/Behaviour Config")]
public class BehaviourConfig : ScriptableObject
{
	[Serializable]
	public struct MoveBehaviour
	{
		public SinMoveYWrapper SinYMove;

		public SinRandomMoveWrapper SinAllAxisMove;

		public WanderMoveWrapper WanderMove;

		public void CreateDefault()
		{
		}
	}

	[SerializeField]
	private MoveBehaviour _moveBehaviour;

	private void Reset()
	{
	}

	public void ApplyConfig(ref SinMoveYWrapper wrapper)
	{
	}

	public void ApplyConfig(ref SinRandomMoveWrapper wrapper)
	{
	}

	public void ApplyConfig(ref WanderMoveWrapper wrapper)
	{
	}
}
