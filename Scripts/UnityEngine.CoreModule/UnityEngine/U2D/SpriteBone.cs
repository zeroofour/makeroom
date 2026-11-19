using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D;

[Serializable]
[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[MovedFrom("UnityEngine.Experimental.U2D")]
[RequiredByNativeCode]
[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
public struct SpriteBone
{
	[NativeName("name")]
	[SerializeField]
	private string m_Name;

	[SerializeField]
	[NativeName("guid")]
	private string m_Guid;

	[NativeName("position")]
	[SerializeField]
	private Vector3 m_Position;

	[NativeName("rotation")]
	[SerializeField]
	private Quaternion m_Rotation;

	[SerializeField]
	[NativeName("length")]
	private float m_Length;

	[SerializeField]
	[NativeName("parentId")]
	private int m_ParentId;

	[SerializeField]
	[NativeName("color")]
	private Color32 m_Color;
}
