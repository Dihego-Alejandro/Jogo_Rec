using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject telaDerrota;

    void Start()
    {
        telaDerrota.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MostrarDerrota()
    {
        telaDerrota.SetActive(true);

        Time.timeScale = 0f;
    }

    public void VoltarAoMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}