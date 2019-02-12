using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform m_MinPos;
    private Transform m_MaxPos;

    [SerializeField]
    private float m_MoveSpeed;

    private int m_Index;
    public int Index
    {
        get { return m_Index; } // Pour DEBUG
    }

    private float m_PositionFloat = 0.5f;

    private void Update()
    {
        Move();

        transform.position = Vector3.Lerp(m_MinPos.position, m_MaxPos.position, m_PositionFloat);
    }

    private void Move()
    {
        m_PositionFloat += (m_MoveSpeed * Time.deltaTime) * Input.GetAxis("DirectionP" + m_Index);

        m_PositionFloat = Mathf.Clamp(m_PositionFloat, 0f, 1f);
    }

    public void SetController(Transform minPos, Transform maxPos, int index)
    {
        m_MinPos = minPos;
        m_MaxPos = maxPos;
        m_Index = index;
    }
}
