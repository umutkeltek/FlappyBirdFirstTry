using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public BirdMove BirdScript;
    public GameObject Pipes;
    public float height;
    public float time;

    public void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!BirdScript.isDead)
        {

            Instantiate(Pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
