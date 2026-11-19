using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using UnityEngine;
using UnityEngine.Serialization;
using kcp2k;

namespace Mirror.Transports.Encryption;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/encryption-transport")]
public class ThreadedEncryptionKcpTransport : ThreadedKcpTransport
{
	public enum ValidationMode
	{
		Off = 0,
		List = 1,
		Callback = 2
	}

	[HideInInspector]
	public ValidationMode ClientValidateServerPubKey;

	[Tooltip("List of public key fingerprints the client will accept")]
	[HideInInspector]
	public string[] ClientTrustedPubKeySignatures;

	public Func<PubKeyInfo, bool> OnClientValidateServerPubKey;

	[FormerlySerializedAs("serverLoadKeyPairFromFile")]
	[HideInInspector]
	public bool ServerLoadKeyPairFromFile;

	[FormerlySerializedAs("serverKeypairPath")]
	[HideInInspector]
	public string ServerKeypairPath;

	private EncryptedConnection encryptedClient;

	private readonly Dictionary<int, EncryptedConnection> serverConnections;

	private readonly List<EncryptedConnection> serverPendingConnections;

	private EncryptionCredentials credentials;

	private Stopwatch stopwatch;

	public override bool IsEncrypted => false;

	public override string EncryptionCipher => null;

	public string EncryptionPublicKeyFingerprint => null;

	public byte[] EncryptionPublicKey => null;

	public override string ToString()
	{
		return null;
	}

	private void ServerRemoveFromPending(EncryptedConnection con)
	{
	}

	private void HandleInnerServerDisconnected(int connId)
	{
	}

	private void HandleInnerServerDataReceived(int connId, ArraySegment<byte> data, int channel)
	{
	}

	private void HandleInnerServerConnected(int connId, IPEndPoint clientRemoteAddress)
	{
	}

	private void HandleInnerClientDisconnected()
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

	protected override void Awake()
	{
	}

	protected override void ThreadedClientConnect(string address)
	{
	}

	private bool SetupEncryptionForClient()
	{
		return false;
	}

	protected override void ThreadedClientConnect(Uri address)
	{
	}

	protected override void ThreadedClientSend(ArraySegment<byte> segment, int channelId)
	{
	}

	protected override void ThreadedServerStart()
	{
	}

	protected override void ThreadedServerSend(int connectionId, ArraySegment<byte> segment, int channelId)
	{
	}

	public override int GetMaxPacketSize(int channelId = 0)
	{
		return 0;
	}

	public override int GetBatchThreshold(int channelId)
	{
		return 0;
	}

	protected override void ThreadedClientLateUpdate()
	{
	}

	protected override void ThreadedServerLateUpdate()
	{
	}
}
