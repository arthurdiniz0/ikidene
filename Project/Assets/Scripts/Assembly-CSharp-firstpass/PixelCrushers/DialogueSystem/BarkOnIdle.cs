using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class BarkOnIdle : BarkStarter
	{
		public float minSeconds;
		public float maxSeconds;
		public Transform target;
	}
}
