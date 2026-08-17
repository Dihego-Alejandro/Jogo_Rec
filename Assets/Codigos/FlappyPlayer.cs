using UnityEngine;

public class FlappyPlayer : MonoBehaviour
{
    public float forcaDoPulo = 7f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(
                0f,
                forcaDoPulo,
                0f
            );
        }
    }
}