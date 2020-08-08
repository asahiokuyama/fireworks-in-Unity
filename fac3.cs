using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fac3 : MonoBehaviour
{
    public GameObject fire3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void spawn3()
    {
        Instantiate(fire3, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
