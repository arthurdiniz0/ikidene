using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityPhysics2D
{
	public class Circlecast : Action
	{
		public SharedGameObject originGameObject;
		public SharedVector2 originPosition;
		public SharedFloat radius;
		public SharedVector2 direction;
		public SharedFloat distance;
		public LayerMask layerMask;
		public Space space;
		public SharedGameObject storeHitObject;
		public SharedVector2 storeHitPoint;
		public SharedVector2 storeHitNormal;
		public SharedFloat storeHitDistance;
	}
}
