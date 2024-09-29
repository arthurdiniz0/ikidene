using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityInput
{
	public class GetKey : Action
	{
		public KeyCode key;
		public SharedBool storeResult;
	}
}
