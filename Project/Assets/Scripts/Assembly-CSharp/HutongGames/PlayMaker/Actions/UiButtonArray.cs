using HutongGames.PlayMaker;
using UnityEngine.UI;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	public class UiButtonArray : FsmStateAction
	{
		public FsmEventTarget eventTarget;
		public FsmGameObject[] gameObjects;
		public FsmEvent[] clickEvents;
		[SerializeField]
		private Button[] buttons;
		[SerializeField]
		private GameObject[] cachedGameObjects;
	}
}
