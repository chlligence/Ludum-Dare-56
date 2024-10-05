using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance;

    public GameObject cat;
    [Header("UI")]
    public GameObject MouseGrid;

    [Header("GameData")]
    public GameObject birth;
    private Collider2D birth_collider;

    public GameObject image_grid;
    public int mouseCount;
    public int level;

    void Start() {
        if (Instance == null)Instance = this;
        birth_collider = birth.GetComponent<Collider2D>();
        UpdateMouseCount();
    }
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit.collider == birth_collider) {
                Debug.Log("Success");
                mouseCount--;

            }
        }
    }
   
    private void UpdateMouseCount() {
        int length = mouseCount;
        for(int i = 0; i < length; i++) {
            GameObject go = Instantiate(image_grid, MouseGrid.transform);
        }
    }

    private void UpdateUI() {

    }
}
