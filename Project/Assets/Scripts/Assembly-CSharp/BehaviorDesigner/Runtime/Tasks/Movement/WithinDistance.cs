using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class WithinDistance : Conditional
	{
		public bool usePhysics2D;
		public SharedGameObject targetObject;
		public SharedString targetTag;
		public LayerMask objectLayerMask;
		public SharedFloat magnitude;
		public SharedBool lineOfSight;
		public LayerMask ignoreLayerMask;
		public SharedVector3 offset;
		public SharedVector3 targetOffset;
		public SharedGameObject returnedObject;
	}
}
