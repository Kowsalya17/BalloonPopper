using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rigid : MonoBehaviour
{
    public float floatStrength = 3f;
    public float lives;
    public static rigid rb { get; set; }


    void Start()
    {
        rb = this;    
}

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * floatStrength);
       
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Destroy(this.gameObject);
        //}

        //if (transform.position.y >= 7f)
        //{
        //    Destroy(gameObject);
        //}
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube top")
        {
            score.instance.life();
            Destroy(this.gameObject);
        }
    }
    public void OnMouseDown()
    {
        score.instance.addScore();
        Destroy(gameObject);
    }
     
}
