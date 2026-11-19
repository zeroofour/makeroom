using UnityEngine;

namespace Mirror.Examples.Common;

[AddComponentMenu(null)]
public class PhysicsSimulator : MonoBehaviour
{
	private PhysicsScene physicsScene;

	private PhysicsScene2D physicsScene2D;

	private bool simulatePhysicsScene;

	private bool simulatePhysicsScene2D;

	private void Awake()
	{
	}

	[ServerCallback]
	private void FixedUpdate()
	{
	}
}
