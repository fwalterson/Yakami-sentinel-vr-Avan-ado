using UnityEngine;

public class tempo : MonoBehaviour
{
    public Material[] ceus;
    public float tempoTroca = 10f; // Tempo para trocar

    private float tempoAtual;
    private int indiceAtual = 0;

    void Start()
    {
        if (ceus.Length > 0)
        {
            RenderSettings.skybox = ceus[0];
        }
    }

    void Update()
    {
        tempoAtual += Time.deltaTime;

        if (tempoAtual >= tempoTroca)
        {
            tempoAtual = 0;

            indiceAtual++;

            if (indiceAtual >= ceus.Length)
            {
                indiceAtual = 0;
            }

            RenderSettings.skybox = ceus[indiceAtual];
        }
    }
}