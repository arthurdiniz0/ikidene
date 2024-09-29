using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Cover : NavMeshMovement
	{
		public SharedFloat maxCoverDistance;
		public LayerMask availableLayerCovers;
		public SharedInt maxRaycasts;
		public SharedFloat rayStep;
		public SharedFloat coverOffset;
		public SharedBool lookAtCoverPoint;
		public SharedFloat rotationEpsilon;
		public SharedFloat maxLookAtRotationDelta;
	}
}
