using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private PlayerController m_Controller;
    public PlayerController Controller
    {
        get { return m_Controller; }
        set { m_Controller = value; }
    }

    private int m_Scores = 20;
    public int Scores
    { get { return m_Scores; } } //POUR DEBUG

    private void OnTriggerEnter(Collider aOther)
    {
        if(aOther.gameObject.GetComponent<Ball>())
        {
            aOther.gameObject.GetComponent<Ball>().SelfDestruct();
            m_Scores--;
        }
    }
}
