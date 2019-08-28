using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject Grama, Pedra;

    //configuracao da onda

    //tamanho da onda max e min a partir do ponto de equilibrio
    public float amplitude;
    //refere ao quao pontuda e a onda
    public float frequencia;
    //colunas e linhas
    public int Colunas;
    public int Linhas;


    // Start is called before the first frame update
    void Start()
    {
        GeraTerreno();
    }


    void GeraTerreno()
    {
        //cria uma grid
        for (int x = 0; x < Colunas; x++)
        {
            for (int z = 0; z < Linhas; z++)
            {
                float y = Mathf.PerlinNoise(x/frequencia,z/frequencia) * amplitude;

                if (y > 5)
                {
                    Instantiate(Grama, new Vector3 (x,y,z),Quaternion.identity);
                }
                else if (y <= 5)
                {
                    Instantiate(Pedra, new Vector3(x, y, z), Quaternion.identity);
                }

            }
        }

    }
    
}
