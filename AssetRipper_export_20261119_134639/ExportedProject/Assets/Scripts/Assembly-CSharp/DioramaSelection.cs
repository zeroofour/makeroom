using System.Collections.Generic;
using UnityEngine;

public class DioramaSelection : MonoBehaviour
{
	private List<DioramaChunk> selection;

	private MaterialPropertyBlock selectionBlock;

	private MaterialPropertyBlock selectionBlockGroup;

	public static DioramaSelection instance { get; private set; }

	private void Awake()
	{
	}

	public void Select(Transform _transform)
	{
	}

	public void Select(DioramaChunk _chunk)
	{
	}

	public void Select(List<DioramaChunk> _chunks)
	{
	}

	public bool ChunkBlocked(DioramaChunk _chunk)
	{
		return false;
	}

	public void Reset()
	{
	}

	public void Add(DioramaChunk _chunk)
	{
	}

	private void Remove(DioramaChunk _chunk)
	{
	}

	public void RefreshSelection()
	{
	}

	private void Refresh(DioramaChunk _chunk, bool _active = true)
	{
	}

	public List<DioramaChunk> GetSelection()
	{
		return null;
	}

	public void Grab(Holder.Source _source = Holder.Source.Default)
	{
	}

	public void Duplicate()
	{
	}

	public void DuplicateInPlace()
	{
	}

	public void Remove()
	{
	}

	public void Hide()
	{
	}

	public void Lock()
	{
	}

	public void ActivateGizmo(bool _forced = false)
	{
	}

	public void Resize(float _value)
	{
	}

	public Vector3 GetCenter()
	{
		return default;
	}

	public void SelectPrevious()
	{
	}

	public void SelectNext()
	{
	}

	private void SelectStep(int _direction)
	{
	}
}
