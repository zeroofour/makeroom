using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
	public enum Source
	{
		Default = 0,
		Package = 1
	}

	[Header("Components")]
	public GameObject surface;

	public LineRenderer surfaceLine;

	[HideInInspector]
	public Source latestSource;

	private DioramaChunk lastChunk;

	private List<DioramaChunk> lastChunks;

	private List<GameObject> objects;

	private bool initializePosition;

	public static Holder instance { get; private set; }

	private void Awake()
	{
	}

	public void Add(DioramaChunk _chunk, bool _remember = false, bool _resetAdditional = true, bool _duplicate = false)
	{
	}

	public void AddMultiple(List<DioramaChunk> _chunks, bool _remember = false, bool _resetAdditional = true, bool _duplicate = false)
	{
	}

	public List<DioramaChunk> DuplicateInPlace(List<DioramaChunk> _chunks)
	{
		return null;
	}

	public void Effects()
	{
	}

	public void Add(LibraryObject _model)
	{
	}

	public bool Cancel()
	{
		return false;
	}

	public void Release(bool _allowPlacement = false, bool _shift = false)
	{
	}

	public List<DioramaChunk> GetHeldChunks()
	{
		return null;
	}

	public void BeginRecording()
	{
	}

	public void RegisterChunk(DioramaChunk _chunk)
	{
	}

	public void RegisterChunks(List<DioramaChunk> _chunks)
	{
	}

	public void DynamicUpdates()
	{
	}

	public void SetPosition(Vector3 _position, Vector3 _offset)
	{
	}

	public void SetRotation(Quaternion _rotation)
	{
	}

	public void SetSurface(Vector3 _position, Vector3 _offset)
	{
	}

	public void Reset()
	{
	}

	public GameObject GetHolding()
	{
		return null;
	}

	public bool Holding()
	{
		return false;
	}

	public bool HoldingMultiple()
	{
		return false;
	}
}
