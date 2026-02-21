using UnityEngine;

public class ParalaxEffect : MonoBehaviour
{
    [SerializeField] Renderer bgRenderer;
    [SerializeField] private float speed;

    private void Start()
    {
        bgRenderer = GetComponent<Renderer>();
    }
    private void Update()
    {
        bgRenderer.material.mainTextureOffset = new Vector2(0, Time.time * speed);
    }
}
