using System;
using UnityEngine;
using UnityEngine.Networking;

namespace Edgegap;

public class LobbyApi
{
	private struct CreateLobbyServiceRequest
	{
		public string name;
	}

	public struct LobbyServiceResponse
	{
		public string name;

		public string url;

		public string status;
	}

	[Header("Lobby Config")]
	public string LobbyUrl;

	public LobbyBrief[] Lobbies;

	public LobbyApi(string url)
	{
	}

	private static UnityWebRequest SendJson<T>(string url, T data, string method = "POST")
	{
		return null;
	}

	private static bool CheckErrorResponse(UnityWebRequest request, Action<string> onError)
	{
		return false;
	}

	public void RefreshLobbies(Action<LobbyBrief[]> onLoaded, Action<string> onError)
	{
	}

	public void CreateLobby(LobbyCreateRequest createData, Action<Lobby> onResponse, Action<string> onError)
	{
	}

	public void UpdateLobby(string lobbyId, LobbyUpdateRequest updateData, Action<LobbyBrief> onResponse, Action<string> onError)
	{
	}

	public void GetLobby(string lobbyId, Action<Lobby> onResponse, Action<string> onError)
	{
	}

	public void JoinLobby(LobbyJoinOrLeaveRequest data, Action onResponse, Action<string> onError)
	{
	}

	public void LeaveLobby(LobbyJoinOrLeaveRequest data, Action onResponse, Action<string> onError)
	{
	}

	public void StartLobby(LobbyIdRequest data, Action onResponse, Action<string> onError)
	{
	}

	public void DeleteLobby(string lobbyId, Action onResponse, Action<string> onError)
	{
	}

	public static void TrimApiKey(ref string apiKey)
	{
	}

	public static void CreateAndDeployLobbyService(string apiKey, string name, Action<LobbyServiceResponse> onResponse, Action<string> onError)
	{
	}

	private static void CreateLobbyService(string apiKey, string name, Action<LobbyServiceResponse> onResponse, Action<string> onError)
	{
	}

	public static void GetLobbyService(string apiKey, string name, Action<LobbyServiceResponse?> onResponse, Action<string> onError)
	{
	}

	public static void TerminateLobbyService(string apiKey, string name, Action<LobbyServiceResponse> onResponse, Action<string> onError)
	{
	}

	private static void DeployLobbyService(string apiKey, string name, Action<LobbyServiceResponse> onResponse, Action<string> onError)
	{
	}
}
