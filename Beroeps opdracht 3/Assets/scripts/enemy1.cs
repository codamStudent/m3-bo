using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{

    [SerializeField] Transform punt1;
    [SerializeField] Transform punt2;
    [SerializeField] Transform punt3;
    [SerializeField] Transform punt4;
    [SerializeField] Transform punt5;
    [SerializeField] Transform punt6;
    [SerializeField] Transform punt7;
    [SerializeField] Transform punt8;
    [SerializeField] Transform punt9;
    [SerializeField] Transform punt10;
    private Transform Baksteen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Baksteen.position += Baksteen.position - punt1.position;
    }
}
