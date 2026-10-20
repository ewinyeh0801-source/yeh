using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caculator : MonoBehaviour
{
    public InputField A;//舊版內建的InputField
    public InputField B;//舊版內建的InputField
    public InputField R;//舊版內建的InputField


    public void doAdd()
    {
        string inputTextA = A.text;
        string inputTextB = B.text;
        //使用TryParse進行安全轉換
        if(int.TryParse(inputTextA,out int resultA))
        {
            Debug.Log($"成功轉換:{resultA}");
        }
        else
        {
            Debug.LogError("請輸入正確的數字格式");
        }
        if(int.TryParse(inputTextB,out int resultB))
         {
            Debug.Log($"成功轉換:{resultB}");
        }
        else
        {
            Debug.LogError("請輸入正確的數字格式");
        }
        Debug.Log(resultA+resultB);
        int intR = resultA + resultB;
        R.text = intR.ToString();

    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
