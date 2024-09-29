using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Pursue : NavMeshMovement
	{
		public SharedFloat targetDistPrediction;
		public SharedFloat targetDistPredictionMult;
		public SharedGameObject target;
	}
}
