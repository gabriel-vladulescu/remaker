using System.Collections.Generic;
using Artemis;
using SSAR.BattleSystem.AI;
using SSAR.BattleSystem.Input;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Input.Model;
using SSAR.Dungeon.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class UserButtonInputLayout : strange.extensions.mediation.impl.View
	{
		private class CacheSpriteInfo
		{
			private UISprite sprite;

			private int width;

			private int height;

			private string icon;

			private INGUIAtlas atlas;

			public CacheSpriteInfo(UISprite sprite)
			{
			}

			public void Revert()
			{
			}
		}

		public float testdamage;

		public bool isHeal;

		public List<KeyCode> moveRight;

		public List<KeyCode> moveLeft;

		public List<KeyCode> jump;

		public List<KeyCode> dash;

		public List<KeyCode> attack;

		public List<KeyCode> skill1;

		public List<KeyCode> skill2;

		public List<KeyCode> skill3;

		public List<KeyCode> skill4;

		public List<KeyCode> ancient1;

		public List<KeyCode> ancient2;

		public GameObject btn_jump;

		public GameObject btn_dash;

		public GameObject btn_attack;

		public GameObject container_skill1;

		public GameObject container_skill2;

		public GameObject container_skill3;

		public GameObject container_skill4;

		public GameObject container_ancient1;

		public GameObject container_ancient2;

		public GameObject container_attack;

		public GameObject container_jump;

		public GameObject container_dash;

		public GameObject controllerContainer;

		public JoyStick JoyStick;

		public GameObject fxBtnAttack;

		public Entity target;

		public float changeDirectionThreshold;

		private ButtonSkillView btn_skill1;

		private ButtonSkillView btn_skill2;

		private ButtonSkillView btn_skill3;

		private ButtonSkillView btn_skill4;

		private ButtonAncientSkillView btn_ancient1;

		private ButtonAncientSkillView btn_ancient2;

		private bool firstInput;

		private bool enableAI;

		private bool isSkill1KeyPressed;

		private bool isChar3Arcane;

		private List<CacheSpriteInfo> cacheSpriteInfos;

		private List<TimerAction> timerActions;

		private List<TimerAction> actionDone;

		private bool isLeftDirectionHeld;

		private bool isRightDirectionHeld;

		private Vector2 joyStickPrepos;

		private bool released;

		// Simplified input wiring: this View is the bridge between the real
		// NGUI JoyStick/buttons and the ECS-side CharacterInput once
		// InitDungeonSystemCmd spawns the main character. The full game also
		// juggles AI takeover, skill buttons and ancient forms here; those are
		// out of scope for movement/input testing and left as no-ops.
		private CharacterInput characterInput;

		private MovementComponent movementComponent;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
			HideAllButton(true);
		}

		public void HideAllButton(bool hide)
		{
			bool show = !hide;
			if (controllerContainer != null)
			{
				NGUITools.SetActive(controllerContainer, show);
			}
		}

		public void ShowButtonAttack()
		{
			if (container_attack != null)
			{
				NGUITools.SetActive(container_attack, true);
			}
		}

		public void ShowJoyStick()
		{
			if (JoyStick != null)
			{
				JoyStick.SetEnableJoystick(true);
			}
		}

		public void ShowButtonJump()
		{
			if (container_jump != null)
			{
				NGUITools.SetActive(container_jump, true);
			}
		}

		public void ShowButtonDash()
		{
			if (container_dash != null)
			{
				NGUITools.SetActive(container_dash, true);
			}
		}

		public void ShowButtonSkill(List<ButtonSkillType> buttonSkillTypes)
		{
		}

		public void StopMoveJoyStick()
		{
		}

		public void BackToNormalForm(Entity entity)
		{
		}

		public void ChangeToArcaneForm(Entity entity)
		{
		}

		private void AddLockObject(GameObject parent, UIAtlas bgAtlas, string bgSpriteName)
		{
		}

		public void PlayFx()
		{
		}

		private void RemoveLockObject(GameObject parent)
		{
		}

		public void Hide(DungeonWinParameter dungeonWinParameter)
		{
		}

		public void Init()
		{
			HideAllButton(true);
		}

		private void InitActiveSkills()
		{
		}

		private void InitAncientSkills()
		{
		}

		public void OnSpawnMainCharacter(Entity entity)
		{
			target = entity;
			if (entity == null)
			{
				return;
			}

			CharacterInputComponent inputComponent = entity.GetComponent<CharacterInputComponent>();
			characterInput = (inputComponent != null) ? inputComponent.CharacterInput : null;
			movementComponent = entity.GetComponent<MovementComponent>();

			HideAllButton(false);
			SetupJoyStick();
			SetupButton();
			ShowJoyStick();
			ShowButtonJump();
			ShowButtonDash();
			ShowButtonAttack();
		}

		private void AncientOnSpawnCharacter(Entity entity)
		{
		}

		private void SetupJoyStick()
		{
			if (JoyStick == null)
			{
				return;
			}
			JoyStick.onDragDelegate -= OnJoyStickDrag;
			JoyStick.onDragDelegate += OnJoyStickDrag;
			JoyStick.onFinishDelegate -= RunInputRelease;
			JoyStick.onFinishDelegate += RunInputRelease;
		}

		private void OnJoyStickDrag(Vector2 position)
		{
			if (changeDirectionThreshold <= 0f)
			{
				changeDirectionThreshold = 0.15f;
			}

			if (Mathf.Abs(position.x) < changeDirectionThreshold)
			{
				RunInputRelease();
				return;
			}

			Run(position, true);
		}

		private void SetupButton()
		{
			if (btn_jump != null)
			{
				UIEventListener.Get(btn_jump).onClick -= OnJumpButtonClick;
				UIEventListener.Get(btn_jump).onClick += OnJumpButtonClick;
			}
			if (btn_dash != null)
			{
				UIEventListener.Get(btn_dash).onClick -= OnDashButtonClick;
				UIEventListener.Get(btn_dash).onClick += OnDashButtonClick;
			}
			if (btn_attack != null)
			{
				UIEventListener.Get(btn_attack).onClick -= OnAttackButtonClick;
				UIEventListener.Get(btn_attack).onClick += OnAttackButtonClick;
			}
		}

		private void OnJumpButtonClick(GameObject go)
		{
			JumpAndAutoRelease();
		}

		private void OnDashButtonClick(GameObject go)
		{
			DashAndAutoRelease();
		}

		private void OnAttackButtonClick(GameObject go)
		{
			AttackWithoutAutoRelease();
		}

		private void DelegateCastSkill1()
		{
		}

		private void Update()
		{
		}

		private void OnUpdateSync(float deltaTime)
		{
		}

		private void TestInput()
		{
		}

		private void TestDevour()
		{
		}

		private void TestPetSkill(ActionType actionType)
		{
		}

		private void TestPetMove(Vector2 dir, bool changeFace)
		{
		}

		private void TestPetEndMove()
		{
		}

		private void TestMonsterSkill(ActionType actionType)
		{
		}

		private void TestMonsterMove(Vector2 dir, bool changeFace)
		{
		}

		private void TestMonsterEndMove()
		{
		}

		private void CastSkill1()
		{
		}

		private void CastSkill2()
		{
		}

		private void CastSkill3()
		{
		}

		private void CastSkill4()
		{
		}

		private void CastAncientSkill1()
		{
		}

		private void CastAncientSkill2()
		{
		}

		internal void LoadButtonTemplate()
		{
		}

		private void MappingButtonsFromTemplate(SkillInputLayoutTemplate template)
		{
		}

		private void MappingButtonScale(GameObject container, Vector3 scaleTo)
		{
		}

		private void InitButtonSkillView()
		{
		}

		// "AutoRelease" buttons (jump/dash/attack) are one-shot presses rather
		// than held state, so they fire and release on the same click instead
		// of needing separate press/release UI events.
		private void AttackWithoutAutoRelease()
		{
			Attack();
		}

		private void JumpAndAutoRelease()
		{
			Jump();
			JumpRelease();
		}

		private void DashAndAutoRelease()
		{
			Dash(0);
			DashRelease();
		}

		private void Run(Vector2 dir, bool changeFace)
		{
			if (characterInput == null || movementComponent == null)
			{
				return;
			}
			Direction direction = (dir.x >= 0f) ? Direction.Right : Direction.Left;
			characterInput.Run(new RunRequest(AccessLevel.UserAccess, movementComponent.runData, direction, true), false);
		}

		private void RunInputRelease()
		{
			if (characterInput == null)
			{
				return;
			}
			characterInput.ReleaseRunInput();
		}

		private void Attack()
		{
		}

		private void AttackRelease()
		{
		}

		private void Jump()
		{
			if (characterInput == null || movementComponent == null)
			{
				return;
			}
			characterInput.Jump(new JumpRequest(AccessLevel.UserAccess, movementComponent.jumpData));
		}

		private void JumpRelease()
		{
			if (characterInput == null)
			{
				return;
			}
			characterInput.ReleaseInputJump();
		}

		private void Dash(int bufferCount)
		{
			if (characterInput == null || movementComponent == null)
			{
				return;
			}
			characterInput.Dash(new DashRequest(AccessLevel.UserAccess, movementComponent.dashData), bufferCount);
		}

		private void DashRelease()
		{
			if (characterInput == null)
			{
				return;
			}
			characterInput.ReleaseInputDash();
		}

		private void CastSkill(ActionType actionType, ActionType castSkillRelease)
		{
		}

		private void CastSkillAndAutoRelase(ActionType actionType, ActionType castSkillRelease)
		{
		}

		public UniversalInputSystem UniversalInputSystem()
		{
			return null;
		}

		private InputMappingDataManager GetInputData()
		{
			return null;
		}
	}
}
