using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject eggPrefab;
    //public int eggCount;

    private float maxXPos = 4f; // boundaries whithin egg must spawn
    private float minXPos = -4f;
    private float maxZPos = 4f;
    private float minZPos = 0.5f;

    private float xPos;
    private float zPos;


    public void StartEggDrop()
    {
        StartCoroutine(EggDrop());
    }

    public void StopEggDrop()
    {
        StopCoroutine(EggDrop());
    }

    public void DestroyAllEggs()
    {
        GameObject[] eggs = GameObject.FindGameObjectsWithTag("Egg");
        foreach (GameObject egg in eggs)
        GameObject.Destroy(egg);
    }

    IEnumerator EggDrop()
    {
        Instantiate(eggPrefab, new Vector3(xPos, 400, zPos), Quaternion.identity); // instantiate first egg (closer)
        while (true)
        {
            xPos = Random.Range(minXPos, maxXPos);
            zPos = Random.Range(minZPos, maxZPos);
            Instantiate(eggPrefab, new Vector3(xPos, 600, zPos), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }

}
