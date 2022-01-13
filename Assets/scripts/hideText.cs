using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideText : MonoBehaviour
{

    public float secondDestroy = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, secondDestroy);
    }

    
}
