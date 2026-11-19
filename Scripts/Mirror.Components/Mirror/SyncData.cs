using System;
using UnityEngine;

namespace Mirror;

[Serializable]
public struct SyncData
{
	public Changed changedDataByte = Changed.None;

	public Vector3 position = default;

	public Quaternion quatRotation = default;

	public Vector3 vecRotation = default;

	public Vector3 scale = default;

	public SyncData(Changed _dataChangedByte, Vector3 _position, Quaternion _rotation, Vector3 _scale)
	{
	}

	public SyncData(Changed _dataChangedByte, TransformSnapshot _snapshot)
	{
	}

	public SyncData(Changed _dataChangedByte, Vector3 _position, Vector3 _vecRotation, Vector3 _scale)
	{
	}
}
