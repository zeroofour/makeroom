using UnityEngine;

namespace Mirror.Examples.CharacterSelection;

[AddComponentMenu(null)]
public class NetworkManagerCharacterSelection : NetworkManager
{
	public struct CreateCharacterMessage : NetworkMessage
	{
		public string playerName;

		public int characterNumber;

		public Color characterColour;
	}

	public struct ReplaceCharacterMessage : NetworkMessage
	{
		public CreateCharacterMessage createCharacterMessage;
	}

	public bool SpawnAsCharacter;

	private CharacterData characterData;

	public new static NetworkManagerCharacterSelection singleton => null;

	public override void Awake()
	{
	}

	public override void OnStartServer()
	{
	}

	public override void OnClientConnect()
	{
	}

	private void OnCreateCharacter(NetworkConnectionToClient conn, CreateCharacterMessage message)
	{
	}

	private void OnReplaceCharacterMessage(NetworkConnectionToClient conn, ReplaceCharacterMessage message)
	{
	}

	public void ReplaceCharacter(ReplaceCharacterMessage message)
	{
	}
}
