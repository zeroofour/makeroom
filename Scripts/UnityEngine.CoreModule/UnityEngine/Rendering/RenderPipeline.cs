using System.Collections.Generic;

namespace UnityEngine.Rendering;

public abstract class RenderPipeline
{
	public bool disposed { get; private set; }

	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, List<Camera.RenderRequest> renderRequests)
	{
	}

	protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
	{
	}

	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
	{
	}

	internal void InternalRenderWithRequests(ScriptableRenderContext context, List<Camera> cameras, List<Camera.RenderRequest> renderRequests)
	{
	}

	internal void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
