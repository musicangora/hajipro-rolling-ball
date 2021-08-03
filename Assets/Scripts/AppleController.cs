using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{
    public GameObject particleObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag=="Ball")
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
