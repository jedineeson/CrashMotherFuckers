using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float m_MoveSpeed = 1;

 

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
