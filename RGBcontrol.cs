using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBcontrol : MonoBehaviour
{
    public bool Pause = false;
    public Material TargetMaterial;
    public float ChangingSpeed = 1.0f;

    private float RedValue = 1.0f;
    private float GreenValue = 0.0f;
    private float BlueValue = 0.0f;

    void Update()
    {
        //���ڽ�RGB������0-1���䣬��ֹfloat�Ӽ�������
        if(RedValue > 1.0f)
        {
            RedValue = 1.0f;
        }
        if (RedValue < 0.0f)
        {
            RedValue = 0.0f;
        }
        if (GreenValue > 1.0f)
        {
            GreenValue = 1.0f;
        }
        if (GreenValue < 0.0f)
        {
            GreenValue = 0.0f;
        }
        if (BlueValue > 1.0f)
        {
            BlueValue = 1.0f;
        }
        if (BlueValue < 0.0f)
        {
            BlueValue = 0.0f;
        }
        //-------�ֽ���-------

        //RGB�任���任��ʽ�ο�����ɫ����Ϊ����ɫȻ��˳ʱ����ɫ��ת��
        if (Pause == false)
        {
            TargetMaterial.SetColor("_RimLightColor", new Color(RedValue, GreenValue, BlueValue, 1));
            if (RedValue == 1.0f && BlueValue == 0.0f && GreenValue < 1.0f)
            {
                GreenValue += 0.01f * ChangingSpeed;
            }
            if (GreenValue == 1.0f && RedValue > 0.0f)
            {
                RedValue -= 0.01f * ChangingSpeed;
            }
            if (GreenValue == 1.0f && RedValue == 0.0f && BlueValue < 1.0f)
            {
                BlueValue += 0.01f * ChangingSpeed;
            }
            if (BlueValue == 1.0f && GreenValue > 0.0f)
            {
                GreenValue -= 0.01f * ChangingSpeed;
            }
            if (BlueValue == 1.0f && GreenValue == 0.0f && RedValue < 1.0f)
            {
                RedValue += 0.01f * ChangingSpeed;
            }
            if (RedValue == 1.0f && BlueValue > 0.0f)
            {
                BlueValue -= 0.01f * ChangingSpeed;
            }
        }
    }
}
