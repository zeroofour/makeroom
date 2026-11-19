using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Titlescreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadUpdate_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Titlescreen _003C_003E4__this;

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
		public _003CLoadUpdate_003Ed__24(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CLoadUpdateImage_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string _url;

		public Titlescreen _003C_003E4__this;

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
		public _003CLoadUpdateImage_003Ed__25(int _003C_003E1__state)
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

	public Image background;

	public CanvasGroup titlescreen;

	public CanvasGroup canvas;

	public Text gameVersion;

	public GameObject demoText;

	[Header("Update")]
	public GameObject updateButton;

	public RawImage updateImage;

	public GameObject updateTagNew;

	public GameObject updateTagUpdate;

	public string updateURL;

	public static bool introPlayed;

	public static bool prepareOpening;

	public static string testOpenType;

	private bool active;

	public static Titlescreen instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PlayIntro()
	{
	}

	public void Show()
	{
	}

	public void Hide(bool _displayInterface = true)
	{
	}

	public bool Active()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CLoadUpdate_003Ed__24))]
	public IEnumerator LoadUpdate()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadUpdateImage_003Ed__25))]
	public IEnumerator LoadUpdateImage(string _url)
	{
		return null;
	}

	public int StringToVersion(string _input)
	{
		return 0;
	}

	public void ButtonStart()
	{
	}

	public void ButtonBay()
	{
	}

	public void ButtonCreator()
	{
	}

	public void Disable()
	{
	}

	public void ButtonOpen()
	{
	}

	public void ButtonOpenObjective()
	{
	}

	public void ButtonOpenObjectiveUnpack()
	{
	}

	public void ButtonOpenCustom()
	{
	}

	public void ButtonUpdate()
	{
	}

	public void ButtonOptions()
	{
	}

	public void ButtonTwitter()
	{
	}

	public void ButtonInstagram()
	{
	}

	public void ButtonDiscord()
	{
	}

	public void ButtonWebsite()
	{
	}

	public void ButtonWishlist()
	{
	}
}
