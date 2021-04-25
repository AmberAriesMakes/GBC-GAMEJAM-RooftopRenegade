using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PtoPause : MonoBehaviour
{
    public float mintime = 0.05f;
    public float maxtime = 1.2f;

    private float timer;
    private Text textflicker;

    void Start()
    {
        textflicker = GetComponent<Text>();
        timer = Random.Range(mintime, maxtime);

    }

    void Update()
    {
        timer -= Time.deltaTime;
            if (timer <=0)
        {
            textflicker.enabled = textflicker.enabled;
                timer = Random.Range(mintime, maxtime);

        }
    }
}
