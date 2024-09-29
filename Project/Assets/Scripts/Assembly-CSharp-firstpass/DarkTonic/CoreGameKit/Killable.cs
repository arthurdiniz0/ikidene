using UnityEngine;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	public class Killable : MonoBehaviour
	{
		public enum SpawnSource
		{
			None = 0,
			Specific = 1,
			PrefabPool = 2,
		}

		public enum DespawnMode
		{
			None = -1,
			ZeroHitPoints = 0,
			LostAnyHitPoints = 1,
			CollisionOrTrigger = 2,
		}

		public enum DamagePrefabSpawnMode
		{
			None = 0,
			PerHit = 1,
			PerHitPointLost = 2,
			PerGroupHitPointsLost = 3,
		}

		public enum DeathPrefabSpawnLocation
		{
			DeathPosition = 0,
			RespawnPosition = 1,
		}

		public enum RotationMode
		{
			CustomRotation = 0,
			InheritExistingRotation = 1,
			UseDeathPrefabRotation = 2,
		}

		public enum SpawnerDestroyedBehavior
		{
			DoNothing = 0,
			Despawn = 1,
			Die = 2,
		}

		public enum DeathDespawnBehavior
		{
			ReturnToPool = 0,
			Disable = 1,
		}

		public enum RespawnType
		{
			None = 0,
			Infinite = 1,
			SetNumber = 2,
		}

		public TriggeredSpawner.GameOverBehavior gameOverBehavior;
		public bool syncHitPointWorldVariable;
		public KillerInt hitPoints;
		public KillerInt maxHitPoints;
		public KillerInt atckPoints;
		public KillableListener listener;
		public bool invincibilityExpanded;
		public bool isInvincible;
		public bool invincibleWhileChildrenKillablesExist;
		public bool disableCollidersWhileChildrenKillablesExist;
		public bool invincibleOnSpawn;
		public KillerFloat invincibleTimeSpawn;
		public bool invincibleWhenDamaged;
		public KillerFloat invincibleDamageTime;
		public SpawnSource invinceHitPrefabSource;
		public int invinceHitPrefabPoolIndex;
		public string invinceHitPrefabPoolName;
		public Transform invinceHitPrefabSpecific;
		public string invinceHitPrefabCategoryName;
		public bool invinceHitPrefabRandomizeXRotation;
		public bool invinceHitPrefabRandomizeYRotation;
		public bool invinceHitPrefabRandomizeZRotation;
		public bool enableLogging;
		public bool filtersExpanded;
		public bool ignoreKillablesSpawnedByMe;
		public bool useLayerFilter;
		public bool useTagFilter;
		public bool showVisibilitySettings;
		public bool despawnWhenOffscreen;
		public bool despawnOnClick;
		public bool despawnOnMouseClick;
		public bool despawnIfNotVisible;
		public KillerFloat despawnIfNotVisibleForSec;
		public SpawnSource vanishPrefabSource;
		public int vanishPrefabPoolIndex;
		public string vanishPrefabPoolName;
		public Transform vanishPrefabSpecific;
		public string vanishPrefabCategoryName;
		public bool vanishPrefabRandomizeXRotation;
		public bool vanishPrefabRandomizeYRotation;
		public bool vanishPrefabRandomizeZRotation;
		public bool ignoreOffscreenHits;
		public List<string> matchingTags;
		public List<int> matchingLayers;
		public DespawnMode despawnMode;
		public bool includeNonKillables;
		public bool damageFireEvents;
		public List<CGKCustomEventToFire> damageCustomEvents;
		public bool deathFireEvents;
		public List<CGKCustomEventToFire> deathCustomEvents;
		public bool despawnStatModifiersExpanded;
		public WorldVariableCollection playerStatDespawnModifiers;
		public List<WorldVariableCollection> alternateModifiers;
		public bool dealDamagePrefabExpanded;
		public SpawnSource dealDamagePrefabSource;
		public int dealDamagePrefabPoolIndex;
		public string dealDamagePrefabPoolName;
		public Transform dealDamagePrefabSpecific;
		public string dealDamagePrefabCategoryName;
		public bool dealDamagePrefabOnDeathHit;
		public bool dealDamagePrefabRandomizeXRotation;
		public bool dealDamagePrefabRandomizeYRotation;
		public bool dealDamagePrefabRandomizeZRotation;
		public bool damagePrefabExpanded;
		public SpawnSource damagePrefabSource;
		public int damagePrefabPoolIndex;
		public string damagePrefabPoolName;
		public Transform damagePrefabSpecific;
		public string damagePrefabCategoryName;
		public DamagePrefabSpawnMode damagePrefabSpawnMode;
		public KillerInt damagePrefabSpawnQuantity;
		public KillerInt damageGroupsize;
		public Vector3 damagePrefabOffset;
		public Vector3 damagePrefabIncrementalOffset;
		public bool damagePrefabRandomizeXRotation;
		public bool damagePrefabRandomizeYRotation;
		public bool damagePrefabRandomizeZRotation;
		public bool despawnStatDamageModifiersExpanded;
		public bool damagePrefabOnDeathHit;
		public WorldVariableCollection playerStatDamageModifiers;
		public bool damageKnockBackExpanded;
		public bool sendDamageKnockback;
		public bool receiveKnockbackWhenDamaged;
		public bool receiveKnockbackWhenInvince;
		public KillerFloat damageKnockUpMeters;
		public KillerFloat damageKnockBackFactor;
		public WaveSpecifics.SpawnOrigin deathPrefabSource;
		public int deathPrefabPoolIndex;
		public string deathPrefabPoolName;
		public bool deathPrefabSettingsExpanded;
		public Transform deathPrefabSpecific;
		public string deathPrefabCategoryName;
		public bool deathPrefabKeepSameParent;
		public KillerInt deathPrefabSpawnPercent;
		public DeathPrefabSpawnLocation deathPrefabSpawnLocation;
		public KillerInt deathPrefabQty;
		public Vector3 deathPrefabOffset;
		public Vector3 deathPrefabIncrementalOffset;
		public RotationMode rotationMode;
		public bool deathPrefabRandomizeXRotation;
		public bool deathPrefabRandomizeYRotation;
		public bool deathPrefabRandomizeZRotation;
		public bool deathPrefabKeepVelocity;
		public Vector3 deathPrefabCustomRotation;
		public KillerFloat deathDelay;
		public SpawnerDestroyedBehavior spawnerDestroyedAction;
		public Killable parentKillableForParentDestroyed;
		public SpawnerDestroyedBehavior parentDestroyedAction;
		public DeathDespawnBehavior deathDespawnBehavior;
		public bool timerDeathEnabled;
		public KillerFloat timerDeathSeconds;
		public SpawnerDestroyedBehavior timeUpAction;
		public bool distanceDeathEnabled;
		public KillerFloat tooFarDistance;
		public SpawnerDestroyedBehavior distanceDeathAction;
		public int currentHitPoints;
		public bool isVisible;
		public bool showRespawnSettings;
		public RespawnType respawnType;
		public int timesToRespawn;
		public KillerFloat respawnDelay;
		public bool respawnFireEvents;
		public List<CGKCustomEventToFire> respawnCustomEvents;
	}
}
