using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mirror.Transports.Encryption;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/encryption-transport")]
public class EncryptionTransport : Transport, PortTransport
{
	public enum ValidationMode
	{
		Off = 0,
		List = 1,
		Callback = 2
	}

	[FormerlySerializedAs("inner")]
	[HideInInspector]
	public Transport Inner;

	[FormerlySerializedAs("clientValidateServerPubKey")]
	[HideInInspector]
	public ValidationMode ClientValidateServerPubKey;

	[FormerlySerializedAs("clientTrustedPubKeySignatures")]
	[HideInInspector]
	[Tooltip("List of public key fingerprints the client will accept")]
	public string[] ClientTrustedPubKeySignatures;

	public Func<PubKeyInfo, bool> OnClientValidateServerPubKey;

	[HideInInspector]
	[FormerlySerializedAs("serverLoadKeyPairFromFile")]
	public bool ServerLoadKeyPairFromFile;

	[HideInInspector]
	[FormerlySerializedAs("serverKeypairPath")]
	public string ServerKeypairPath;

	private EncryptedConnection client;

	private readonly Dictionary<int, EncryptedConnection> serverConnections;

	private readonly List<EncryptedConnection> serverPendingConnections;

	private EncryptionCredentials credentials;

	public override bool IsEncrypted => false;

	public override string EncryptionCipher => null;

	public ushort Port
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string EncryptionPublicKeyFingerprint => null;

	public byte[] EncryptionPublicKey => null;

	private void ServerRemoveFromPending(EncryptedConnection con)
	{
	}

	private void HandleInnerServerDisconnected(int connId)
	{
	}

	private void HandleInnerServerError(int connId, TransportError type, string msg)
	{
	}

	private void HandleInnerServerDataReceived(int connId, ArraySegment<byte> data, int channel)
	{
	}

	private void HandleInnerServerConnected(int connId)
	{
	}

	private void HandleInnerServerConnected(int connId, string clientRemoteAddress)
	{
	}

	private void HandleInnerClientDisconnected()
	{
	}

	private void HandleInnerClientError(TransportError arg1, string arg2)
	{
	}

	private void HandleInnerClientDataReceived(ArraySegment<byte> data, int channel)
	{
	}

	private void HandleInnerClientConnected()
	{
	}

	private bool HandleClientValidateServerPubKey(PubKeyInfo pubKeyInfo)
	{
		return false;
	}

	private void Awake()
	{
	}

	public override bool Available()
	{
		return false;
	}

	public override bool ClientConnected()
	{
		return false;
	}

	public override void ClientConnect(string address)
	{
	}

	public override void ClientSend(ArraySegment<byte> segment, int channelId = 0)
	{
	}

	public override void ClientDisconnect()
	{
	}

	public override Uri ServerUri()
	{
		return null;
	}

	public override bool ServerActive()
	{
		return false;
	}

	public override void ServerStart()
	{
	}

	public override void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId = 0)
	{
	}

	public override void ServerDisconnect(int connectionId)
	{
	}

	public override string ServerGetClientAddress(int connectionId)
	{
		return null;
	}

	public override void ServerStop()
	{
	}

	public override int GetMaxPacketSize(int channelId = 0)
	{
		return 0;
	}

	public override int GetBatchThreshold(int channelId = 0)
	{
		return 0;
	}

	public override void Shutdown()
	{
	}

	public override void ClientEarlyUpdate()
	{
	}

	public override void ClientLateUpdate()
	{
	}

	public override void ServerEarlyUpdate()
	{
	}

	public override void ServerLateUpdate()
	{
	}
}
