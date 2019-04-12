using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> m_Prefabs;

    [SerializeField]
    private List<Transform> m_SpawnPos;

    [SerializeField]
    private List<Transform> m_MinPos;
    [SerializeField]
    private List<Transform> m_MaxPos;

    [SerializeField]
    private List<Goal> m_Goals;

    [SerializeField]
    private List<TextMeshProUGUI> m_ScoresUI;

    private void Start()
    {
        PlayerController controller;
        for (int i = 0; i < m_Prefabs.Count; i++)
        {
            controller = Instantiate(m_Prefabs[i], m_SpawnPos[i].position, m_SpawnPos[i].rotation).GetComponent<PlayerController>();
            controller.SetController(m_MinPos[i], m_MaxPos[i], i + 1);
            m_Goals[i].Controller = controller;
            m_Goals[i].ScoreUI = m_ScoresUI[i];
            m_Goals[i].UpdateUI();
        }
    }
}
