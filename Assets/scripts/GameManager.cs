using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> mice;
    public GameObject cat;
    [Header("UI")]
    public GameObject MouseGrid;

    [Header("GameData")]
    public int mouseCount;
    public int level;

    void Start() {
        if (Instance == null)Instance = this;
    }
    void Update() {

    }
    private void initMouse() {
        for (int i = 0; i < mouseCount; i++) {
            mice.Add(new GameObject());
        }
    }
    private void UpdateUI() {

    }
}
