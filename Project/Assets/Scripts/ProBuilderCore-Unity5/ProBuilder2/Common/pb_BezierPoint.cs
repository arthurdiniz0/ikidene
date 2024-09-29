using System;
using UnityEngine;

namespace ProBuilder2.Common
{
	[Serializable]
	public struct pb_BezierPoint
	{
		public pb_BezierPoint(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation) : this()
		{
		}

		public Vector3 position;
		public Vector3 tangentIn;
		public Vector3 tangentOut;
		public Quaternion rotation;
	}
}
