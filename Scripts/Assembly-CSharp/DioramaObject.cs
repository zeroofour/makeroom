using System.Collections.Generic;
using Pixelplacement.TweenSystem;
using UnityEngine;

public class DioramaObject : MonoBehaviour
{
	public DioramaChunk chunk;

	private TweenBase tween;

	private GameObject generated;

	private GameObject generatedMirror;

	private Material generatedTexture;

	private List<GameObject> lights;

	private bool opened;

	private bool active;

	private int changedIndex;

	public void Generate(bool _colliders = true)
	{
	}

	public void AdjustVisibility()
	{
	}

	public void AdjustColors()
	{
	}

	public void AdjustColorsSpecial(Dictionary<int, Gradient> _colorDictionary)
	{
	}

	public void AddComponents()
	{
	}

	public void AdjustComponents()
	{
	}

	public void AdjustDynamicComponents()
	{
	}

	public Texture2D FetchTexture(string _name = null, int _index = -1)
	{
		return null;
	}

	public void AdjustTexture()
	{
	}

	public void ChunkUpdate()
	{
	}

	public void ChunkApply()
	{
	}

	public void SetChunk(DioramaChunk _chunk)
	{
	}

	public DioramaChunk GetChunk()
	{
		return null;
	}

	public List<string> GetColors()
	{
		return null;
	}

	public void SetColor(int _originalIndex, string _replacement, bool _bounce = true)
	{
	}

	public void SetScale(Vector3 _scale)
	{
	}

	public void AddRotation(float _rotation)
	{
	}

	public void Bounce(float _multiplier = 1f)
	{
	}

	public void CancelBounce()
	{
	}

	private void ResetTween()
	{
	}

	public GameObject GetGenerated()
	{
		return null;
	}

	public void ToggleHidden()
	{
	}

	public void ToggleLocked()
	{
	}

	public bool IsAnimating()
	{
		return false;
	}

	public void DragOver()
	{
	}

	public void DragOut()
	{
	}

	public void CleanHoverPress()
	{
	}

	public void CleanPress(DioramaObject _dioramaObject, Vector3 _position)
	{
	}

	public void PlayVacuumSound()
	{
	}

	public void PreparePlant()
	{
	}

	public void DroopEffect(int _submeshIndex = 0, float _droop = 1f)
	{
	}
}
