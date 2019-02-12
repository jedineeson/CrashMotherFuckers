using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private int m_Score = 20;

    private PlayerController m_Controller;
    public PlayerController Controller
    {
        set { m_Controller = value; }
    }

    private void OnTriggerEnter(Collider aOther)
    {
        if(aOther.gameObject.GetComponent<Ball>())
        {
            aOther.gameObject.GetComponent<Ball>().SelfDestruct();
            m_Score--;
            if (m_Score <= 0)
            {
                //
            }
        }
    }

    private void Update()
    {
        Debug.Log(m_Controller.Index + " : " + m_Score);
    }
}
