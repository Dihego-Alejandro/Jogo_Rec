using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform jogador;

    void LateUpdate()
    {
        if (jogador == null)
            return;

        // A câmera mantém X e Z fixos
        // e acompanha apenas a altura do jogador
        transform.position = new Vector3(
            transform.position.x,
            jogador.position.y,
            transform.position.z
        );
    }
}