
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector3 offset;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        offset = transform.position - Camera.main.transform.position;
    }

    private void Update()
    {

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);


        Camera.main.transform.position = new Vector3(transform.position.x - offset.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
    }
}
