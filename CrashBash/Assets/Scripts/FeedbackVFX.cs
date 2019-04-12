using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackVFX : MonoBehaviour
{
    [SerializeField]
    private float m_Duration;

    private void Update()
    {
        m_Duration -= Time.deltaTime;
        if(m_Duration <= 0)
        {
            Destroy(gameObject);
        }
    }
}
