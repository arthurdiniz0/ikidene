using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class MatchTarget : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 matchPosition;
		public SharedQuaternion matchRotation;
		public AvatarTarget targetBodyPart;
		public Vector3 weightMaskPosition;
		public float weightMaskRotation;
		public float startNormalizedTime;
		public float targetNormalizedTime;
	}
}
