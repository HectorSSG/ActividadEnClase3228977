using UnityEngine;

public class StopMovement : MonoBehaviour
{
    public bool isItMoving = false;
    public SawMovement sawMovement;
    public Animator sawAnimation;

    private void Start()
    {
        SawMovement sawMovement = GetComponent<SawMovement>();
    }
    private void Update()
    {
        sawMovement.enabled = isItMoving;
        sawAnimation.enabled = isItMoving;
    }

}
