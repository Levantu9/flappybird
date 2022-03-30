using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float countdown;
    public float timeDuration;

    // Start is called before the first frame update
    void Start()
    {
        countdown = timeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Instantiate(pipe,new Vector3(1.0f,Random.RandomRange(-0.4f,0.4f),0),Quaternion.identity);
            countdown = timeDuration;

        }
    }
}
