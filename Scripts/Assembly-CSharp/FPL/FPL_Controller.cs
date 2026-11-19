using System.Collections.Generic;
using UnityEngine;

namespace FPL;

[RequireComponent(typeof(MeshRenderer))]
public class FPL_Controller : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer _mesh;

	private MaterialPropertyBlock _propertyBlock;

	private static readonly Dictionary<FPL_Properties, int> LightPropertiesDictionary;

	private bool initialized;

	static FPL_Controller()
	{
	}

	private void InitializeVariables()
	{
	}

	private bool MeshCheck()
	{
		return false;
	}

	private void Awake()
	{
	}

	public void SetProperty(FPL_Properties lightProperty, float value)
	{
	}

	public void SetProperty(FPL_Properties lightProperty, Color value)
	{
	}

	public MaterialPropertyBlock GetPropertyBlock()
	{
		return null;
	}

	public void SetPropertyBlock(MaterialPropertyBlock propertyBlock)
	{
	}

	public void ApplySettings()
	{
	}
}
