using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class CanHearObject : Conditional
	{
		public bool usePhysics2D;
		public SharedGameObject targetObject;
		public SharedGameObjectList targetObjects;
		public SharedString targetTag;
		public LayerMask objectLayerMask;
		public SharedFloat hearingRadius;
		public SharedFloat audibilityThreshold;
		public SharedVector3 offset;
		public SharedGameObject returnedObject;
	}
}
