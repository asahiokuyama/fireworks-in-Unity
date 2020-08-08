using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fac : MonoBehaviour
{
    public GameObject fire;
    public GameObject fire21;
    public GameObject fire31;
    float time = 0;
    float time2 = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, 5f);
        fire21 = GameObject.Find("fac2");
        fire31 = GameObject.Find("fac3");
    }

    void spawn()
    { 
        Instantiate(fire, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        time2 += Time.deltaTime;

        if (time > 6.0f)
        {
            Debug.Log("df");
            fire21.GetComponent<fac2>().spawn2();
            time = 0;
        }

        if(time2 > 8.0f)
        {
            fire31.GetComponent<fac3>().spawn3();
            time2 = 0;
        }
    }
}
