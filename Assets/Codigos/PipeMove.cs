using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        transform.Translate(
            Vector3.left * velocidade * Time.deltaTime
        );
    }
}