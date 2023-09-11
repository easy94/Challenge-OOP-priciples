using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDeeShape : Shape
{

    // Start is called before the first frame update
    void Start()
    {
        m_name = "plane";
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new(m_size, m_size, m_size);
    }
    protected override void printName()
    {
        print("I'm a" + m_name);
    }

}
