using System;

namespace Mirror.BouncyCastle.Asn1;

public abstract class Asn1Utilities
{
	internal static Asn1TaggedObject CheckContextTag(Asn1TaggedObject taggedObject, int tagNo)
	{
		return null;
	}

	internal static Asn1TaggedObjectParser CheckContextTag(Asn1TaggedObjectParser taggedObjectParser, int tagNo)
	{
		return null;
	}

	internal static Asn1TaggedObject CheckContextTagClass(Asn1TaggedObject taggedObject)
	{
		return null;
	}

	internal static Asn1TaggedObjectParser CheckContextTagClass(Asn1TaggedObjectParser taggedObjectParser)
	{
		return null;
	}

	internal static Asn1TaggedObject CheckTag(Asn1TaggedObject taggedObject, int tagClass, int tagNo)
	{
		return null;
	}

	internal static Asn1TaggedObjectParser CheckTag(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo)
	{
		return null;
	}

	internal static Asn1TaggedObject CheckTagClass(Asn1TaggedObject taggedObject, int tagClass)
	{
		return null;
	}

	internal static Asn1TaggedObjectParser CheckTagClass(Asn1TaggedObjectParser taggedObjectParser, int tagClass)
	{
		return null;
	}

	internal static TChoice GetInstanceFromChoice<TChoice>(Asn1TaggedObject taggedObject, bool declaredExplicit, Func<object, TChoice> constructor) where TChoice : Asn1Encodable, IAsn1Choice
	{
		return null;
	}

	internal static string GetTagClassText(Asn1Tag tag)
	{
		return null;
	}

	public static string GetTagClassText(Asn1TaggedObject taggedObject)
	{
		return null;
	}

	public static string GetTagClassText(Asn1TaggedObjectParser taggedObjectParser)
	{
		return null;
	}

	public static string GetTagClassText(int tagClass)
	{
		return null;
	}

	internal static string GetTagText(Asn1Tag tag)
	{
		return null;
	}

	public static string GetTagText(Asn1TaggedObject taggedObject)
	{
		return null;
	}

	public static string GetTagText(Asn1TaggedObjectParser taggedObjectParser)
	{
		return null;
	}

	public static string GetTagText(int tagClass, int tagNo)
	{
		return null;
	}

	public static Asn1Encodable GetExplicitBaseObject(Asn1TaggedObject taggedObject, int tagClass, int tagNo)
	{
		return null;
	}

	public static Asn1Encodable GetExplicitContextBaseObject(Asn1TaggedObject taggedObject, int tagNo)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	public static Asn1Encodable TryGetExplicitBaseObject(Asn1TaggedObject taggedObject, int tagClass, int tagNo)
	{
		return null;
	}

	public static bool TryGetExplicitBaseObject(Asn1TaggedObject taggedObject, int tagClass, int tagNo, out Asn1Encodable baseObject)
	{
		baseObject = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1Encodable TryGetExplicitContextBaseObject(Asn1TaggedObject taggedObject, int tagNo)
	{
		return null;
	}

	public static bool TryGetExplicitContextBaseObject(Asn1TaggedObject taggedObject, int tagNo, out Asn1Encodable baseObject)
	{
		baseObject = null;
		return false;
	}

	public static Asn1TaggedObject GetExplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass)
	{
		return null;
	}

