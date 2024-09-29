using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Search : NavMeshMovement
	{
		public SharedFloat minWanderDistance;
		public SharedFloat maxWanderDistance;
		public SharedFloat wanderRate;
		public SharedFloat minPauseDuration;
		public SharedFloat maxPauseDuration;
		public SharedInt targetRetries;
		public SharedFloat fieldOfViewAngle;
		public SharedFloat viewDistance;
		public LayerMask ignoreLayerMask;
		public SharedBool senseAudio;
		public SharedFloat hearingRadius;
		public SharedVector3 offset;
		public SharedVector3 targetOffset;
		public LayerMask objectLayerMask;
		public SharedBool useTargetBone;
		public HumanBodyBones targetBone;
		public SharedFloat audibilityThreshold;
		public SharedGameObject returnedObject;
	}
}
