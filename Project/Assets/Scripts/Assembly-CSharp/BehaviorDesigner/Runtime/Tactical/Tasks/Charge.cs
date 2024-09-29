using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks
{
	public class Charge : NavMeshTacticalGroup
	{
		public SharedInt agentsPerRow;
		public SharedVector2 separation;
		public SharedFloat attackDistance;
	}
}
