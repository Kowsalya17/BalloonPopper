using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float point;
    public static spawn instance { get; set; }


    void Start()
    {
        //Instantiate(spawnPrefab,transform.position, Quaternion.identity);
        StartCoroutine(spawnbaloon());
        instance = this;
            }

    void Update()
    {

    }

    IEnumerator spawnbaloon()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(spawnPrefab, new Vector3((Random.Range(-10f, 10f)),transform.position.y, 0), Quaternion.identity);
        StartCoroutine(spawnbaloon());
    }
    public void Restart()
    {
        SceneManager.LoadScene("BalloonPopper");
    }
}

  
