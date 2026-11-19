namespace UnityEngine.UIElements;

internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	protected readonly ListView m_ListView;

	public ListViewReorderableDragAndDropController(ListView view)
		: base(null)
	{
	}

	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
	{
		return DragVisualMode.None;
	}

	public override void OnDrop(IListDragAndDropArgs args)
	{
	}
}
