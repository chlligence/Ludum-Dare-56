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
    public GameObject WinPanel;
    public GameObject FailPanel;

    [Header("GameData")]
    public GameObject image_grid;
    public int mouseCount;
    public int level;

    //private
    bool isWin = false;

    void Start() {
        if (Instance == null)Instance = this;
        UpdateMouseCount();
    }
  
   
    public void UpdateMouseCount() {
        if (MouseGrid.transform.childCount > 1) RemoveAllChildren(MouseGrid);
        for(int i = 0; i < mouseCount; i++) {
            GameObject go = Instantiate(image_grid, MouseGrid.transform);
        }
    }
    public void fail() {
        isWin = false;
        GameOver();
    }

    public void Win() {
        isWin = true;
        GameOver();
    }
    private void GameOver() {
        if (isWin) {
            WinPanel.SetActive(true);
        }
        else {
            FailPanel.SetActive(true);
        }
    }
    public static void RemoveAllChildren(GameObject parent) {
        Transform transform;
        for (int i = 0; i < parent.transform.childCount; i++) {
            transform = parent.transform.GetChild(i);
            GameObject.Destroy(transform.gameObject);
        }
    }
    public void nextLevel() {
        //Debug.Log("levelRead");
        SceneManager.LoadScene("l_"+(level+1));
    }
    public void Reset() {
        SceneManager.LoadScene("l_1");
    }
}
