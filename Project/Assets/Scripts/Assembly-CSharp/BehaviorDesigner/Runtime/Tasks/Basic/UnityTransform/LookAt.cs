using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class LookAt : Action
	{
		public SharedGameObject targetGameObject;
		public SharedGameObject targetLookAt;
		public SharedVector3 worldPosition;
		public Vector3 worldUp;
	}
}
