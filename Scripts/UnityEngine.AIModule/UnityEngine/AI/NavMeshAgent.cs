using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
public sealed class NavMeshAgent : Behaviour
{
	public Vector3 velocity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool isStopped
	{
		[FreeFunction("NavMeshAgentScriptBindings::SetIsStopped", HasExplicitThis = true)]
		set
		{
		}
	}

	public float speed => 0f;

	public bool SetDestination(Vector3 target)
	{
		return false;
	}

	private bool SetDestination_Injected(ref Vector3 target)
	{
		return false;
	}

	[SpecialName]
	private void get_velocity_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_velocity_Injected(ref Vector3 value)
	{
	}
}
