using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class script : MonoBehaviour
{
    public MeshRenderer rend;
    public Color[] colors;
    public float delayActivation, repeatActivation;
    private void Awake()
    {
        rend = GetComponent<MeshRenderer>();
    }
    
    //will run this function when we Enable the GO
    private void OnEnable()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            rend.material.color = colors[Random.Range(0, colors.Length)];
        }
    }

    //will run this function when we Enable the GO
    private void OnDisable()
    {
        
    }

    public void ColorChanger()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            rend.material.color = colors[Random.Range(0, colors.Length)];
        }
    }

    public void CubeSizeChanger()
    {
        transform.localScale = new Vector3(Random.Range(1,10), Random.Range(1, 10), Random.Range(1, 10));
    }

    private void OnMouseDown()
    {
        //Invoke("ColorChanger", delayActivation);
        InvokeRepeating("CubeSizeChanger", delayActivation, repeatActivation);
    }

    private void OnMouseUp()
    {
        //for (int i = 0; i < colors.Length; i++)
        //{
        //    rend.material.color = colors[Random.Range(0, colors.Length)];
        //}
    }

    private void OnMouseDrag()
    {
        //for (int i = 0; i < colors.Length; i++)
        //{
        //    rend.material.color = colors[Random.Range(0, colors.Length)];
        //}
    }

    private void OnMouseEnter()
    {
        //for (int i = 0; i < colors.Length; i++)
        //{
        //    rend.material.color = colors[Random.Range(0, colors.Length)];
        //}
    }

    private void OnMouseExit()
    {
        //for (int i = 0; i < colors.Length; i++)
        //{
        //    rend.material.color = colors[Random.Range(0, colors.Length)];
        //}
    }

    private void OnMouseOver()
    {
        //for (int i = 0; i < colors.Length; i++)
        //{
        //    rend.material.color = colors[Random.Range(0, colors.Length)];
        //}
    }
}
