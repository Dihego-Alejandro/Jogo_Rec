using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameOver gameOver;

    private bool morreu = false;

    public void Morrer()
    {
        if (morreu)
            return;

        morreu = true;

        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.isKinematic = true;
        }

        if (gameOver != null)
        {
            gameOver.MostrarDerrota();
        }

        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pipe"))
        {
            Morrer();
        }
    }
}