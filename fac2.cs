using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fac2 : MonoBehaviour
{
    public GameObject fire2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void spawn2()
    {
        Instantiate(fire2, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
