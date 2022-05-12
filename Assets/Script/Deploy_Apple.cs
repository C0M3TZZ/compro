using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploy_Apple : MonoBehaviour
{
    public GameObject Apple;
    public GameObject Durian;
    public float respawnTime = 1.0f;
    public float spawnBompTime = 5;
    private Vector2 screenBounds;

    private float xMin = -12.20f;
    private float xMax = 12.10f;
    private float yMin = 12f;
    private float yMax = 15f;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(AppleWave());
    }
    private void Update() {
        spawnBompTime -= Time.deltaTime;
        Debug.Log(spawnBompTime);
    }

    // Update is called once per frame
    private void spawnApple(){
        GameObject a = Instantiate(Apple) as GameObject;
        a.transform.position = new Vector2(Random.Range (xMin, xMax), Random.Range (yMin, yMax));
    }
    private void spawnDurian()
    {
        GameObject a = Instantiate(Durian) as GameObject;
        a.transform.position = new Vector2(Random.Range (xMin, xMax), Random.Range (yMin, yMax));
    }
    IEnumerator AppleWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            if (spawnBompTime <= 0)
            {
                yield return new WaitForSeconds(respawnTime);
                spawnDurian();
            }
            spawnApple();
        }
    }
    
}
