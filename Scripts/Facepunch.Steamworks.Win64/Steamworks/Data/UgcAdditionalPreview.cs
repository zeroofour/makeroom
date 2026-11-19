namespace Steamworks.Data;

public struct UgcAdditionalPreview
{
	public string UrlOrVideoID { get; private set; } = null;

	public string OriginalFileName { get; private set; } = null;

	public ItemPreviewType ItemPreviewType { get; private set; } = ItemPreviewType.Image;

	internal UgcAdditionalPreview(string urlOrVideoID, string originalFileName, ItemPreviewType itemPreviewType)
	{
	}
}
