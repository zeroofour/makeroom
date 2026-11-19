using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.Ugc;

public struct Query(UgcType type)
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetPageAsync_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ResultPage?> _003C_003Et__builder;

		public int page;

		public Query _003C_003E4__this;

		private CallResult<SteamUGCQueryCompleted_t> _003C_003Eu__1;

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

	private UgcType matchingType = UgcType.Items;

	private UGCQuery queryType = UGCQuery.RankedByVote;

	private AppId consumerApp = default;

	private AppId creatorApp = default;

	private string searchText = null;

	private SteamId? steamid = null;

	private UserUGCList userType = UserUGCList.Published;

	private UserUGCListSortOrder userSort = UserUGCListSortOrder.CreationOrderDesc;

	private PublishedFileId[] Files = null;

	private int? maxCacheAge = null;

	private string language = null;

	private int? trendDays = null;

	private List<string> requiredTags = null;

	private bool? matchAnyTag = null;

	private List<string> excludedTags = null;

	private Dictionary<string, string> requiredKv = null;

	private bool? WantsReturnOnlyIDs = null;

	private bool? WantsReturnKeyValueTags = null;

	private bool? WantsReturnLongDescription = null;

	private bool? WantsReturnMetadata = null;

	private bool? WantsReturnChildren = null;

	private bool? WantsReturnAdditionalPreviews = null;

	private bool? WantsReturnTotalOnly = null;

	private uint? WantsReturnPlaytimeStats = null;

	private bool? WantsDefaultStats = null;

	public static Query All => default;

	public static Query Items => default;

	public static Query ItemsMtx => default;

	public static Query ItemsReadyToUse => default;

	public static Query Collections => default;

	public static Query Artwork => default;

	public static Query Videos => default;

	public static Query Screenshots => default;

	public static Query AllGuides => default;

	public static Query WebGuides => default;

	public static Query IntegratedGuides => default;

	public static Query UsableInGame => default;

	public static Query ControllerBindings => default;

	public static Query GameManagedItems => default;

	public Query RankedByVote()
	{
		return default;
	}

	public Query RankedByPublicationDate()
	{
		return default;
	}

	public Query RankedByAcceptanceDate()
	{
		return default;
	}

	public Query RankedByTrend()
	{
		return default;
	}

	public Query FavoritedByFriends()
	{
		return default;
	}

	public Query CreatedByFriends()
	{
		return default;
	}

	public Query RankedByNumTimesReported()
	{
		return default;
	}

	public Query CreatedByFollowedUsers()
	{
		return default;
	}

	public Query NotYetRated()
	{
		return default;
	}

	public Query RankedByTotalVotesAsc()
	{
		return default;
	}

	public Query RankedByVotesUp()
	{
		return default;
	}

	public Query RankedByTextSearch()
	{
		return default;
	}

	public Query RankedByTotalUniqueSubscriptions()
	{
		return default;
	}

	public Query RankedByPlaytimeTrend()
	{
		return default;
	}

	public Query RankedByTotalPlaytime()
	{
		return default;
	}

	public Query RankedByAveragePlaytimeTrend()
	{
		return default;
	}

	public Query RankedByLifetimeAveragePlaytime()
	{
		return default;
	}

	public Query RankedByPlaytimeSessionsTrend()
	{
		return default;
	}

	public Query RankedByLifetimePlaytimeSessions()
	{
		return default;
	}

	internal Query LimitUser(SteamId steamid)
	{
		return default;
	}

	public Query WhereUserPublished(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query WhereUserVotedOn(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query WhereUserVotedUp(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query WhereUserVotedDown(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query WhereUserWillVoteLater(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query WhereUserFavorited(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query WhereUserSubscribed(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query WhereUserUsedOrPlayed(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query WhereUserFollowed(SteamId user = default(SteamId))
	{
		return default;
	}

	public Query SortByCreationDate()
	{
		return default;
	}

	public Query SortByCreationDateAsc()
	{
		return default;
	}

	public Query SortByTitleAsc()
	{
		return default;
	}

	public Query SortByUpdateDate()
	{
		return default;
	}

	public Query SortBySubscriptionDate()
	{
		return default;
	}

	public Query SortByVoteScore()
	{
		return default;
	}

	public Query SortByModeration()
	{
		return default;
	}

	public Query WhereSearchText(string searchText)
	{
		return default;
	}

	public Query WithFileId(params PublishedFileId[] files)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CGetPageAsync_003Ed__76))]
	public Task<ResultPage?> GetPageAsync(int page)
	{
		return null;
	}

	public Query WithType(UgcType type)
	{
		return default;
	}

	public Query AllowCachedResponse(int maxSecondsAge)
	{
		return default;
	}

	public Query InLanguage(string lang)
	{
		return default;
	}

	public Query WithTrendDays(int days)
	{
		return default;
	}

	public Query MatchAnyTag()
	{
		return default;
	}

	public Query MatchAllTags()
	{
		return default;
	}

	public Query WithTag(string tag)
	{
		return default;
	}

	public Query AddRequiredKeyValueTag(string key, string value)
	{
		return default;
	}

	public Query WithoutTag(string tag)
	{
		return default;
	}

	private void ApplyConstraints(UGCQueryHandle_t handle)
	{
	}

	public Query WithOnlyIDs(bool b)
	{
		return default;
	}

	public Query WithKeyValueTags(bool b)
	{
		return default;
	}

	[Obsolete("Renamed to WithKeyValueTags")]
	public Query WithKeyValueTag(bool b)
	{
		return default;
	}

	public Query WithLongDescription(bool b)
	{
		return default;
	}

	public Query WithMetadata(bool b)
	{
		return default;
	}

	public Query WithChildren(bool b)
	{
		return default;
	}

	public Query WithAdditionalPreviews(bool b)
	{
		return default;
	}

	public Query WithTotalOnly(bool b)
	{
		return default;
	}

	public Query WithPlaytimeStats(uint unDays)
	{
		return default;
	}

	private void ApplyReturns(UGCQueryHandle_t handle)
	{
	}

	public Query WithDefaultStats(bool b)
	{
		return default;
	}
}
