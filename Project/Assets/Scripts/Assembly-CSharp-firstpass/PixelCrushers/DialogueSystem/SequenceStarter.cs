using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SequenceStarter : DialogueEventStarter
	{
		[TextAreaAttribute]
		public string sequence;
		public Transform speaker;
		public Transform listener;
		public Condition condition;
	}
}
