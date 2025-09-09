using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAnimationData
{
    [SerializeField] private string groundParameterName = "@Ground";
    [SerializeField] private string idleParameterName = "Idle";
    [SerializeField] private string walkParameterName = "Walk";
    [SerializeField] private string runParameterName = "Run";

    [SerializeField] private string airParameterName = "@Air";
    [SerializeField] private string jumpParameterName = "Jump";
    [SerializeField] private string fallParameterName = "Fall";

    [SerializeField] private string attackParameterName = "@Attack";
    [SerializeField] private string comboAttackParameterName = "ComboAttack";
    
    public int GroundParameterHash { get; private set; }
    public int IdleParameterHash { get; private set; }
    public int WalkParameterHash { get; private set; }
    public int RunParameterHash { get; private set; }
    public int AirParameterName { get; private set; }
    public int JumpParameterName { get; private set; }
    public int FallParameterName { get; private set; }
    public int AttackParameterName { get; private set; }
    public int ComboAttackParameterName { get; private set; }

    public void Initialize()
    {
        GroundParameterHash = Animator.StringToHash(groundParameterName);
        IdleParameterHash = Animator.StringToHash(idleParameterName);
        WalkParameterHash = Animator.StringToHash(walkParameterName);
        RunParameterHash = Animator.StringToHash(runParameterName);
        AirParameterName = Animator.StringToHash(airParameterName);
        JumpParameterName = Animator.StringToHash(jumpParameterName);
        FallParameterName = Animator.StringToHash(fallParameterName);
        AttackParameterName = Animator.StringToHash(attackParameterName);
        ComboAttackParameterName = Animator.StringToHash(comboAttackParameterName);

    }
}
