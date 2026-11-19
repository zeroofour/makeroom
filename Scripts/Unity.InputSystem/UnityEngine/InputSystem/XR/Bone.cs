namespace UnityEngine.InputSystem.XR;

public struct Bone
{
	public uint m_ParentBoneIndex;

	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public uint parentBoneIndex
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public Vector3 position
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Quaternion rotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}
}
