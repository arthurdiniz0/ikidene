using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class SetConstraints : Action
	{
		public SharedGameObject targetGameObject;
		public RigidbodyConstraints constraints;
	}
}
