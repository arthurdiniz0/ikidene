using UnityEngine;

namespace RPGCharacterAnims
{
	public class RPGCharacterInputController : MonoBehaviour
	{
		public bool inputJump;
		public bool inputLightHit;
		public bool inputDeath;
		public bool inputAttackL;
		public bool inputAttackR;
		public bool inputCastL;
		public bool inputCastR;
		public float inputSwitchUpDown;
		public float inputSwitchLeftRight;
		public bool inputStrafe;
		public float inputTargetBlock;
		public float inputAimVertical;
		public float inputAimHorizontal;
		public float inputHorizontal;
		public float inputVertical;
		public bool inputAiming;
		public bool inputRoll;
		public bool inputShield;
		public bool inputRelax;
		public bool allowedInput;
		public Vector3 moveInput;
		public Vector2 aimInput;
	}
}
