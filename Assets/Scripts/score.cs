using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scores;
    public float value;
    public float lives;
    public static score instance { get; set; }
    public GameObject panel;

    // Update is called once per frame
    private void Awake()
    {
        instance = this;
        panel.SetActive(false);
    }
    void Update()
    {
        
    }
    public void addScore()
    {
        value++;
        scores.text = value.ToString();
    }

    public void life()
    {
        lives++;
        if (lives == 5)
        {
            panel.SetActive(true);
            StopAllCoroutines();
        }
    }



}
