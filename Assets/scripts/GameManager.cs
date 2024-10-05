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
    public TextMeshPro textMeshPro;

    [Header("GameData")]
    public int mouseCount;
    public int level;

    void Start() {
        if (Instance == null)Instance = this;
    }
    void Update() {

    }
}
