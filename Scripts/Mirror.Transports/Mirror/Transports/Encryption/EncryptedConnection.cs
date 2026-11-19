using System;
using System.Threading;
using Mirror.BouncyCastle.Crypto.Generators;
using Mirror.BouncyCastle.Crypto.Modes;
using Mirror.BouncyCastle.Crypto.Parameters;

namespace Mirror.Transports.Encryption;

public class EncryptedConnection
{
	private enum OpCodes : byte
	{
		Data = 1,
		HandshakeStart = 2,
		HandshakeAck = 3,
		HandshakeFin = 4
	}

	private enum State
	{
		WaitingHandshake = 0,
		WaitingHandshakeReply = 1,
		Ready = 2
	}

	private const int KeyLength = 32;

	private const int HkdfSaltSize = 64;

	private static readonly byte[] HkdfInfo;

	private const int NonceSize = 12;

	private const int MacSizeBytes = 16;

	private const int MacSizeBits = 128;

	public const int Overhead = 29;

	private const double DurationTimeout = 2.0;

	private const double DurationResend = 0.05;

	private static readonly ThreadLocal<GcmBlockCipher> Cipher;

	private static readonly ThreadLocal<HkdfBytesGenerator> Hkdf;

	private static readonly ThreadLocal<byte[]> ReceiveNonce;

	private static readonly ThreadLocal<byte[]> TMPRemoteSaltBuffer;

	private static ThreadLocal<byte[]> TMPCryptBuffer;

	private State state;

	private readonly Action<ArraySegment<byte>, int> send;

	private readonly Action<ArraySegment<byte>, int> receive;

	private readonly Action ready;

	private readonly Action<TransportError, string> error;

	private readonly Func<PubKeyInfo, bool> validateRemoteKey;

	private EncryptionCredentials credentials;

	private readonly byte[] hkdfSalt;

	private NetworkReader _tmpReader;

	private double handshakeTimeout;

	private double nextHandshakeResend;

	private byte[] nonce;

	private AeadParameters cipherParametersEncrypt;

	private AeadParameters cipherParametersDecrypt;

	private readonly bool sendsFirst;

	public bool IsReady => false;

	public EncryptedConnection(EncryptionCredentials credentials, bool isClient, Action<ArraySegment<byte>, int> sendAction, Action<ArraySegment<byte>, int> receiveAction, Action readyAction, Action<TransportError, string> errorAction, Func<PubKeyInfo, bool> validateRemoteKey = null)
	{
	}

	private static byte[] GenerateSecureBytes(int size)
	{
		return null;
	}

	public void OnReceiveRaw(ArraySegment<byte> data, int channel)
	{
	}

	private void SetReady()
	{
	}

	private void ResetTimeouts()
	{
	}

	public void Send(ArraySegment<byte> data, int channel)
	{
	}

	private ArraySegment<byte> Encrypt(ArraySegment<byte> plaintext)
	{
		return default;
	}

	private ArraySegment<byte> Decrypt(ArraySegment<byte> ciphertext)
	{
		return default;
	}

	private void UpdateNonce()
	{
	}

	private static void EnsureSize(ref byte[] buffer, int size)
	{
	}

	private void SendHandshakeAndPubKey(OpCodes opcode)
	{
	}

	private void SendHandshakeFin()
	{
	}

	private void CompleteExchange(ArraySegment<byte> remotePubKeyRaw, byte[] salt)
	{
	}

	public void TickNonReady(double time)
	{
	}
}
