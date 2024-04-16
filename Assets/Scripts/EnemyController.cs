using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.InputSystem.iOS;

public class EnemyController : MonoBehaviour
{
    //private ScoreCounter m_scoreConter;
    [SerializeField] private EnemyData m_data;
    [SerializeField] private int m_maxHealth = 5;
    [SerializeField] private Image m_healthBar;

    int m_health;

    void Start()
    {
        m_health = m_data.Health;
        //m_scoreConter = FindObjectOfType<ScoreCounter>();
    }

}
