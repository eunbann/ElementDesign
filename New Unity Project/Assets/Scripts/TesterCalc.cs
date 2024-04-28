using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TesterCalc : MonoBehaviour
{
    private int phNum;

    public GameObject glass;
    public ToggleGroup tGroup;
    public ToggleGroup sGroup;

    #region �̹���&�ؽ�Ʈ
    public Text txt1;
    public Text txt2;
    public Text txt3;

    public Sprite wImg;
    public Sprite yImg;
    public Sprite rImg;
    public Sprite oImg;
    public Sprite gImg;
    public Sprite bImg;
    public Sprite nImg;
    #endregion
    #region �þ�&���蹰��
    public Toggle t1;
    public Toggle t2;
    public Toggle t3;
    public Toggle t4;
    public Toggle t5;
    public Toggle t6;

    public Toggle s1;
    public Toggle s2;
    public Toggle s3;
    #endregion

    void Start()
    {
        
    }

    void Update()
    {
        PhInOut();
        Calc();
    }
    
    public void Reset()
    {
        tGroup.SetAllTogglesOff();
        sGroup.SetAllTogglesOff();
        glass.GetComponent<Image>().sprite = wImg;
        txt1.text = "";
        txt2.text = "";
        txt3.text = "";
        phNum = 0;
    }

    void Calc()
    {
        if(t1.isOn)
        {
            phNum = 1;
            txt1.text = "����";
            txt2.text = phNum.ToString();
            if (s1.isOn)
            {
                glass.GetComponent<Image>().sprite = rImg;
            }
            else if (s2.isOn)
            {
                glass.GetComponent<Image>().sprite = nImg;
            }
            else if (s3.isOn)
            {
                glass.GetComponent<Image>().sprite = yImg;
            }
        }
        if (t2.isOn)
        {
            phNum = 2;
            txt1.text = "����";
            txt2.text = phNum.ToString();
            if (s1.isOn)
            {
                glass.GetComponent<Image>().sprite = rImg;
            }
            else if (s2.isOn)
            {
                glass.GetComponent<Image>().sprite = nImg;
            }
            else if (s3.isOn)
            {
                glass.GetComponent<Image>().sprite = yImg;
            }
        }
        if (t3.isOn)
        {
            phNum = 7;
            txt1.text = "������";
            txt2.text = phNum.ToString();
            if (s1.isOn)
            {
                glass.GetComponent<Image>().sprite = oImg;
            }
            else if (s2.isOn)
            {
                glass.GetComponent<Image>().sprite = nImg;
            }
            else if (s3.isOn)
            {
                glass.GetComponent<Image>().sprite = gImg;
            }
        }
        if (t4.isOn)
        {
            phNum = 8;
            txt1.text = "�ٴ幰";
            txt2.text = phNum.ToString();
            if (s1.isOn)
            {
                glass.GetComponent<Image>().sprite = yImg;
            }
            else if (s2.isOn)
            {
                glass.GetComponent<Image>().sprite = rImg;
            }
            else if (s3.isOn)
            {
                glass.GetComponent<Image>().sprite = bImg;
            }
        }
        if (t5.isOn)
        {
            phNum = 10;
            txt1.text = "��";
            txt2.text = phNum.ToString();
            if (s1.isOn)
            {
                glass.GetComponent<Image>().sprite = yImg;
            }
            else if (s2.isOn)
            {
                glass.GetComponent<Image>().sprite = rImg;
            }
            else if (s3.isOn)
            {
                glass.GetComponent<Image>().sprite = bImg;
            }
        }
        if (t6.isOn)
        {
            phNum = 13;
            txt1.text = "ǥ����";
            txt2.text = phNum.ToString();
            if (s1.isOn)
            {
                glass.GetComponent<Image>().sprite = yImg;
            }
            else if (s2.isOn)
            {
                glass.GetComponent<Image>().sprite = rImg;
            }
            else if (s3.isOn)
            {
                glass.GetComponent<Image>().sprite = bImg;
            }
        }
    }

    void PhInOut()
    {
        if(phNum >= 1 && phNum < 7)
        {
            txt3.text = "�꼺";
        }
        else if(phNum == 7)
        {
            txt3.text = "�߼�";
        }
        else if(phNum > 7 && phNum <= 13)
        {
            txt3.text = "���⼺";
        }
        else
        {
            txt3.text = "";
        }
    }
}
