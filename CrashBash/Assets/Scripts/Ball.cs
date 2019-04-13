﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float m_MoveSpeed = 0.1f;

    [SerializeField]
    private Rigidbody m_RigidBody;

    private Vector3 m_Dir = new Vector3();


    private void Update()
    {
        m_RigidBody.velocity = m_Dir * m_MoveSpeed;
    }

    public void SelfDestruct()
    {
        Destroy(gameObject);
    }

    public void SetDir(Vector3 aDir)
    {
        m_Dir = aDir;
    }

    public Vector3 GetDir()
    {
        return m_Dir;
    }

    private void OnCollisionEnter(Collision aOther)
    {
        // Define new Direction
        if (aOther.gameObject.layer != LayerMask.NameToLayer("Ground") && aOther.gameObject.layer != LayerMask.NameToLayer("LaserWall"))
        {
            m_Dir.x = (gameObject.transform.position.x - aOther.gameObject.transform.position.x);
            m_Dir.z = gameObject.transform.position.z - aOther.gameObject.transform.position.z;
            m_Dir = m_Dir.normalized;
        }
    }
}
