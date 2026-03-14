using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isMove = false;
    public GameObject saw;

    void Update()
    {
        saw.SetActive(isMove);;
    }
}
