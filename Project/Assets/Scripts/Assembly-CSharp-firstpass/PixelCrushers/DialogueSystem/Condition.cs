using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Condition
	{
		public enum LastEvaluationValue
		{
			None = 0,
			True = 1,
			False = 2,
		}

		public string[] luaConditions;
		public QuestCondition[] questConditions;
		public string[] acceptedTags;
		public GameObject[] acceptedGameObjects;
		public int luaWizardIndex;
		public LastEvaluationValue lastEvaluationValue;
	}
}
