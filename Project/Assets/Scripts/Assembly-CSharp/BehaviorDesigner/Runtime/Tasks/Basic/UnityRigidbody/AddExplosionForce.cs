using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class AddExplosionForce : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat explosionForce;
		public SharedVector3 explosionPosition;
		public SharedFloat explosionRadius;
		public float upwardsModifier;
		public ForceMode forceMode;
	}
}
