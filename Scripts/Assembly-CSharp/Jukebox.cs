using UnityEngine;

public class Jukebox : MonoBehaviour
{
	[Header("Music")]
	public AudioClip[] music;

	private int index;

	private float musicVolume;

	private AudioSource audioSource;

	public static Jukebox instance { get; private set; }

	private void Awake()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void Next()
	{
	}
}
