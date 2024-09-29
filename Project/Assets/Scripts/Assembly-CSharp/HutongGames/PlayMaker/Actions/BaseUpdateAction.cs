using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class BaseUpdateAction : FsmStateAction
	{
		public enum UpdateType
		{
			OnUpdate = 0,
			OnLateUpdate = 1,
			OnFixedUpdate = 2,
		}

		public bool everyFrame;
		public UpdateType updateType;
	}
}
