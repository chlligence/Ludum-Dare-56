using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public GameObject Mouse;
    Collider2D birth_collider;
    private void Start() {
        birth_collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider == birth_collider) {

                CreateMouse();
                GameManager.Instance.mouseCount--;
                GameManager.Instance.UpdateMouseCount();
            }
        }
    }

    void CreateMouse() {
        if(GameManager.Instance.mouseCount > 0) Instantiate(Mouse,transform);
    }
}
