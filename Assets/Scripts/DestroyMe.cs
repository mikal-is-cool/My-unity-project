using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{

    public float lifeTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
