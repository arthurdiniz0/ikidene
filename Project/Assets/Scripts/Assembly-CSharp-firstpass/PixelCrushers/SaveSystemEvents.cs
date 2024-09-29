using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class SaveSystemEvents : MonoBehaviour
	{
		public UnityEvent onSaveStart;
		public UnityEvent onSaveEnd;
		public UnityEvent onLoadStart;
		public UnityEvent onLoadEnd;
		public UnityEvent onSceneLoad;
	}
}
