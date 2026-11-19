using System.Runtime.InteropServices;
using Mirror.Discovery;
using Mirror.Examples.CharacterSelection;
using Mirror.Examples.Chat;
using Mirror.Examples.MultipleMatch;
using Mirror.Examples.PickupsDropsChilds;
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

	public static ServerRequest _Read_Mirror_002EDiscovery_002EServerRequest(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EDiscovery_002EServerRequest(NetworkWriter writer, ServerRequest value)
	{
	}

	public static ServerResponse _Read_Mirror_002EDiscovery_002EServerResponse(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EDiscovery_002EServerResponse(NetworkWriter writer, ServerResponse value)
	{
	}

	public static ServerMatchMessage _Read_Mirror_002EExamples_002EMultipleMatch_002EServerMatchMessage(NetworkReader reader)
	{
		return default;
	}

	public static ServerMatchOperation _Read_Mirror_002EExamples_002EMultipleMatch_002EServerMatchOperation(NetworkReader reader)
	{
		return ServerMatchOperation.None;
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EServerMatchMessage(NetworkWriter writer, ServerMatchMessage value)
	{
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EServerMatchOperation(NetworkWriter writer, ServerMatchOperation value)
	{
	}

	public static ClientMatchMessage _Read_Mirror_002EExamples_002EMultipleMatch_002EClientMatchMessage(NetworkReader reader)
	{
		return default;
	}

	public static ClientMatchOperation _Read_Mirror_002EExamples_002EMultipleMatch_002EClientMatchOperation(NetworkReader reader)
	{
		return ClientMatchOperation.None;
	}

	public static MatchInfo[] _Read_Mirror_002EExamples_002EMultipleMatch_002EMatchInfo_005B_005D(NetworkReader reader)
	{
		return null;
	}

	public static MatchInfo _Read_Mirror_002EExamples_002EMultipleMatch_002EMatchInfo(NetworkReader reader)
	{
		return default;
	}

	public static PlayerInfo[] _Read_Mirror_002EExamples_002EMultipleMatch_002EPlayerInfo_005B_005D(NetworkReader reader)
	{
		return null;
	}

	public static PlayerInfo _Read_Mirror_002EExamples_002EMultipleMatch_002EPlayerInfo(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EClientMatchMessage(NetworkWriter writer, ClientMatchMessage value)
	{
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EClientMatchOperation(NetworkWriter writer, ClientMatchOperation value)
	{
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EMatchInfo_005B_005D(NetworkWriter writer, MatchInfo[] value)
	{
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EMatchInfo(NetworkWriter writer, MatchInfo value)
	{
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EPlayerInfo_005B_005D(NetworkWriter writer, PlayerInfo[] value)
	{
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EPlayerInfo(NetworkWriter writer, PlayerInfo value)
	{
	}

	public static ChatAuthenticator.AuthRequestMessage _Read_Mirror_002EExamples_002EChat_002EChatAuthenticator_002FAuthRequestMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EExamples_002EChat_002EChatAuthenticator_002FAuthRequestMessage(NetworkWriter writer, ChatAuthenticator.AuthRequestMessage value)
	{
	}

	public static ChatAuthenticator.AuthResponseMessage _Read_Mirror_002EExamples_002EChat_002EChatAuthenticator_002FAuthResponseMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EExamples_002EChat_002EChatAuthenticator_002FAuthResponseMessage(NetworkWriter writer, ChatAuthenticator.AuthResponseMessage value)
	{
	}

	public static NetworkManagerCharacterSelection.CreateCharacterMessage _Read_Mirror_002EExamples_002ECharacterSelection_002ENetworkManagerCharacterSelection_002FCreateCharacterMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EExamples_002ECharacterSelection_002ENetworkManagerCharacterSelection_002FCreateCharacterMessage(NetworkWriter writer, NetworkManagerCharacterSelection.CreateCharacterMessage value)
	{
	}

	public static NetworkManagerCharacterSelection.ReplaceCharacterMessage _Read_Mirror_002EExamples_002ECharacterSelection_002ENetworkManagerCharacterSelection_002FReplaceCharacterMessage(NetworkReader reader)
	{
		return default;
	}

	public static void _Write_Mirror_002EExamples_002ECharacterSelection_002ENetworkManagerCharacterSelection_002FReplaceCharacterMessage(NetworkWriter writer, NetworkManagerCharacterSelection.ReplaceCharacterMessage value)
	{
	}

	public static void _Write_Mirror_002EExamples_002EPickupsDropsChilds_002EEquippedItem(NetworkWriter writer, EquippedItem value)
	{
	}

	public static EquippedItem _Read_Mirror_002EExamples_002EPickupsDropsChilds_002EEquippedItem(NetworkReader reader)
	{
		return EquippedItem.nothing;
	}

	public static void _Write_Mirror_002EExamples_002EPickupsDropsChilds_002EEquippedItemConfig(NetworkWriter writer, EquippedItemConfig value)
	{
	}

	public static EquippedItemConfig _Read_Mirror_002EExamples_002EPickupsDropsChilds_002EEquippedItemConfig(NetworkReader reader)
	{
		return default;
	}

	public static MatchPlayerData _Read_Mirror_002EExamples_002EMultipleMatch_002EMatchPlayerData(NetworkReader reader)
	{
		return default;
	}

	public static CellValue _Read_Mirror_002EExamples_002EMultipleMatch_002ECellValue(NetworkReader reader)
	{
		return CellValue.None;
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002EMatchPlayerData(NetworkWriter writer, MatchPlayerData value)
	{
	}

	public static void _Write_Mirror_002EExamples_002EMultipleMatch_002ECellValue(NetworkWriter writer, CellValue value)
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	public static void InitReadWriters()
	{
	}
}
