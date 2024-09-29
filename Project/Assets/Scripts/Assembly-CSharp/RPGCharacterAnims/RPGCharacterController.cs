using UnityEngine;

namespace RPGCharacterAnims
{
	public class RPGCharacterController : MonoBehaviour
	{
		public RPGCharacterMovementController rpgCharacterMovementController;
		public RPGCharacterWeaponController rpgCharacterWeaponController;
		public RPGCharacterInputController rpgCharacterInputController;
		public Animator animator;
		public IKHands ikHands;
		public Weapon weapon;
		public GameObject target;
		public bool isDead;
		public bool isBlocking;
		public bool canAction;
		public bool isSitting;
		public bool isClimbing;
		public bool isNearLadder;
		public bool isNearCliff;
		public GameObject ladder;
		public GameObject cliff;
		public bool isCasting;
		public bool isAiming;
		public bool isStrafing;
		public bool injured;
		public bool hipShooting;
		public int specialAttack;
		public float aimHorizontal;
		public float aimVertical;
		public float bowPull;
		public bool headLook;
		public int numberOfConversationClips;
		public float animationSpeed;
	}
}
