using UnityEngine;

namespace PixelCrushers
{
	public class InstantiatePrefabs : MonoBehaviour
	{
		public enum Position
		{
			ScreenSpaceUI = 0,
			OriginalPosition = 1,
			ParentPosition = 2,
		}

		[SerializeField]
		private Transform m_parent;
		[SerializeField]
		private GameObject[] m_prefabs;
		[SerializeField]
		private Position m_position;
	}
}
