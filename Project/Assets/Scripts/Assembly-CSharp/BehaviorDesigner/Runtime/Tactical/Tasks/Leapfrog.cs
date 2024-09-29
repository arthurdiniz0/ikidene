using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks
{
	public class Leapfrog : NavMeshTacticalGroup
	{
		public SharedFloat separation;
		public SharedFloat groupSeparation;
		public SharedFloat leapDistance;
	}
}
