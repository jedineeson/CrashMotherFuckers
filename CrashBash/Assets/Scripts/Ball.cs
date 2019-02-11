using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float m_MoveSpeed = 0.01f;

    private Vector3 m_Dir = new Vector3();
 

    private void Start()
    {
        m_Dir = transform.forward;
    }


    private void Update()
    {
        transform.position = m_Dir * m_MoveSpeed;
    }

    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
