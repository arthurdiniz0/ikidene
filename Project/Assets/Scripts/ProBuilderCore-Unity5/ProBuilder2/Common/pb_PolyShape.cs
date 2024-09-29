using UnityEngine;
using System.Collections.Generic;

namespace ProBuilder2.Common
{
	public class pb_PolyShape : MonoBehaviour
	{
		public enum PolyEditMode
		{
			None = 0,
			Path = 1,
			Height = 2,
			Edit = 3,
		}

		public List<Vector3> points;
		public float extrude;
		public PolyEditMode polyEditMode;
		public bool flipNormals;
		public bool isOnGrid;
	}
}
