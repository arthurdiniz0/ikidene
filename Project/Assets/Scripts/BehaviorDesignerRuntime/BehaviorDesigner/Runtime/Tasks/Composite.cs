using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class Composite : ParentTask
	{
		[SerializeField]
		protected AbortType abortType;
	}
}
