using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class SaveSystemTestMenu : MonoBehaviour
	{
		public string menuInputButton;
		public int saveSlot;
		public string instructions;
		public float instructionsDuration;
		public bool pauseWhileOpen;
		public UnityEvent onShow;
		public UnityEvent onHide;
	}
}
