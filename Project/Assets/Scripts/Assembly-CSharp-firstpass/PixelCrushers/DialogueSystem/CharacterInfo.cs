using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class CharacterInfo
	{
		public CharacterInfo(int id, string nameInDatabase, Transform transform, CharacterType characterType, Texture2D portrait)
		{
		}

		public int id;
		public string nameInDatabase;
		public CharacterType characterType;
		public Transform transform;
		public Texture2D portrait;
	}
}
