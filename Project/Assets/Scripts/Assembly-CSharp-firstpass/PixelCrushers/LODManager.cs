using UnityEngine;
using System;

namespace PixelCrushers
{
	public class LODManager : MonoBehaviour
	{
		[Serializable]
		public class LOD
		{
			[SerializeField]
			private float m_minDistance;
			[SerializeField]
			private float m_maxDistance;
		}

		[SerializeField]
		private LOD[] m_levels;
		[SerializeField]
		private float m_monitorFrequency;
	}
}
