using UnityEngine;

public class ZonaMorte : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerDeath jogador =
            other.GetComponent<PlayerDeath>();

        if (jogador != null)
        {
            jogador.Morrer();
        }
    }
}