	public static Asn1TaggedObject GetExplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass, int tagNo)
	{
		return null;
	}

	public static Asn1TaggedObject GetExplicitContextBaseTagged(Asn1TaggedObject taggedObject)
	{
		return null;
	}

	public static Asn1TaggedObject GetExplicitContextBaseTagged(Asn1TaggedObject taggedObject, int tagNo)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObject TryGetExplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass)
	{
		return null;
	}

	public static bool TryGetExplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass, out Asn1TaggedObject baseTagged)
	{
		baseTagged = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObject TryGetExplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass, int tagNo)
	{
		return null;
	}

	public static bool TryGetExplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass, int tagNo, out Asn1TaggedObject baseTagged)
	{
		baseTagged = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObject TryGetExplicitContextBaseTagged(Asn1TaggedObject taggedObject)
	{
		return null;
	}

	public static bool TryGetExplicitContextBaseTagged(Asn1TaggedObject taggedObject, out Asn1TaggedObject baseTagged)
	{
		baseTagged = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObject TryGetExplicitContextBaseTagged(Asn1TaggedObject taggedObject, int tagNo)
	{
		return null;
	}

	public static bool TryGetExplicitContextBaseTagged(Asn1TaggedObject taggedObject, int tagNo, out Asn1TaggedObject baseTagged)
	{
		baseTagged = null;
		return false;
	}

	public static Asn1TaggedObject GetImplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass, int tagNo, int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public static Asn1TaggedObject GetImplicitContextBaseTagged(Asn1TaggedObject taggedObject, int tagNo, int baseTagClass, int baseTagNo)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObject TryGetImplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass, int tagNo, int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public static bool TryGetImplicitBaseTagged(Asn1TaggedObject taggedObject, int tagClass, int tagNo, int baseTagClass, int baseTagNo, out Asn1TaggedObject baseTagged)
	{
		baseTagged = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObject TryGetImplicitContextBaseTagged(Asn1TaggedObject taggedObject, int tagNo, int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public static bool TryGetImplicitContextBaseTagged(Asn1TaggedObject taggedObject, int tagNo, int baseTagClass, int baseTagNo, out Asn1TaggedObject baseTagged)
	{
		baseTagged = null;
		return false;
	}

	public static Asn1Object GetBaseUniversal(Asn1TaggedObject taggedObject, int tagClass, int tagNo, bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public static Asn1Object GetContextBaseUniversal(Asn1TaggedObject taggedObject, int tagNo, bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	public static Asn1Object TryGetBaseUniversal(Asn1TaggedObject taggedObject, int tagClass, int tagNo, bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public static bool TryGetBaseUniversal(Asn1TaggedObject taggedObject, int tagClass, int tagNo, bool declaredExplicit, int baseTagNo, out Asn1Object baseUniversal)
	{
		baseUniversal = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1Object TryGetContextBaseUniversal(Asn1TaggedObject taggedObject, int tagNo, bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public static bool TryGetContextBaseUniversal(Asn1TaggedObject taggedObject, int tagNo, bool declaredExplicit, int baseTagNo, out Asn1Object baseUniversal)
	{
		baseUniversal = null;
		return false;
	}

	public static Asn1TaggedObjectParser ParseExplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass)
	{
		return null;
	}

	public static Asn1TaggedObjectParser ParseExplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo)
	{
		return null;
	}

	public static Asn1TaggedObjectParser ParseExplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser)
	{
		return null;
	}

	public static Asn1TaggedObjectParser ParseExplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagNo)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObjectParser TryParseExplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass)
	{
		return null;
	}

	public static bool TryParseExplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass, out Asn1TaggedObjectParser baseTagged)
	{
		baseTagged = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObjectParser TryParseExplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo)
	{
		return null;
	}

	public static bool TryParseExplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo, out Asn1TaggedObjectParser baseTagged)
	{
		baseTagged = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObjectParser TryParseExplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser)
	{
		return null;
	}

	public static bool TryParseExplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser, out Asn1TaggedObjectParser baseTagged)
	{
		baseTagged = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObjectParser TryParseExplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagNo)
	{
		return null;
	}

	public static bool TryParseExplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagNo, out Asn1TaggedObjectParser baseTagged)
	{
		baseTagged = null;
		return false;
	}

	public static Asn1TaggedObjectParser ParseImplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo, int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public static Asn1TaggedObjectParser ParseImplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagNo, int baseTagClass, int baseTagNo)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObjectParser TryParseImplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo, int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public static bool TryParseImplicitBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo, int baseTagClass, int baseTagNo, out Asn1TaggedObjectParser baseTagged)
	{
		baseTagged = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static Asn1TaggedObjectParser TryParseImplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagNo, int baseTagClass, int baseTagNo)
	{
		return null;
	}

	public static bool TryParseImplicitContextBaseTagged(Asn1TaggedObjectParser taggedObjectParser, int tagNo, int baseTagClass, int baseTagNo, out Asn1TaggedObjectParser baseTagged)
	{
		baseTagged = null;
		return false;
	}

	public static IAsn1Convertible ParseBaseUniversal(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo, bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public static IAsn1Convertible ParseContextBaseUniversal(Asn1TaggedObjectParser taggedObjectParser, int tagNo, bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	public static IAsn1Convertible TryParseBaseUniversal(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo, bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public static bool TryParseBaseUniversal(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo, bool declaredExplicit, int baseTagNo, out IAsn1Convertible baseUniversal)
	{
		baseUniversal = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static IAsn1Convertible TryParseContextBaseUniversal(Asn1TaggedObjectParser taggedObjectParser, int tagNo, bool declaredExplicit, int baseTagNo)
	{
		return null;
	}

	public static bool TryParseContextBaseUniversal(Asn1TaggedObjectParser taggedObjectParser, int tagNo, bool declaredExplicit, int baseTagNo, out IAsn1Convertible baseUniversal)
	{
		baseUniversal = null;
		return false;
	}

	public static IAsn1Convertible ParseExplicitBaseObject(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo)
	{
		return null;
	}

	public static IAsn1Convertible ParseExplicitContextBaseObject(Asn1TaggedObjectParser taggedObjectParser, int tagNo)
	{
		return null;
	}

	[Obsolete("Will be removed")]
	public static IAsn1Convertible TryParseExplicitBaseObject(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo)
	{
		return null;
	}

	public static bool TryParseExplicitBaseObject(Asn1TaggedObjectParser taggedObjectParser, int tagClass, int tagNo, out IAsn1Convertible baseObject)
	{
		baseObject = null;
		return false;
	}

	[Obsolete("Will be removed")]
	public static IAsn1Convertible TryParseExplicitContextBaseObject(Asn1TaggedObjectParser taggedObjectParser, int tagNo)
	{
		return null;
	}

	public static bool TryParseExplicitContextBaseObject(Asn1TaggedObjectParser taggedObjectParser, int tagNo, out IAsn1Convertible baseObject)
	{
		baseObject = null;
		return false;
	}

	public static TResult ReadOptionalContextTagged<TState, TResult>(Asn1Sequence sequence, ref int sequencePosition, int tagNo, TState state, Func<Asn1TaggedObject, TState, TResult> constructor) where TResult : class
	{
		return null;
	}

	public static TResult ReadOptionalTagged<TState, TResult>(Asn1Sequence sequence, ref int sequencePosition, int tagClass, int tagNo, TState state, Func<Asn1TaggedObject, TState, TResult> constructor) where TResult : class
	{
		return null;
	}

	public static bool TryReadOptionalContextTagged<TState, TResult>(Asn1Sequence sequence, ref int sequencePosition, int tagNo, TState state, out TResult result, Func<Asn1TaggedObject, TState, TResult> constructor)
	{
		result = default;
		return false;
	}

	public static bool TryReadOptionalTagged<TState, TResult>(Asn1Sequence sequence, ref int sequencePosition, int tagClass, int tagNo, TState state, out TResult result, Func<Asn1TaggedObject, TState, TResult> constructor)
	{
		result = default;
		return false;
	}
}
