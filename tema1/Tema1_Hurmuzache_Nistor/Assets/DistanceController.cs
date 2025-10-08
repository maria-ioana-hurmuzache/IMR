using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using static UnityEngine.GraphicsBuffer;

public class StateChanging : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public Animator anim1;
    public Animator anim2;
    public float attackDistance = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target1 == null || target2 == null) return;

        float distance = Vector3.Distance(target1.position, target2.position);
        bool isClose = distance < attackDistance;

        if (isClose)
        {
            anim1.SetTrigger("isAttacking");
            anim2.SetTrigger("isAttacking");
        }
        else if (!isClose)
        {
            anim1.ResetTrigger("isAttacking");
            anim2.ResetTrigger("isAttacking");
        }
    }
}
