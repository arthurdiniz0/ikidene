using UnityEngine.AI;
using UnityEngine;

namespace RPGCharacterAnims
{
	public class RPGCharacterMovementController : SuperStateMachine
	{
		public NavMeshAgent navMeshAgent;
		public RPGCharacterState rpgCharacterState;
		public bool useMeshNav;
		public bool isKnockback;
		public float knockbackMultiplier;
		public bool canJump;
		public bool canDoubleJump;
		public float gravity;
		public float jumpAcceleration;
		public float jumpHeight;
		public float doubleJumpHeight;
		public Vector3 currentVelocity;
		public bool isMoving;
		public bool canMove;
		public bool crouch;
		public bool isSprinting;
		public float movementAcceleration;
		public float walkSpeed;
		public float runSpeed;
		public float sprintSpeed;
		public float groundFriction;
		public bool isRolling;
		public float rollSpeed;
		public float rollduration;
		public float inAirSpeed;
		public float swimSpeed;
		public float waterFriction;
	}
}
