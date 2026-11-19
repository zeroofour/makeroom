using System.Collections.Generic;
using Kenney;
using UnityEngine;
using UnityEngine.UI;

public class Diorama : MonoBehaviour
{
	public enum Type
	{
		Diorama = 0,
		Object = 1
	}

	public static DioramaData data;

	public static Type type;

	[Header("Properties")]
	public Type dioramaType;

	[Header("Materials")]
	public Material materialDefault;

	public Material materialBody;

	public Material materialEdges;

	public Material materialWindows;

	public Material materialFloor;

	public Material materialWallLeft;

	public Material materialWallRight;

	[Header("Components")]
	public Transform container;

	public Transform scene;

	public AudioSource audioEnvironment;

	public DioramaEffects effects;

	public Text layerDisplay;

	public GameObject emptyPlane;

	[Header("Grid")]
	public Transform grid;

	public Transform gridContainer;

	public Toggler gridButton;

	[Header("Buttons")]
	public GameObject buttonEnvironment;

	public Kenney.Button buttonUnhideAll;

	public Kenney.Button buttonUnlockAll;

	[Header("Sample")]
	public Sample sample;

	public bool allowConstruction;

	public bool allowDecorating;

	public bool allowDuplication;

	public bool allowScene;

	private int slot;

	private Vector2 size;

	private float offset;

	private int layer;

	private List<GameObject> generated;

	private GameObject wallLeft;

	private GameObject wallLeftStretch;

	private GameObject wallRight;

	private GameObject wallRightStretch;

	public float foliageOffset;

	public static Diorama instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private GameObject CreateElement(string _type, GameObject _object, Vector3 _position, Vector3 _rotation, Vector3 _scale, SelectionCustom.Bounds _bounds = null)
	{
		return null;
	}

	public void UpdateScene(bool _animate = false)
	{
	}

	public void GenerateRoom()
	{
	}

	public void GenerateCamper()
	{
	}

	public void GenerateGarden()
	{
	}

	public void GenerateBoat()
	{
	}

	public void GenerateEmpty()
	{
	}

	public void GenerateRooftop()
	{
	}

	public void UpdateBackgroundColor()
	{
	}

	public void SetBackgroundColor(string _hex)
	{
	}

	public void UpdateMaterials()
	{
	}

	private void ProcessMaterialProperty(Material _material, string _id)
	{
	}

	public void InitiateMaterials()
	{
	}

	public void InstantiateType()
	{
	}

	public void SetSlot(int _slot)
	{
	}

	public void New(int _type = 0)
	{
	}

	public void Save(string _path = null, string _preview = null, int _slot = -1)
	{
	}

	public void WriteChunks()
	{
	}

	public List<DioramaChunk> GetChunks()
	{
		return null;
	}

	public DioramaData LoadData(string _file = null, int _slot = -1)
	{
		return null;
	}

	public void Load(string _file = null, int _slot = -1, bool _generate = true)
	{
	}

	public void Load(DioramaData _data, bool _generate = true)
	{
	}

	public void LoadChunks(bool _generate = true)
	{
	}

	public void SetSize(Vector2 _size)
	{
	}

	public Vector2 GetSize()
	{
		return default;
	}

	public float GetOffset()
	{
		return 0f;
	}

	public void OnHourElapsed()
	{
	}

	public void Clear()
	{
	}

	public void ResetAllow()
	{
	}

	public void StartTimer()
	{
	}

	public void CancelTimer()
	{
	}

	public void LayerUp()
	{
	}

	public void LayerDown()
	{
	}

	public void SetLayer(bool _sound = true)
	{
	}

	public void AlignGridToSelection()
	{
	}

	public void ResetGridAligment()
	{
	}

	public void ShiftX(float _amount)
	{
	}

	public void ShiftY(float _amount)
	{
	}

	public void ShiftZ(float _amount)
	{
	}

	public void ShiftRotate(float _amount)
	{
	}

	public void Shift(Vector3 _direction)
	{
	}

	public void UnlockAll()
	{
	}

	public void ForceUnlockAll()
	{
	}

	public void UnhideAll()
	{
	}

	public void ToggleButtonUnhideAll(bool _activated = true)
	{
	}

	public void ToggleButtonUnlockAll(bool _activated = true)
	{
	}

	public void UpdateButtons()
	{
	}

	public void UpdateButtons(List<DioramaChunk> _chunks)
	{
	}
}
