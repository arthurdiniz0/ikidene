using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityPhysics
{
	public class Raycast : Action
	{
		public SharedGameObject originGameObject;
		public SharedVector3 originPosition;
		public SharedVector3 direction;
		public SharedFloat distance;
		public LayerMask layerMask;
		public Space space;
		public SharedGameObject storeHitObject;
		public SharedVector3 storeHitPoint;
		public SharedVector3 storeHitNormal;
		public SharedFloat storeHitDistance;
	}
}
