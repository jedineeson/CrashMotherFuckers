using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Transform m_MinPos;

    [SerializeField]
    private Transform m_MaxPos;

    [SerializeField]
    private float m_MoveSpeed;

    private float m_PositionFloat = 0.5f;

    private void Update()
    {
        GetInput();

        transform.position = Vector3.Lerp(m_MinPos.position, m_MaxPos.position, m_PositionFloat);
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            return;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            m_PositionFloat -= m_MoveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            m_PositionFloat += m_MoveSpeed * Time.deltaTime;
        }
        m_PositionFloat = Mathf.Clamp(m_PositionFloat, 0f, 1f);
    }
}
