using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public class SpawnedObjectManager : Saver
	{
		[SerializeField]
		private List<SpawnedObject> m_spawnedObjectPrefabs;
		[SerializeField]
		private List<SpawnedObject> m_spawnedObjects;
	}
}
