using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
public class Animator : Behaviour
{
	public int layerCount => 0;

	public AnimatorControllerParameter[] parameters
	{
		[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public float speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool hasBoundPlayables
	{
		[NativeMethod("HasBoundPlayables")]
		get
		{
			return false;
		}
	}

	public float GetFloat(int id)
	{
		return 0f;
	}

	public void SetFloat(int id, float value)
	{
	}

	public bool GetBool(int id)
	{
		return false;
	}

	public void SetBool(string name, bool value)
	{
	}

	public void SetBool(int id, bool value)
	{
	}

	public int GetInteger(int id)
	{
		return 0;
	}

	public void SetInteger(int id, int value)
	{
	}

	public void SetTrigger(string name)
	{
	}

	public void SetTrigger(int id)
	{
	}

	public void ResetTrigger(string name)
	{
	}

	public void ResetTrigger(int id)
	{
	}

	public bool IsParameterControlledByCurve(int id)
	{
		return false;
	}

	public float GetLayerWeight(int layerIndex)
	{
		return 0f;
	}

	public void SetLayerWeight(int layerIndex, float weight)
	{
	}

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info)
	{
		info = default;
	}

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
	{
		return default;
	}

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
	{
		return default;
	}

	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info)
	{
		info = default;
	}

	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
	{
		return default;
	}

	public bool IsInTransition(int layerIndex)
	{
		return false;
	}

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
	public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
	{
	}

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
	public static int StringToHash(string name)
	{
		return 0;
	}

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = true)]
	private void SetFloatID(int id, float value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = true)]
	private float GetFloatID(int id)
	{
		return 0f;
	}

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
	private void SetBoolString(string name, bool value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
	private void SetBoolID(int id, bool value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = true)]
	private bool GetBoolID(int id)
	{
		return false;
	}

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = true)]
	private void SetIntegerID(int id, int value)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = true)]
	private int GetIntegerID(int id)
	{
		return 0;
	}

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
	private void SetTriggerString(string name)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = true)]
	private void SetTriggerID(int id)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
	private void ResetTriggerString(string name)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = true)]
	private void ResetTriggerID(int id)
	{
	}

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = true)]
	private bool IsParameterControlledByCurveID(int id)
	{
		return false;
	}
}
