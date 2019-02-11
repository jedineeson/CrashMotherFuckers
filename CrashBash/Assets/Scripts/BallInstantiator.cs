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

    [SerializeField]
    private List<Transform> m_SpawnPoints = new List<Transform>();

    private int m_RandIndex = 0;

    void Update()
    {
        m_Timer += Time.deltaTime;

        if(m_Timer > m_Cooldown)
        {
            m_RandIndex = Random.Range(0, 3);
            GameObject Ball = Instantiate(m_Ball, m_SpawnPoints[m_RandIndex].position, Quaternion.identity);
            Ball.GetComponent<Ball>().SetDir(m_SpawnPoints[m_RandIndex].forward);

            m_Timer = 0.0f;            
        }        
    }
}
