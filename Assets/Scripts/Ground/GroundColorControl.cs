using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorControl : MonoBehaviour
{

    [SerializeField] private Material groundMaterial;
    [SerializeField] private Color[] colors;
    private int colorIndex=0;
    [SerializeField] private float lerpValue;
    [SerializeField] private float time;
    private float currentTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetColorChangeTime();
        SetGroundMaterialSmoothColorChange();
    }

    private void SetColorChangeTime()   // renk de�i�me s�resi
    {
        if (currentTime <= 0)
        {
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()  //mevcut renkler bitince ba�a d�ns�n diye
    {
        colorIndex++;
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void SetGroundMaterialSmoothColorChange() // renk ge�isi
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[colorIndex],lerpValue*Time.deltaTime);
    }

    private void OnDestroy()
    {
        groundMaterial.color = colors[1];
    }

}
