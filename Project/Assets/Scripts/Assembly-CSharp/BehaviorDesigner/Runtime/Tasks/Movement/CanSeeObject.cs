using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class CanSeeObject : Conditional
	{
		public bool usePhysics2D;
		public SharedGameObject targetObject;
		public SharedGameObjectList targetObjects;
		public SharedString targetTag;
		public LayerMask objectLayerMask;
		public LayerMask ignoreLayerMask;
		public SharedFloat fieldOfViewAngle;
		public SharedFloat viewDistance;
		public SharedVector3 offset;
		public SharedVector3 targetOffset;
		public SharedFloat angleOffset2D;
		public SharedBool useTargetBone;
		public HumanBodyBones targetBone;
		public SharedGameObject returnedObject;
	}
}
