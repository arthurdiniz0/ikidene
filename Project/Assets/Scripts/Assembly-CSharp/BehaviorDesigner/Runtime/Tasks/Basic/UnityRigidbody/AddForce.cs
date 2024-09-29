using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class AddForce : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 force;
		public ForceMode forceMode;
	}
}
