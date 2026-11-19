using System;
using System.Collections.Generic;
using UnityEngine;

namespace Mirror;

public static class NetworkWriterExtensions
{
	public static void WriteByte(this NetworkWriter writer, byte value)
	{
	}

	public static void WriteByteNullable(this NetworkWriter writer, byte? value)
	{
	}

	public static void WriteSByte(this NetworkWriter writer, sbyte value)
	{
	}

	public static void WriteSByteNullable(this NetworkWriter writer, sbyte? value)
	{
	}

	public static void WriteChar(this NetworkWriter writer, char value)
	{
	}

	public static void WriteCharNullable(this NetworkWriter writer, char? value)
	{
	}

	public static void WriteBool(this NetworkWriter writer, bool value)
	{
	}

	public static void WriteBoolNullable(this NetworkWriter writer, bool? value)
	{
	}

	public static void WriteShort(this NetworkWriter writer, short value)
	{
	}

	public static void WriteShortNullable(this NetworkWriter writer, short? value)
	{
	}

	public static void WriteUShort(this NetworkWriter writer, ushort value)
	{
	}

	public static void WriteUShortNullable(this NetworkWriter writer, ushort? value)
	{
	}

	public static void WriteInt(this NetworkWriter writer, int value)
	{
	}

	public static void WriteIntNullable(this NetworkWriter writer, int? value)
	{
	}

	public static void WriteUInt(this NetworkWriter writer, uint value)
	{
	}

	public static void WriteUIntNullable(this NetworkWriter writer, uint? value)
	{
	}

	public static void WriteLong(this NetworkWriter writer, long value)
	{
	}

	public static void WriteLongNullable(this NetworkWriter writer, long? value)
	{
	}

	public static void WriteULong(this NetworkWriter writer, ulong value)
	{
	}

	public static void WriteULongNullable(this NetworkWriter writer, ulong? value)
	{
	}

	[WeaverPriority]
	public static void WriteVarInt(this NetworkWriter writer, int value)
	{
	}

	[WeaverPriority]
	public static void WriteVarUInt(this NetworkWriter writer, uint value)
	{
	}

	[WeaverPriority]
	public static void WriteVarLong(this NetworkWriter writer, long value)
	{
	}

	[WeaverPriority]
	public static void WriteVarULong(this NetworkWriter writer, ulong value)
	{
	}

	public static void WriteFloat(this NetworkWriter writer, float value)
	{
	}

	public static void WriteFloatNullable(this NetworkWriter writer, float? value)
	{
	}

	public static void WriteDouble(this NetworkWriter writer, double value)
	{
	}

	public static void WriteDoubleNullable(this NetworkWriter writer, double? value)
	{
	}

	public static void WriteDecimal(this NetworkWriter writer, decimal value)
	{
	}

	public static void WriteDecimalNullable(this NetworkWriter writer, decimal? value)
	{
	}

	public static void WriteHalf(this NetworkWriter writer, Half value)
	{
	}

	public static void WriteString(this NetworkWriter writer, string value)
	{
	}

	public static void WriteBytesAndSize(this NetworkWriter writer, byte[] buffer)
	{
	}

	public static void WriteBytesAndSize(this NetworkWriter writer, byte[] buffer, int offset, int count)
	{
	}

	public static void WriteArraySegmentAndSize(this NetworkWriter writer, ArraySegment<byte> segment)
	{
	}

	public static void WriteArraySegment<T>(this NetworkWriter writer, ArraySegment<T> segment)
	{
	}

	public static void WriteVector2(this NetworkWriter writer, Vector2 value)
	{
	}

	public static void WriteVector2Nullable(this NetworkWriter writer, Vector2? value)
	{
	}

	public static void WriteVector3(this NetworkWriter writer, Vector3 value)
	{
	}

	public static void WriteVector3Nullable(this NetworkWriter writer, Vector3? value)
	{
	}

	public static void WriteVector4(this NetworkWriter writer, Vector4 value)
	{
	}

	public static void WriteVector4Nullable(this NetworkWriter writer, Vector4? value)
	{
	}

	public static void WriteVector2Int(this NetworkWriter writer, Vector2Int value)
	{
	}

	public static void WriteVector2IntNullable(this NetworkWriter writer, Vector2Int? value)
	{
	}

	public static void WriteVector3Int(this NetworkWriter writer, Vector3Int value)
	{
	}

	public static void WriteVector3IntNullable(this NetworkWriter writer, Vector3Int? value)
	{
	}

	public static void WriteColor(this NetworkWriter writer, Color value)
	{
	}

	public static void WriteColorNullable(this NetworkWriter writer, Color? value)
	{
	}

	public static void WriteColor32(this NetworkWriter writer, Color32 value)
	{
	}

	public static void WriteColor32Nullable(this NetworkWriter writer, Color32? value)
	{
	}

	public static void WriteQuaternion(this NetworkWriter writer, Quaternion value)
	{
	}

	public static void WriteQuaternionNullable(this NetworkWriter writer, Quaternion? value)
	{
	}

	public static void WriteRect(this NetworkWriter writer, Rect value)
	{
	}

	public static void WriteRectNullable(this NetworkWriter writer, Rect? value)
	{
	}

	public static void WritePlane(this NetworkWriter writer, Plane value)
	{
	}

	public static void WritePlaneNullable(this NetworkWriter writer, Plane? value)
	{
	}

	public static void WriteRay(this NetworkWriter writer, Ray value)
	{
	}

	public static void WriteRayNullable(this NetworkWriter writer, Ray? value)
	{
	}

	public static void WriteLayerMask(this NetworkWriter writer, LayerMask layerMask)
	{
	}

	public static void WriteLayerMaskNullable(this NetworkWriter writer, LayerMask? layerMask)
	{
	}

	public static void WriteMatrix4x4(this NetworkWriter writer, Matrix4x4 value)
	{
	}

	public static void WriteMatrix4x4Nullable(this NetworkWriter writer, Matrix4x4? value)
	{
	}

	public static void WriteGuid(this NetworkWriter writer, Guid value)
	{
	}

	public static void WriteGuidNullable(this NetworkWriter writer, Guid? value)
	{
	}

	public static void WriteNetworkIdentity(this NetworkWriter writer, NetworkIdentity value)
	{
	}

	public static void WriteNetworkBehaviour(this NetworkWriter writer, NetworkBehaviour value)
	{
	}

	public static void WriteTransform(this NetworkWriter writer, Transform value)
	{
	}

	public static void WriteGameObject(this NetworkWriter writer, GameObject value)
	{
	}

	public static void WriteList<T>(this NetworkWriter writer, List<T> list)
	{
	}

	public static void WriteHashSet<T>(this NetworkWriter writer, HashSet<T> hashSet)
	{
	}

	public static void WriteArray<T>(this NetworkWriter writer, T[] array)
	{
	}

	public static void WriteUri(this NetworkWriter writer, Uri uri)
	{
	}

	public static void WriteTexture2D(this NetworkWriter writer, Texture2D texture2D)
	{
	}

	public static void WriteSprite(this NetworkWriter writer, Sprite sprite)
	{
	}

	public static void WriteDateTime(this NetworkWriter writer, DateTime dateTime)
	{
	}

	public static void WriteDateTimeNullable(this NetworkWriter writer, DateTime? dateTime)
	{
	}
}
