using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameObject m_Wall;

    private int m_Score = 3;

    private PlayerController m_Controller;
    public PlayerController Controller
    {
        set { m_Controller = value; }
    }

    private TextMeshProUGUI m_ScoreUI;
    public TextMeshProUGUI ScoreUI
    {
        set { m_ScoreUI = value; }
    }

    private void Start()
    {
        m_Wall.SetActive(false);
    }

    private void OnTriggerEnter(Collider aOther)
    {
        if(aOther.gameObject.GetComponent<Ball>())
        {
            aOther.gameObject.GetComponent<Ball>().SelfDestruct();
            m_Score--;
            UpdateUI();
            if (m_Score <= 0)
            {
                Destroy(m_Controller.gameObject);
                m_Wall.SetActive(true);
            }
        }
    }

    public void UpdateUI()
    {
        m_ScoreUI.text = m_Score.ToString();
    }

    private void Update()
    {
        Debug.Log(m_Controller.Index + " : " + m_Score);
    }
}
