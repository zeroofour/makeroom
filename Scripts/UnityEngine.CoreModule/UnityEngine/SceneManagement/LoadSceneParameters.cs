using System;

namespace UnityEngine.SceneManagement;

[Serializable]
public struct LoadSceneParameters
{
	[SerializeField]
	private LoadSceneMode m_LoadSceneMode = LoadSceneMode.Single;

	[SerializeField]
	private LocalPhysicsMode m_LocalPhysicsMode = LocalPhysicsMode.None;

	public LoadSceneMode loadSceneMode
	{
		set
		{
		}
	}

	public LocalPhysicsMode localPhysicsMode
	{
		set
		{
		}
	}

	public LoadSceneParameters(LoadSceneMode mode)
	{
	}
}
