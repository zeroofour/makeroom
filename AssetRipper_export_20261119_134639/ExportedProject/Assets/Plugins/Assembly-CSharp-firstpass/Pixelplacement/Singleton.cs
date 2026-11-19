using UnityEngine;

namespace Pixelplacement
{
	[RequireComponent(typeof(Initialization))]
	public abstract class Singleton<T> : MonoBehaviour
	{
		[SerializeField]
		private bool _dontDestroyOnLoad;

		private static T _instance;

		public static T Instance => default;

		protected virtual void OnRegistration()
		{
		}

		public void RegisterSingleton(T instance)
		{
		}

		protected void Initialize(T instance)
		{
		}
	}
}
