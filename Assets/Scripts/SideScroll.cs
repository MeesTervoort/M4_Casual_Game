using UnityEngine;

public class SideScroll : MonoBehaviour
{
    [SerializeField] private float ScrollSpeed = 2.5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(ScrollSpeed, rb.linearVelocity.x);
        
    }
}

