using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < 5; i++)
        {
            float r1 = UnityEngine.Random.Range(-10, 10);
            float r2 = UnityEngine.Random.Range(-10, 10);

            Instantiate(prefab, new Vector3(r1, 0, r2), UnityEngine.Random.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
