using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    public bool isActive;
    [SerializeField] private Transform Saw;
    [SerializeField] private List<Transform> targets = new List<Transform>();
    [SerializeField] private float speed;
    [SerializeField] private int currTarget;
    [SerializeField] private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        Saw.position = targets[0].position;
        currTarget = 0;
    }
    private void Update()
    {
        if (isActive == true)
        {
            TurnOn();
            if (Saw.position == targets[currTarget].position)
            {
                currTarget++;
            }
            if (currTarget >= targets.Count)
            {
                currTarget = 0;
            }
            Saw.position = Vector2.MoveTowards(Saw.position, targets[currTarget].position, Time.deltaTime * speed);
        }
        else
        {
            TurnOff();
        }
    }
    private void TurnOn()
    {
        animator.SetBool("IsOn", true);
        animator.SetBool("IsOff", false);
    }
    private void TurnOff()
    {
        animator.SetBool("IsOn", false);
        animator.SetBool("IsOff", true);
    }
}
