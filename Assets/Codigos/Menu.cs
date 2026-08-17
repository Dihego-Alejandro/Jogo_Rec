using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Botão JOGAR
    public void Jogar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Fase1");
    }

    // Botão SAIR
    public void Sair()
    {
        Application.Quit();

        Debug.Log("Jogo fechado!");
    }
}