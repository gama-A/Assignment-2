using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material newMaterial;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material = newMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
