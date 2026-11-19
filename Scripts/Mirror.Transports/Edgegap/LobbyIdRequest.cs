using System;

namespace Edgegap;

[Serializable]
public struct LobbyIdRequest(string lobbyId)
{
	public string lobby_id = null;
}
