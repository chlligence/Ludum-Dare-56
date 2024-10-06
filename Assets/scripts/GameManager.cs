using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance;

    public GameObject cat;
    [Header("UI")]
    public GameObject MouseGrid;

    [Header("GameData")]
    public static int mouseCount;
    public int level;
    public GameObject[] birthPoints = new GameObject[mouseCount];
    public Collider2D[] birth_colliders = new Collider2D[mouseCount];
    public GameObject mouse;
    public GameObject image_grid;


    //private
    bool isWin = false;

    void Start() {
        if (Instance == null)Instance = this;
        for(int i = 0; i < birthPoints.Length; i++) birth_colliders[i] = birthPoints[i].GetComponent<Collider2D>();
        UpdateMouseCount();
    }
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            for(int i = 0;i < birth_colliders.Length; i++)
            if(hit.collider == birth_colliders[i]) {
                Debug.Log("Success");

                mouseCount--;
                UpdateMouseCount();
            }
        }
    }
   
    private void UpdateMouseCount() {
        int length = mouseCount;
        for(int i = 0; i < length; i++) {
            GameObject go = Instantiate(image_grid, MouseGrid.transform);
        }
    }

    public void Win() {
        isWin = true;
        GameOver();
    }

    private void GameOver() {
        if (isWin) {
            SceneManager.LoadScene("l_" + (++level));
        }else {

        }
    }

}
