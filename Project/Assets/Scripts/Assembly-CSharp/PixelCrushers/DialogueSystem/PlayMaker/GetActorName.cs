using HutongGames.PlayMaker;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class GetActorName : FsmStateAction
	{
		public FsmOwnerDefault gameObject;
		public FsmBool getInternalName;
		public FsmString storeStringResult;
	}
}
