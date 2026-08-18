using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Prefabs dos Canos")]
    public GameObject canoCima;
    public GameObject canoBaixo;

    [Header("Posição")]
    public float distanciaX = 20f;

    [Header("Altura")]
    public float alturaMinima = -2f;
    public float alturaMaxima = 3f;

    [Header("Espaço entre os canos")]
    public float tamanhoDoBuraco = 5f;

    [Header("Intervalo")]
    public float intervalo = 2.5f;

    [Header("Velocidade")]
    public float velocidadeCanos = 5f;

    [Header("Destruição")]
    public float tempoParaDestruir = 15f;

    private float tempo;

    void Start()
    {
        tempo = intervalo;
    }

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
        // Escolhe uma altura aleatória
        float altura = Random.Range(
            alturaMinima,
            alturaMaxima
        );

        // Posição inicial
        Vector3 posicao = transform.position;

        // Os canos aparecem à direita
        posicao.x = distanciaX;

        // =========================
        // CANO DE CIMA
        // =========================

        Vector3 posicaoCima = posicao;

        posicaoCima.y =
            altura + tamanhoDoBuraco / 2f;

        GameObject cima = Instantiate(
            canoCima,
            posicaoCima,
            Quaternion.identity
        );

        PipeMove movimentoCima =
            cima.GetComponent<PipeMove>();

        if (movimentoCima != null)
        {
            movimentoCima.velocidade = velocidadeCanos;
        }

        // =========================
        // CANO DE BAIXO
        // =========================

        Vector3 posicaoBaixo = posicao;

        posicaoBaixo.y =
            altura - tamanhoDoBuraco / 2f;

        GameObject baixo = Instantiate(
            canoBaixo,
            posicaoBaixo,
            Quaternion.identity
        );

        PipeMove movimentoBaixo =
            baixo.GetComponent<PipeMove>();

        if (movimentoBaixo != null)
        {
            movimentoBaixo.velocidade = velocidadeCanos;
        }

        // Destrói os canos depois de um tempo
        Destroy(cima, tempoParaDestruir);
        Destroy(baixo, tempoParaDestruir);
    }
}