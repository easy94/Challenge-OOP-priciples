using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    public Button Button;


    protected int m_size;
    protected int size                                          //encapsulation example
    {
        get { return m_size; }
        set
        {
            if (m_size < 1 && m_size > 10) size = m_size;
            else print("size too small or too big");
        }
    }
    protected string m_name;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected virtual void printName()
    {

    }

    private void OnMouseDown()
    {
        if (gameObject.GetComponent<Transform>() != null)                   //abstraction example
        {
            printName();
        }
    }
}
