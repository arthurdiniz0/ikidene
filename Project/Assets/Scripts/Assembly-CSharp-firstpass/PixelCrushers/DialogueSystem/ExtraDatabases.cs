using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ExtraDatabases : MonoBehaviour
	{
		public DialogueTriggerEvent addTrigger;
		public DialogueTriggerEvent removeTrigger;
		public DialogueDatabase[] databases;
		public Condition condition;
		public bool once;
		public bool onePerFrame;
	}
}
