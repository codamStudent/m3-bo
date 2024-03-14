using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] private Transform Target;
    void Awake()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        var cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);

        Target = cylinder.transform;
        Target.transform.position = new Vector3(0.0f, 0.0f,0);



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
