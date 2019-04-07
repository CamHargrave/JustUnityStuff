using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBaseFSM : StateMachineBehaviour
{
    public GameObject NPC;
    public GameObject opponent;
    [SerializeField]
    public float turnspeed = 2f;
    [SerializeField]
    public float movespeed = 2f;
    [SerializeField]
    public float closeToWaypoint = 2f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPC = animator.gameObject;
        opponent = NPC.GetComponent<Enemy>().GetEnemy();
    }


}
