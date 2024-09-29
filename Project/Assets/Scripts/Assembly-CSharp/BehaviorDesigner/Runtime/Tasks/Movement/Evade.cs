using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Evade : NavMeshMovement
	{
		public SharedFloat evadeDistance;
		public SharedFloat lookAheadDistance;
		public SharedFloat targetDistPrediction;
		public SharedFloat targetDistPredictionMult;
		public SharedGameObject target;
	}
}
