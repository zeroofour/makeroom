using System;
using System.Collections.Generic;
using UnityEngine;

public static class MeshExporter
{
	[Serializable]
	public class Node
	{
		public string name;

		public float[] position;

		public float[] rotation;

		public float[] scale;

		public float[] vertices;

		public int[] triangles;

		public float[] normals;

		public List<Node> children;
	}

	public static void Export(string filename, GameObject go)
	{
	}

	private static Node BuildNode(GameObject go)
	{
		return null;
	}

	private static string BuildJson(Node node, int indent)
	{
		return null;
	}
}
