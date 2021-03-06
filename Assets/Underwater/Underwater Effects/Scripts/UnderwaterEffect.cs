﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class UnderwaterEffect : MonoBehaviour
{
    public Material material;
    
    [Range(0.001f, 0.1f)]
    public float _PixelOffset = 0.01f;
    [Range(0.1f, 20f)]
    public float _NoiseFrequency = 3f;
    [Range(0.1f, 30f)]
    public float _NoiseSpeed = 1.8f;
    [Range(0.1f, 20f)]

    public float _NoiseScale = 3.1f;
    public float _DepthStart=0f;
    public float _DepthDistance=100f;

    // Update is called once per frame
    void Update()
    {
        // Set variables

        material.SetFloat("_NoiseFrequency", _NoiseFrequency);
        material.SetFloat("_NoiseSpeed", _NoiseSpeed);
        material.SetFloat("_NoiseScale", _NoiseScale);
        material.SetFloat("_PixelOffset", _PixelOffset);
        material.SetFloat("_DepthStart", _DepthStart);
        material.SetFloat("_DepthDistance", _DepthDistance);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }
}
