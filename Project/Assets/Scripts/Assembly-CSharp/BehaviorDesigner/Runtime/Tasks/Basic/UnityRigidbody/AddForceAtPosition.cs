using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class AddForceAtPosition : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 force;
		public SharedVector3 position;
		public ForceMode forceMode;
	}
}
