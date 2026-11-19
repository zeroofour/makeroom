using System.Collections.Generic;

namespace UnityEngine.UIElements;

public sealed class EventDispatcher
{
	private struct EventRecord
	{
		public EventBase m_Event;

		public IPanel m_Panel;
	}

	private struct DispatchContext
	{
		public uint m_GateCount;

		public Queue<EventRecord> m_Queue;
	}

	internal ClickDetector m_ClickDetector;

	private List<IEventDispatchingStrategy> m_DispatchingStrategies;

	private static readonly ObjectPool<Queue<EventRecord>> k_EventQueuePool;

	private Queue<EventRecord> m_Queue;

	private uint m_GateCount;

	private Stack<DispatchContext> m_DispatchContexts;

	private static readonly IEventDispatchingStrategy[] s_EditorStrategies;

	private bool m_Immediate;

	internal PointerDispatchState pointerState { get; }

	private bool dispatchImmediately => false;

	private bool processingEvents { set; }

	internal static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies)
	{
		return null;
	}

	private EventDispatcher(IList<IEventDispatchingStrategy> strategies)
	{
	}

	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode)
	{
	}

	internal void CloseGate()
	{
	}

	internal void OpenGate()
	{
	}

	private void ProcessEventQueue()
	{
	}

	private void ProcessEvent(EventBase evt, IPanel panel)
	{
	}

	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed)
	{
	}
}
