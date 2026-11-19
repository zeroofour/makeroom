using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Kenney;
using Steamworks.Ugc;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PromptSave : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadThumbnail_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string _url;

		public RawImage _rawImage;

		private UnityWebRequest _003C_request_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadThumbnail_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSelect_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PromptSave _003C_003E4__this;

		public Transform _transform;

		private int _003C_slot_003E5__2;

		private string _003C_action_003E5__3;

		private PromptSaveElement _003C_element_003E5__4;

		private TaskAwaiter<bool> _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CDoSearch_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PromptSave _003C_003E4__this;

		private Query _003C_subscribedQuery_003E5__2;

		private List<Item> _003C_publishedItems_003E5__3;

		private TaskAwaiter<List<Item>> _003C_003Eu__1;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetAllItemsFromQuery_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<Item>> _003C_003Et__builder;

		public Query _query;

		private List<Item> _003C_allItems_003E5__2;

		private int _003Cpage_003E5__3;

		private TaskAwaiter<ResultPage?> _003C_003Eu__1;

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

	[Header("Components")]
	public GameObject element;

	public GameObject categories;

	[Header("Pages")]
	public Text pageCounter;

	[Header("Buttons")]
	public Kenney.Button buttonFirstPage;

	public Kenney.Button buttonPreviousPage;

	public Kenney.Button buttonNextPage;

	public Kenney.Button buttonLastPage;

	[Header("Tabs")]
	public Kenney.Button buttonCategoryLocal;

	public Kenney.Button buttonCategorySamples;

	public Kenney.Button buttonCategoryWorkshop;

	public static int page;

	private string category;

	private List<GameObject> slots;

	private List<DioramaEntry> workshopEntries;

	private Sample[] samples;

	private bool forceLoadingCustom;

	private int slotsPerPage;

	private int maximumPagesSaving;

	private int maximumPages;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void GenerateSlots()
	{
	}

	private void LoadData()
	{
	}

	public void SetForceLoadingCustom()
	{
	}

	private void LoadDataLocal()
	{
	}

	private void LoadSamples()
	{
	}

	private void LoadDataSamples()
	{
	}

	private void LoadDataWorkshop()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadThumbnail_003Ed__28))]
	public IEnumerator LoadThumbnail(RawImage _rawImage, string _url)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSelect_003Ed__29))]
	public void Select(Transform _transform)
	{
	}

	public void Close()
	{
	}

	public void SetCategoryLocal()
	{
	}

	public void SetCategoryWorkshop()
	{
	}

	public void SetCategorySamples()
	{
	}

	public void UpdateCategories()
	{
	}

	[AsyncStateMachine(typeof(_003CDoSearch_003Ed__35))]
	private void DoSearch()
	{
	}

	private DioramaEntry CreateDioramaEntry(Item _entry, bool _created = false)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetAllItemsFromQuery_003Ed__37))]
	private Task<List<Item>> GetAllItemsFromQuery(Query _query)
	{
		return null;
	}

	public void LoadWorkshop(int _slot)
	{
	}

	public void PageFirst()
	{
	}

	public void PageNext()
	{
	}

	public void PagePrevious()
	{
	}

	public void PageLast()
	{
	}

	public void PageUpdate(int _page = -1)
	{
	}
}
