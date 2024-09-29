using System;
using UnityEngine;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class WorldVariable : MonoBehaviour
	{
		public enum StatPersistanceMode
		{
			ResetToStartingValue = 0,
			KeepFromPrevious = 1,
		}

		public enum VariableChangeMode
		{
			OnlyIncrease = 0,
			OnlyDecrease = 1,
			Any = 2,
		}

		public bool isExpanded;
		public WorldVariableTracker.VariableType varType;
		public bool allowNegative;
		public bool canEndGame;
		public bool hasMaxValue;
		public int startingValue;
		public int endGameMinValue;
		public int endGameMaxValue;
		public int prospectiveValue;
		public int intMaxValue;
		public float startingValueFloat;
		public float endGameMinValueFloat;
		public float endGameMaxValueFloat;
		public float prospectiveFloatValue;
		public float floatMaxValue;
		public StatPersistanceMode persistanceMode;
		public WorldVariableListener listenerPrefab;
		public VariableChangeMode changeMode;
		public bool fireEventsOnChange;
		public List<CGKCustomEventToFire> changeCustomEventsToFire;
	}
}
