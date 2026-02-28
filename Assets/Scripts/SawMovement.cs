using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    [SerializeField] private Transform Saw;
    [SerializeField] private List<Transform> targets = new List<Transform>();
    [SerializeField] private float speed;
    [SerializeField] private int currTarget;
    private void Start()
    {
        Saw.position = targets[0].position;
        currTarget = 0;
    }
    private void Update()
    {
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
}
