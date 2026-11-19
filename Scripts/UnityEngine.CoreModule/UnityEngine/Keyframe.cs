using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
public struct Keyframe
{
	private float m_Time = 0f;

	private float m_Value = 0f;

	private float m_InTangent = 0f;

	private float m_OutTangent = 0f;

	private int m_WeightedMode = 0;

	private float m_InWeight = 0f;

	private float m_OutWeight = 0f;

	public float time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float value => 0f;

	public float inTangent => 0f;

	public float outTangent => 0f;

	public Keyframe(float time, float value)
	{
	}

	public Keyframe(float time, float value, float inTangent, float outTangent)
	{
	}
}
