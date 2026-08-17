using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Jogador")]
    public Transform jogador;

    [Header("Prefabs dos Canos")]
    public GameObject canoCima;
    public GameObject canoBaixo;

    [Header("Distância")]
    public float distanciaDoJogador = 20f;

    [Header("Altura")]
    public float alturaMinima = -2f;
    public float alturaMaxima = 3f;

    [Header("Espaço entre os canos")]
    public float tamanhoDoBuraco = 5f;

    [Header("Tempo entre os canos")]
    public float intervalo = 2.5f;

    private float tempo;

    void Update()
    {
        tempo += Time.deltaTime;

        if (tempo >= intervalo)
        {
            CriarCanos();
            tempo = 0f;
        }
    }

    void CriarCanos()
    {
        // Altura aleatória
        float altura = Random.Range(alturaMinima, alturaMaxima);

        // Começa na posição do jogador
        Vector3 posicao = jogador.position;

        // Coloca os canos à frente do jogador no eixo X
        posicao.x += distanciaDoJogador;

        // Cano de cima
        Vector3 posicaoCima = posicao;
        posicaoCima.y = altura + tamanhoDoBuraco / 2f;

        // Cano de baixo
        Vector3 posicaoBaixo = posicao;
        posicaoBaixo.y = altura - tamanhoDoBuraco / 2f;

        // Cria os canos
        GameObject cima = Instantiate(
            canoCima,
            posicaoCima,
            Quaternion.identity
        );

        GameObject baixo = Instantiate(
            canoBaixo,
            posicaoBaixo,
            Quaternion.identity
        );

        // Coloca o movimento
        cima.AddComponent<PipeMove>();
        baixo.AddComponent<PipeMove>();

        // Destrói depois de 15 segundos
        Destroy(cima, 15f);
        Destroy(baixo, 15f);
    }
}