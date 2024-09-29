using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class PlayRandomSound : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmVector3 position;
		public FsmObject[] audioClips;
		public FsmFloat[] weights;
		public FsmFloat volume;
		public FsmBool noRepeat;
	}
}
