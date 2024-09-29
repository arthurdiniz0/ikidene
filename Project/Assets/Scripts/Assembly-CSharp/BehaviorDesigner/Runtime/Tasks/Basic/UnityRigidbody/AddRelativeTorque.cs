using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class AddRelativeTorque : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 torque;
		public ForceMode forceMode;
	}
}
