using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/BarrelDistorsion")]
public class BarrelDistortion //: PostEffectsBase
{
    public float strengthX = 0.05f;
    public float strengthY = 0.05f;
    public Shader BarrelDistortionShader;
    private Material BarrelDistortionMaterial;
    /*
    public override bool CheckResources()
    {
        CheckSupport(false);
        BarrelDistortionMaterial = CheckShaderAndCreateMaterial(BarrelDistortionShader, BarrelDistortionMaterial);

        if (!isSupported)
            ReportAutoDisable();
        return isSupported;
    }*/

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        return;

        /*if (CheckResources() == false)
        {
            Graphics.Blit(source, destination);
            return;
        }
        */
        BarrelDistortionMaterial.SetFloat("k", strengthX);
        BarrelDistortionMaterial.SetFloat("kcube", strengthY);
        Graphics.Blit(source, destination, BarrelDistortionMaterial); 	
    }
}
