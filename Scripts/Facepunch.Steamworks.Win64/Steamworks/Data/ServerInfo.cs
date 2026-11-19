using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.Data;

public struct ServerInfo : IEquatable<ServerInfo>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CQueryRulesAsync_003Ed__85 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Dictionary<string, string>> _003C_003Et__builder;

		public ServerInfo _003C_003E4__this;

		private TaskAwaiter<Dictionary<string, string>> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private string[] _tags = null;

	internal const uint k_unFavoriteFlagNone = 0u;

	internal const uint k_unFavoriteFlagFavorite = 1u;

	internal const uint k_unFavoriteFlagHistory = 2u;

	public string Name { get; set; } = null;

	public int Ping { get; set; } = 0;

	public string GameDir { get; set; } = null;

	public string Map { get; set; } = null;

	public string Description { get; set; } = null;

	public uint AppId { get; set; } = 0u;

	public int Players { get; set; } = 0;

	public int MaxPlayers { get; set; } = 0;

	public int BotPlayers { get; set; } = 0;

	public bool Passworded { get; set; } = false;

	public bool Secure { get; set; } = false;

	public uint LastTimePlayed { get; set; } = 0u;

	public int Version { get; set; } = 0;

	public string TagString { get; set; } = null;

	public ulong SteamId { get; set; } = 0uL;

	public uint AddressRaw { get; set; } = 0u;

	public IPAddress Address { get; set; } = null;

	public int ConnectionPort { get; set; } = 0;

	public int QueryPort { get; set; } = 0;

	public string[] Tags => null;

	internal static ServerInfo From(gameserveritem_t item)
	{
		return default;
	}

	public ServerInfo(uint ip, ushort cport, ushort qport, uint timeplayed)
	{
	}

	public void AddToHistory()
	{
	}

	[AsyncStateMachine(typeof(_003CQueryRulesAsync_003Ed__85))]
	public Task<Dictionary<string, string>> QueryRulesAsync()
	{
		return null;
	}

	public void RemoveFromHistory()
	{
	}

	public void AddToFavourites()
	{
	}

	public void RemoveFromFavourites()
	{
	}

	public bool Equals(ServerInfo other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
