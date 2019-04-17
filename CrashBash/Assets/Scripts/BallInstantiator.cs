using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInstantiator : MonoBehaviour
{
    [SerializeField]
    private GameObject m_Ball;
    [SerializeField]
    private float m_Cooldown = 3.0f;

    private float m_Timer = 0.0f;

    private Color m_NormalColor;
    [SerializeField]
    private Color m_SignalColor;

    [SerializeField]
    private List<Transform> m_SpawnPoints = new List<Transform>();
    [SerializeField]
    private List<GameObject> m_BallSpawners = new List<GameObject>();

    private int m_RandIndex = 0;
    private bool m_SignalSent = false;

    private void Start()
    {
        m_NormalColor = m_BallSpawners[0].GetComponent<Renderer>().material.color;
        m_SignalColor = Color.black;
    }

    private void Update()
    {
        m_Timer += Time.deltaTime;

        if (m_Timer > m_Cooldown / 2)
        {
            if (!m_SignalSent)
            {
                SignalBallSpawner();
            }

            if (m_Timer > m_Cooldown)
            {
                GameObject Ball = Instantiate(m_Ball, m_SpawnPoints[m_RandIndex].position, Quaternion.identity);
                Ball.GetComponent<Ball>().SetDir(m_SpawnPoints[m_RandIndex].forward);
                m_BallSpawners[m_RandIndex].GetComponent<Renderer>().material.color = m_NormalColor;

                ResetTimer();
            }
        }
    }

    private void SignalBallSpawner()
    {
        m_SignalSent = true;
        m_RandIndex = Random.Range(0, 3);
        m_BallSpawners[m_RandIndex].GetComponent<Renderer>().material.color = m_SignalColor;
    }

    private void ResetTimer()
    {
        m_Timer = 0.0f;
        m_SignalSent = false;
    }
}
