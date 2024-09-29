using UnityEngine;
using System.Collections.Generic;

namespace ProBuilder2.Common
{
	public class pb_BezierShape : MonoBehaviour
	{
		public List<pb_BezierPoint> m_Points;
		public bool m_CloseLoop;
		public float m_Radius;
		public int m_Rows;
		public int m_Columns;
		public bool m_Smooth;
		public bool m_IsEditing;
	}
}
