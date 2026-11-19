using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Microsoft.Win32;

namespace System;

[Serializable]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	private sealed class CachedData
	{
		private OffsetAndRule _oneYearLocalFromUtc;

		private TimeZoneInfo _localTimeZone;

		public Dictionary<string, TimeZoneInfo> _systemTimeZones;

		public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones;

		public bool _allSystemTimeZonesRead;

		public TimeZoneInfo Local => null;

		private static TimeZoneInfo GetCurrentOneYearLocal()
		{
			return null;
		}

		public OffsetAndRule GetOneYearLocalFromUtc(int year)
		{
			return null;
		}

		private TimeZoneInfo CreateLocal()
		{
			return null;
		}

		public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone)
		{
			return DateTimeKind.Unspecified;
		}
	}

	private sealed class OffsetAndRule
	{
		public readonly int Year;

		public readonly TimeSpan Offset;

		public readonly AdjustmentRule Rule;

		public OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule)
		{
		}
	}

	[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
	internal struct DYNAMIC_TIME_ZONE_INFORMATION
	{
		internal Interop.Kernel32.TIME_ZONE_INFORMATION TZI;

		internal string TimeZoneKeyName;

		internal byte DynamicDaylightTimeDisabled;
	}

	private enum TimeZoneInfoResult
	{
		Success = 0,
		TimeZoneNotFoundException = 1,
		InvalidTimeZoneException = 2,
		SecurityException = 3
	}

	[Serializable]
	public sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _dateStart;

		private readonly DateTime _dateEnd;

		private readonly TimeSpan _daylightDelta;

		private readonly TransitionTime _daylightTransitionStart;

		private readonly TransitionTime _daylightTransitionEnd;

		private readonly TimeSpan _baseUtcOffsetDelta;

		private readonly bool _noDaylightTransitions;

		public DateTime DateStart => default;

		public DateTime DateEnd => default;

		public TimeSpan DaylightDelta => default;

		public TransitionTime DaylightTransitionStart => default;

		public TransitionTime DaylightTransitionEnd => default;

		internal TimeSpan BaseUtcOffsetDelta => default;

		internal bool NoDaylightTransitions => false;

		internal bool HasDaylightSaving => false;

		public bool Equals(AdjustmentRule other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
		{
		}

		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
		{
			return null;
		}

		internal bool IsStartDateMarkerForBeginningOfYear()
		{
			return false;
		}

		internal bool IsEndDateMarkerForEndOfYear()
		{
			return false;
		}

		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private AdjustmentRule(SerializationInfo info, StreamingContext context)
		{
		}

		internal AdjustmentRule()
		{
		}
	}

	[Serializable]
	public readonly struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _timeOfDay = default;

		private readonly byte _month = 0;

		private readonly byte _week = 0;

		private readonly byte _day = 0;

		private readonly DayOfWeek _dayOfWeek = DayOfWeek.Sunday;

		private readonly bool _isFixedDateRule = false;

		public DateTime TimeOfDay => default;

		public int Month => 0;

		public int Week => 0;

		public int Day => 0;

		public DayOfWeek DayOfWeek => DayOfWeek.Sunday;

		public bool IsFixedDateRule => false;

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator !=(TransitionTime t1, TransitionTime t2)
		{
			return false;
		}

		public bool Equals(TransitionTime other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
		{
		}

		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
		{
			return default;
		}

		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
		{
			return default;
		}

		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private TransitionTime(SerializationInfo info, StreamingContext context)
		{
		}
	}

	private static Lazy<bool> lazyHaveRegistry;

	private readonly string _id;

	private readonly string _displayName;

	private readonly string _standardDisplayName;

	private readonly string _daylightDisplayName;

	private readonly TimeSpan _baseUtcOffset;

	private readonly bool _supportsDaylightSavingTime;

	private readonly AdjustmentRule[] _adjustmentRules;

	private static readonly TimeZoneInfo s_utcTimeZone;

	private static CachedData s_cachedData;

	private static readonly DateTime s_maxDateOnly;

	private static readonly DateTime s_minDateOnly;

	private static readonly TimeSpan MaxOffset;

	private static readonly TimeSpan MinOffset;

	private static bool HaveRegistry => false;

	public string Id => null;

	public string DisplayName => null;

	public TimeSpan BaseUtcOffset => default;

	public static TimeZoneInfo Local => null;

	public static TimeZoneInfo Utc => null;

	private static void PopulateAllSystemTimeZones(CachedData cachedData)
	{
	}

	private static void PopulateAllSystemTimeZonesFromRegistry(CachedData cachedData)
	{
	}

	private TimeZoneInfo(in Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled)
	{
	}

	private static bool CheckDaylightSavingTimeNotSupported(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone)
	{
		return false;
	}

	private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
	{
		return null;
	}

	private static string FindIdFromTimeZoneInformation(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled)
	{
		dstDisabled = default;
		return null;
	}

	private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData)
	{
		return null;
	}

	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled)
	{
		return null;
	}

	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
	{
		isAmbiguousLocalDst = default;
		return default;
	}

	private static bool TransitionTimeFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out TransitionTime transitionTime, bool readStartDate)
	{
		transitionTime = default;
		return false;
	}

	private static bool TryCreateAdjustmentRules(string id, in Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset)
	{
		rules = null;
		e = null;
		return false;
	}

	private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi)
	{
		dtzi = default;
		return false;
	}

	private static bool TryCompareStandardDate(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, in Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo)
	{
		return false;
	}

	private static bool TryCompareTimeZoneInformationToRegistry(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled)
	{
		dstDisabled = default;
		return false;
	}

	private static string TryGetLocalizedNameByMuiNativeResource(string resource)
	{
		return null;
	}

	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource)
	{
		return null;
	}

	private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName)
	{
		displayName = null;
		standardName = null;
		daylightName = null;
	}

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e)
	{
		value = null;
		e = null;
		return TimeZoneInfoResult.Success;
	}

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e)
	{
		value = null;
		e = null;
		return TimeZoneInfoResult.Success;
	}

	[PreserveSig]
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation);

	[PreserveSig]
	internal static extern uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation);

	[PreserveSig]
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear);

	[PreserveSig]
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out Interop.Kernel32.TIME_ZONE_INFORMATION ptzi);

	internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
	{
		return null;
	}

	private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate)
	{
		transitionTime = default;
		return false;
	}

	internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation)
	{
		return null;
	}

	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback()
	{
		return null;
	}

	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id)
	{
		return null;
	}

	private static void GetSystemTimeZonesWinRTFallback(CachedData cachedData)
	{
	}

	private AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, int? ruleIndex)
	{
		return null;
	}

	public TimeSpan GetUtcOffset(DateTime dateTime)
	{
		return default;
	}

	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default;
	}

	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default;
	}

	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		return default;
	}

	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
	{
		return default;
	}

	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		return default;
	}

	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default;
	}

	public bool Equals(TimeZoneInfo other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
	{
		return null;
	}

	public bool HasSameRules(TimeZoneInfo other)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
	{
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
	{
		return null;
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private TimeZoneInfo(SerializationInfo info, StreamingContext context)
	{
	}

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out int? ruleIndex)
	{
		ruleIndex = null;
		return null;
	}

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out int? ruleIndex)
	{
		ruleIndex = null;
		return null;
	}

	private int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc)
	{
		return 0;
	}

	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
	{
		return default;
	}

	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
	{
		return default;
	}

	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc)
	{
		return default;
	}

	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
	{
		isAmbiguousLocalDst = default;
		return default;
	}

	private DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, int? ruleIndex)
	{
		return default;
	}

	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags)
	{
		return false;
	}

	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, int? ruleIndex)
	{
		return default;
	}

	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule)
	{
		return default;
	}

	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, AdjustmentRule rule, int? ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone)
	{
		isAmbiguousLocalDst = default;
		return false;
	}

	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule)
	{
		return false;
	}

	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		return false;
	}

	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		return false;
	}

	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags)
	{
		return default;
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
	{
		return default;
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings)
	{
		isDaylightSavings = default;
		return default;
	}

	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
	{
		isDaylightSavings = default;
		isAmbiguousLocalDst = default;
		return default;
	}

	internal static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime)
	{
		return default;
	}

	private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData, bool alwaysFallbackToLocalMachine = false)
	{
		value = null;
		e = null;
		return TimeZoneInfoResult.Success;
	}

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData)
	{
		value = null;
		e = null;
		return TimeZoneInfoResult.Success;
	}

	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst)
	{
		adjustmentRulesSupportDst = default;
	}

	internal static bool UtcOffsetOutOfRange(TimeSpan offset)
	{
		return false;
	}

	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule)
	{
		return default;
	}

	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule)
	{
		return false;
	}

	internal TimeZoneInfo()
	{
	}
}
