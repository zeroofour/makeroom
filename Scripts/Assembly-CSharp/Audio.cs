using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
	public static Dictionary<string, AudioClip> data;

	public static Dictionary<string, AudioSource> sources;

	private void Awake()
	{
	}

	public static void PrepareAudio(string folder, Transform _transform)
	{
	}

	public static void LoadAudio(string folder)
	{
	}

	public static AudioClip Load(string audio)
	{
		return null;
	}

	public static void Play(string _audio, bool _randomPitch = true, float _volume = 1f, string _source = "sounds")
	{
	}

	public static void Play(string _audio, float _pitch = 1f, float _volume = 1f, string _source = "sounds")
	{
	}

	public static void SourcePlay(string _source = "sounds")
	{
	}

	public static void SourceStop(string _source = "sounds")
	{
	}

	public static void SourceFade(string _source = "sounds", float _volume = 1f)
	{
	}

	public static void SourceSetVolume(string _source = "sounds", float _volume = 1f)
	{
	}

	public static void SetClip(AudioSource _source, string _clip)
	{
	}

	public static void SetClip(AudioSource _source, AudioClip _clip)
	{
	}

	public static void StopClip(AudioSource _source)
	{
	}

	public static float GetVolumeIndex(int _index)
	{
		return 0f;
	}
}
