using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyParticula : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        Invoke(nameof(DeleteObject), 1.5f);
    }
    

    void DeleteObject() {
        Destroy(gameObject);
    }
}
