using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mirror.Examples.MultipleAdditiveScenes;

internal static class Spawner
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRecycleReward_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameObject reward;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDelayedSpawn_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Scene scene;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static GameObject prefab;

	private static byte poolSize;

	private static Pool<GameObject> pool;

	private static ushort counter;

	internal static void InitializePool(GameObject poolPrefab, byte count)
	{
	}

	internal static void ClearPool()
	{
	}

	private static GameObject SpawnHandler(SpawnMessage msg)
	{
		return null;
	}

	private static void UnspawnHandler(GameObject spawned)
	{
	}

	private static GameObject CreateNew()
	{
		return null;
	}

	public static GameObject Get(Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public static void Return(GameObject spawned)
	{
	}

	[ServerCallback]
	internal static void InitialSpawn(Scene scene)
	{
	}

	[ServerCallback]
	internal static void SpawnReward(Scene scene)
	{
	}

	[AsyncStateMachine(typeof(_003CRecycleReward_003Ed__13))]
	[ServerCallback]
	internal static void RecycleReward(GameObject reward)
	{
	}

	[AsyncStateMachine(typeof(_003CDelayedSpawn_003Ed__14))]
	private static Task DelayedSpawn(Scene scene)
	{
		return null;
	}
}
