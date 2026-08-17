using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject telaDerrota;

    public void MostrarDerrota()
    {
        telaDerrota.SetActive(true);

        // Para o jogo
        Time.timeScale = 0f;
    }

    public void VoltarAoMenu()
    {
        // Volta o tempo ao normal
        Time.timeScale = 1f;

        // Carrega a cena do menu
        SceneManager.LoadScene("Menu");
    }
}