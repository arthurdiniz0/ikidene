using System;
using UnityEngine;
using System.Collections.Generic;

namespace PixelCrushers
{
	[Serializable]
	public class SavedGameData
	{
		[Serializable]
		public class SaveRecord
		{
			public string key;
			public int sceneIndex;
			public string data;
		}

		[SerializeField]
		private string m_sceneName;
		[SerializeField]
		private List<SavedGameData.SaveRecord> m_list;
	}
}
