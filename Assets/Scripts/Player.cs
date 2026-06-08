using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float ScrollSpeed = 2.5f;
    [SerializeField] private float flyForce = 2.5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(ScrollSpeed, rb.linearVelocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * flyForce);
        }
    }
}

