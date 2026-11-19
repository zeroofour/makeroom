using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

public static class NetworkReaderExtensions
{
	public static byte ReadByte(this NetworkReader reader)
	{
		return 0;
	}

	public static byte? ReadByteNullable(this NetworkReader reader)
	{
		return null;
	}

	public static sbyte ReadSByte(this NetworkReader reader)
	{
		return 0;
	}

	public static sbyte? ReadSByteNullable(this NetworkReader reader)
	{
		return null;
	}

	public static char ReadChar(this NetworkReader reader)
	{
		return '\0';
	}

	public static char? ReadCharNullable(this NetworkReader reader)
	{
		return null;
	}

	public static bool ReadBool(this NetworkReader reader)
	{
		return false;
	}

	public static bool? ReadBoolNullable(this NetworkReader reader)
	{
		return null;
	}

	public static short ReadShort(this NetworkReader reader)
	{
		return 0;
	}

	public static short? ReadShortNullable(this NetworkReader reader)
	{
		return null;
	}

	public static ushort ReadUShort(this NetworkReader reader)
	{
		return 0;
	}

	public static ushort? ReadUShortNullable(this NetworkReader reader)
	{
		return null;
	}

	public static int ReadInt(this NetworkReader reader)
	{
		return 0;
	}

	public static int? ReadIntNullable(this NetworkReader reader)
	{
		return null;
	}

	public static uint ReadUInt(this NetworkReader reader)
	{
		return 0u;
	}

	public static uint? ReadUIntNullable(this NetworkReader reader)
	{
		return null;
	}

	public static long ReadLong(this NetworkReader reader)
	{
		return 0L;
	}

	public static long? ReadLongNullable(this NetworkReader reader)
	{
		return null;
	}

	public static ulong ReadULong(this NetworkReader reader)
	{
		return 0uL;
	}

	public static ulong? ReadULongNullable(this NetworkReader reader)
	{
		return null;
	}

	[WeaverPriority]
	public static int ReadVarInt(this NetworkReader reader)
	{
		return 0;
	}

	[WeaverPriority]
	public static uint ReadVarUInt(this NetworkReader reader)
	{
		return 0u;
	}

	[WeaverPriority]
	public static long ReadVarLong(this NetworkReader reader)
	{
		return 0L;
	}

	[WeaverPriority]
	public static ulong ReadVarULong(this NetworkReader reader)
	{
		return 0uL;
	}

	public static float ReadFloat(this NetworkReader reader)
	{
		return 0f;
	}

	public static float? ReadFloatNullable(this NetworkReader reader)
	{
		return null;
	}

	public static double ReadDouble(this NetworkReader reader)
	{
		return 0.0;
	}

	public static double? ReadDoubleNullable(this NetworkReader reader)
	{
		return null;
	}

	public static decimal ReadDecimal(this NetworkReader reader)
	{
		return 0m;
	}

	public static decimal? ReadDecimalNullable(this NetworkReader reader)
	{
		return null;
	}

	public static Half ReadHalf(this NetworkReader reader)
	{
		return default;
	}

	public static string ReadString(this NetworkReader reader)
	{
		return null;
	}

	public static byte[] ReadBytes(this NetworkReader reader, int count)
	{
		return null;
	}

	public static byte[] ReadBytesAndSize(this NetworkReader reader)
	{
		return null;
	}

	public static ArraySegment<byte> ReadArraySegmentAndSize(this NetworkReader reader)
	{
		return default;
	}

	public static Vector2 ReadVector2(this NetworkReader reader)
	{
		return default;
	}

	public static Vector2? ReadVector2Nullable(this NetworkReader reader)
	{
		return null;
	}

	public static Vector3 ReadVector3(this NetworkReader reader)
	{
		return default;
	}

	public static Vector3? ReadVector3Nullable(this NetworkReader reader)
	{
		return null;
	}

	public static Vector4 ReadVector4(this NetworkReader reader)
	{
		return default;
	}

	public static Vector4? ReadVector4Nullable(this NetworkReader reader)
	{
		return null;
	}

	public static Vector2Int ReadVector2Int(this NetworkReader reader)
	{
		return default;
	}

	public static Vector2Int? ReadVector2IntNullable(this NetworkReader reader)
	{
		return null;
	}

	public static Vector3Int ReadVector3Int(this NetworkReader reader)
	{
		return default;
	}

	public static Vector3Int? ReadVector3IntNullable(this NetworkReader reader)
	{
		return null;
	}

	public static Color ReadColor(this NetworkReader reader)
	{
		return default;
	}

	public static Color? ReadColorNullable(this NetworkReader reader)
	{
		return null;
	}

	public static Color32 ReadColor32(this NetworkReader reader)
	{
		return default;
	}

	public static Color32? ReadColor32Nullable(this NetworkReader reader)
	{
		return null;
	}

	public static Quaternion ReadQuaternion(this NetworkReader reader)
	{
		return default;
	}

	public static Quaternion? ReadQuaternionNullable(this NetworkReader reader)
	{
		return null;
	}

	public static Rect ReadRect(this NetworkReader reader)
	{
		return default;
	}

	public static Rect? ReadRectNullable(this NetworkReader reader)
	{
		return null;
	}

	public static Plane ReadPlane(this NetworkReader reader)
	{
		return default;
	}

	public static Plane? ReadPlaneNullable(this NetworkReader reader)
	{
		return null;
	}

	public static Ray ReadRay(this NetworkReader reader)
	{
		return default;
	}

	public static Ray? ReadRayNullable(this NetworkReader reader)
	{
		return null;
	}

	public static LayerMask ReadLayerMask(this NetworkReader reader)
	{
		return default;
	}

	public static LayerMask? ReadLayerMaskNullable(this NetworkReader reader)
	{
		return null;
	}

	public static Matrix4x4 ReadMatrix4x4(this NetworkReader reader)
	{
		return default;
	}

	public static Matrix4x4? ReadMatrix4x4Nullable(this NetworkReader reader)
	{
		return null;
	}

	public static Guid ReadGuid(this NetworkReader reader)
	{
		return default;
	}

	public static Guid? ReadGuidNullable(this NetworkReader reader)
	{
		return null;
	}

	public static NetworkIdentity ReadNetworkIdentity(this NetworkReader reader)
	{
		return null;
	}

	public static NetworkBehaviour ReadNetworkBehaviour(this NetworkReader reader)
	{
		return null;
	}

	public static T ReadNetworkBehaviour<T>(this NetworkReader reader) where T : NetworkBehaviour
	{
		return null;
	}

	public static NetworkBehaviourSyncVar ReadNetworkBehaviourSyncVar(this NetworkReader reader)
	{
		return default;
	}

	public static Transform ReadTransform(this NetworkReader reader)
	{
		return null;
	}

	public static GameObject ReadGameObject(this NetworkReader reader)
	{
		return null;
	}

	public static List<T> ReadList<T>(this NetworkReader reader)
	{
		return null;
	}

	public static HashSet<T> ReadHashSet<T>(this NetworkReader reader)
	{
		return null;
	}

	public static T[] ReadArray<T>(this NetworkReader reader)
	{
		return null;
	}

	public static Uri ReadUri(this NetworkReader reader)
	{
		return null;
	}

	public static Texture2D ReadTexture2D(this NetworkReader reader)
	{
		return null;
	}

	public static Sprite ReadSprite(this NetworkReader reader)
	{
		return null;
	}

	public static DateTime ReadDateTime(this NetworkReader reader)
	{
		return default;
	}

	public static DateTime? ReadDateTimeNullable(this NetworkReader reader)
	{
		return null;
	}
}
