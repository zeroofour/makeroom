using System;
using System.Collections.Generic;
using Kenney;
using UnityEngine;

public class Undo : MonoBehaviour
{
	private class UndoState
	{
		public List<UndoChunk> chunks;

		public List<UndoProperty> properties;

		public bool Empty()
		{
			return false;
		}
	}

	private class UndoChunk
	{
		public int uid;

		public DioramaChunk before;

		public DioramaChunk after;
	}

	private class UndoProperty
	{
		public string id;

		public DioramaProperty before;

		public DioramaProperty after;
	}

	private class UndoSnapshot
	{
		public Dictionary<int, DioramaChunk> chunks;

		public Dictionary<string, DioramaProperty> properties;
	}

	[Header("Components")]
	public Button button;

	public Button buttonRedo;

	private int maximumMemory;

	private List<UndoState> undoStates;

	private List<UndoState> redoStates;

	private UndoSnapshot snapshot;

	private int depth;

	private Dictionary<string, Func<bool>> transactions;

	private bool applying;

	private bool suspended;

	public static Undo instance { get; private set; }

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public static void Begin(string _key = null, Func<bool> _active = null)
	{
	}

	public static void Commit(string _key = null)
	{
	}

	private void StartRecording(string _key, Func<bool> _active)
	{
	}

	private void StopRecording(string _key)
	{
	}

	private bool Recording()
	{
		return false;
	}

	private void Finish()
	{
	}

	public void PerformUndo()
	{
	}

	public void PerformRedo()
	{
	}

	private bool Available()
	{
		return false;
	}

	private void Apply(UndoState _state, bool _undo)
	{
	}

	private UndoSnapshot Capture()
	{
		return null;
	}

	private UndoState Compare(UndoSnapshot _before, UndoSnapshot _after)
	{
		return null;
	}

	private bool SameChunk(DioramaChunk _a, DioramaChunk _b)
	{
		return false;
	}

	private bool SameAppearance(DioramaChunk _a, DioramaChunk _b)
	{
		return false;
	}

	private bool SameProperty(DioramaProperty _a, DioramaProperty _b)
	{
		return false;
	}

	public void Reset()
	{
	}

	public void Suspend()
	{
	}

	public void UpdateButton()
	{
	}
}
