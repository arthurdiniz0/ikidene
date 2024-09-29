using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks
{
	public class Flank : NavMeshTacticalGroup
	{
		public SharedBool dualFlank;
		public SharedFloat attackDelay;
		public SharedFloat approachDistance;
		public SharedFloat separation;
	}
}
