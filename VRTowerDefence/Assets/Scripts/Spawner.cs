using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] hazards;
    public Vector3 spawnValues;

    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    private bool gameOver;

    void Start ()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];

                Vector3 spawnPosition = new Vector3(transform.position.x + Random.Range(-spawnValues.x, spawnValues.x), transform.position.y + Random.Range(-spawnValues.y, spawnValues.y), transform.position.z + Random.Range(-spawnValues.z, spawnValues.z) );
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                break;
            }
        }
    }
    public void GameOver()
    {
        gameOver = true;
    }

}
