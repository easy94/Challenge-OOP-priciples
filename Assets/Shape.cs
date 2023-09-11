using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;
using UnityEditor.Experimental.GraphView;

public class Shape : MonoBehaviour
{
    public Button button;
    public Camera GameCamera;

   private Shape m_Selected;

    protected float m_size = 1;
    public float size
    {
        get { return m_size; }
        set
        {
            if (m_size >= 1f && m_size <= 5f)
            {
                m_size = value;
            }
            else print("size too small or too big");
        }
    }


    protected string m_name;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                m_Selected = hit.collider.GetComponent<Shape>();
            }

        }

    }



    protected virtual void printName()
    {

    }

    public void OnButtonClick() {
        m_Selected.size += 1f;
    }

    private void OnMouseDown()
    {
        changeButtonText();
        printName();
    }

    void changeButtonText()
    {
        button.GetComponentInChildren <Text>().text = "Selected: " + name;
    }
}
