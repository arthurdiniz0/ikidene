using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks
{
	public class ShootAndScoot : NavMeshTacticalGroup
	{
		public SharedInt agentsPerRow;
		public SharedVector2 separation;
		public SharedFloat timeStationary;
		public SharedFloat minMoveAngle;
		public SharedFloat maxMoveAngle;
		public SharedFloat minAttackRadius;
		public SharedFloat maxAttackRadius;
	}
}
