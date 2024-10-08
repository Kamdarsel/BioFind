using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    // Lista de los objetos a controlar
    public List<GameObject> objectsToSpawn;

    // Cantidad de objetos que aparecerán
    public int numberOfObjectsToAppear;

    void Start()
    {
        // Verificar que el número de objetos no sea mayor que la lista de objetos
        if (numberOfObjectsToAppear > objectsToSpawn.Count)
        {
            numberOfObjectsToAppear = objectsToSpawn.Count;
        }

        // Desactivar todos los objetos al inicio
        foreach (GameObject obj in objectsToSpawn)
        {
            obj.SetActive(false);
        }

        // Aparecer objetos de manera aleatoria
        SpawnRandomObjects();
    }

    void SpawnRandomObjects()
    {
        // Crear una lista temporal con índices disponibles
        List<int> availableIndices = new List<int>();
        for (int i = 0; i < objectsToSpawn.Count; i++)
        {
            availableIndices.Add(i);
        }

        // Aparecer un número determinado de objetos
        for (int i = 0; i < numberOfObjectsToAppear; i++)
        {
            // Seleccionar un índice aleatorio de la lista de disponibles
            int randomIndex = Random.Range(0, availableIndices.Count);
            int objectIndex = availableIndices[randomIndex];

            // Activar el objeto correspondiente
            objectsToSpawn[objectIndex].SetActive(true);

            // Remover el índice seleccionado de la lista de disponibles
            availableIndices.RemoveAt(randomIndex);
        }
    }
}
