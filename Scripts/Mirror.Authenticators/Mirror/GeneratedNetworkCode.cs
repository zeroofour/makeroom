using System.Runtime.InteropServices;
using Mirror.Authenticators;
using UnityEngine;

namespace Mirror;

[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
public static class GeneratedNetworkCode
{
	public static TimeSnapshotMessage _Read_Mirror_002ETimeSnapshotMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002ETimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value)
	{
	}

	public static ReadyMessage _Read_Mirror_002EReadyMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EReadyMessage(NetworkWriter writer, ReadyMessage value)
	{
	}

	public static NotReadyMessage _Read_Mirror_002ENotReadyMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002ENotReadyMessage(NetworkWriter writer, NotReadyMessage value)
	{
	}

	public static AddPlayerMessage _Read_Mirror_002EAddPlayerMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EAddPlayerMessage(NetworkWriter writer, AddPlayerMessage value)
	{
	}

	public static SceneMessage _Read_Mirror_002ESceneMessage(NetworkReader reader)
	{
		return default;
	}

	public static SceneOperation _Read_Mirror_002ESceneOperation(NetworkReader reader)
	{
		return SceneOperation.Normal;
	}

	public static void _Write_Mirror_002ESceneMessage(NetworkWriter writer, SceneMessage value)
	{
	}

	public static void _Write_Mirror_002ESceneOperation(NetworkWriter writer, SceneOperation value)
	{
	}

	public static CommandMessage _Read_Mirror_002ECommandMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002ECommandMessage(NetworkWriter writer, CommandMessage value)
	{
	}

	public static RpcMessage _Read_Mirror_002ERpcMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002ERpcMessage(NetworkWriter writer, RpcMessage value)
	{
	}

	public static SpawnMessage _Read_Mirror_002ESpawnMessage(NetworkReader reader)
	{
		return default;
	}

	public static SpawnFlags _Read_Mirror_002ESpawnFlags(NetworkReader reader)
	{
		return SpawnFlags.None;
	}

	public static void _Write_Mirror_002ESpawnMessage(NetworkWriter writer, SpawnMessage value)
	{
	}

	public static void _Write_Mirror_002ESpawnFlags(NetworkWriter writer, SpawnFlags value)
	{
	}

	public static ChangeOwnerMessage _Read_Mirror_002EChangeOwnerMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value)
	{
	}

	public static ObjectSpawnStartedMessage _Read_Mirror_002EObjectSpawnStartedMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value)
	{
	}

	public static ObjectSpawnFinishedMessage _Read_Mirror_002EObjectSpawnFinishedMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value)
	{
	}

	public static ObjectDestroyMessage _Read_Mirror_002EObjectDestroyMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value)
	{
	}

	public static ObjectHideMessage _Read_Mirror_002EObjectHideMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EObjectHideMessage(NetworkWriter writer, ObjectHideMessage value)
	{
	}

	public static EntityStateMessage _Read_Mirror_002EEntityStateMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EEntityStateMessage(NetworkWriter writer, EntityStateMessage value)
	{
	}

	public static NetworkPingMessage _Read_Mirror_002ENetworkPingMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002ENetworkPingMessage(NetworkWriter writer, NetworkPingMessage value)
	{
	}

	public static NetworkPongMessage _Read_Mirror_002ENetworkPongMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002ENetworkPongMessage(NetworkWriter writer, NetworkPongMessage value)
	{
	}

	public static BasicAuthenticator.AuthRequestMessage _Read_Mirror_002EAuthenticators_002EBasicAuthenticator_002FAuthRequestMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EAuthenticators_002EBasicAuthenticator_002FAuthRequestMessage(NetworkWriter writer, BasicAuthenticator.AuthRequestMessage value)
	{
	}

	public static BasicAuthenticator.AuthResponseMessage _Read_Mirror_002EAuthenticators_002EBasicAuthenticator_002FAuthResponseMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EAuthenticators_002EBasicAuthenticator_002FAuthResponseMessage(NetworkWriter writer, BasicAuthenticator.AuthResponseMessage value)
	{
	}

	public static DeviceAuthenticator.AuthRequestMessage _Read_Mirror_002EAuthenticators_002EDeviceAuthenticator_002FAuthRequestMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EAuthenticators_002EDeviceAuthenticator_002FAuthRequestMessage(NetworkWriter writer, DeviceAuthenticator.AuthRequestMessage value)
	{
	}

	public static DeviceAuthenticator.AuthResponseMessage _Read_Mirror_002EAuthenticators_002EDeviceAuthenticator_002FAuthResponseMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EAuthenticators_002EDeviceAuthenticator_002FAuthResponseMessage(NetworkWriter writer, DeviceAuthenticator.AuthResponseMessage value)
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	public static void InitReadWriters()
	{
	}
}
