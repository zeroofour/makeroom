using UnityEngine;
using UnityEngine.UI;

namespace Mirror;

public abstract class BaseUIGraph : MonoBehaviour
{
	private static readonly int MaxValue;

	private static readonly int GraphData;

	private static readonly int CategoryCount;

	private static readonly int Colors;

	private static readonly int Width;

	private static readonly int DataStart;

	public Material Material;

	public Graphic Renderer;

	[Range(1f, 64f)]
	public int Points;

	public float SecondsPerPoint;

	public Color[] CategoryColors;

	public bool IsStacked;

	public Text[] LegendTexts;

	[SerializeField]
	[ReadOnly]
	[Header("Diagnostics")]
	private Material runtimeMaterial;

	private float[] graphData;

	private int graphDataStartIndex;

	private bool isGraphDataDirty;

	private float[] aggregatingData;

	private GraphAggregationMode[] aggregatingModes;

	private int[] aggregatingDataCounts;

	private float aggregatingTime;

	private int DataLastIndex => 0;

	private void Awake()
	{
	}

	protected virtual void OnValidate()
	{
	}

	protected virtual void Update()
	{
	}

	private void ResetCurrent(int i)
	{
	}

	protected virtual string FormatValue(float value)
	{
		return null;
	}

	protected abstract void CollectData(int category, out float value, out GraphAggregationMode mode);

	private void SetCurrentGraphData(int c, float value)
	{
	}

	private void ClearDataAt(int i)
	{
	}

	public void LateUpdate()
	{
	}

	protected virtual float AdjustMaxValue(float max)
	{
		return 0f;
	}
}
