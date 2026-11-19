using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.Ugc;

public struct Editor
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSubmitAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<PublishResult> _003C_003Et__builder;

		public IProgress<float> progress;

		public Editor _003C_003E4__this;

		public Action<PublishResult> onItemCreated;

		private PublishResult _003Cresult_003E5__2;

		private CallResult<CreateItemResult_t> _003C_003Eu__1;

		private UGCUpdateHandle_t _003Chandle_003E5__3;

		private CallResult<SubmitItemUpdateResult_t> _003Cupdating_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

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

	private PublishedFileId fileId = default;

	private bool creatingNew = false;

	private WorkshopFileType creatingType = WorkshopFileType.First;

	private AppId consumerAppId = default;

	private string Title = null;

	private string Description = null;

	private string MetaData = null;

	private string ChangeLog = null;

	private string Language = null;

	private string PreviewFile = null;

	private DirectoryInfo ContentFolder = null;

	private RemoteStoragePublishedFileVisibility? Visibility = null;

	private List<string> Tags = null;

	private Dictionary<string, List<string>> KeyValueTags = null;

	private HashSet<string> KeyValueTagsToRemove = null;

	public static Editor NewCommunityFile => default;

	public static Editor NewCollection => default;

	public static Editor NewMicrotransactionFile => default;

	public static Editor NewGameManagedFile => default;

	internal Editor(WorkshopFileType filetype)
	{
	}

	public Editor(PublishedFileId fileId)
	{
	}

	public Editor ForAppId(AppId id)
	{
		return default;
	}

	public Editor WithTitle(string t)
	{
		return default;
	}

	public Editor WithDescription(string t)
	{
		return default;
	}

	public Editor WithMetaData(string t)
	{
		return default;
	}

	public Editor WithChangeLog(string t)
	{
		return default;
	}

	public Editor InLanguage(string t)
	{
		return default;
	}

	public Editor WithPreviewFile(string t)
	{
		return default;
	}

	public Editor WithContent(DirectoryInfo t)
	{
		return default;
	}

	public Editor WithContent(string folderName)
	{
		return default;
	}

	public Editor WithPublicVisibility()
	{
		return default;
	}

	public Editor WithFriendsOnlyVisibility()
	{
		return default;
	}

	public Editor WithPrivateVisibility()
	{
		return default;
	}

	public Editor WithTag(string tag)
	{
		return default;
	}

	public Editor AddKeyValueTag(string key, string value)
	{
		return default;
	}

	public Editor RemoveKeyValueTags(string key)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CSubmitAsync_003Ed__40))]
	public Task<PublishResult> SubmitAsync(IProgress<float> progress = null, Action<PublishResult> onItemCreated = null)
	{
		return null;
	}
}
