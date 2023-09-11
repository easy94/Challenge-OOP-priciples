using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class ThreeDeeShape : Shape
{

    // Start is called before the first frame update
    void Start()
    {
        m_name = "Cube";                                //inheritance example
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale =new(m_size, m_size, m_size);
    }
   protected override void printName()                            //polymorpism
    {
        print("I'm a" + m_name);
    }

}
