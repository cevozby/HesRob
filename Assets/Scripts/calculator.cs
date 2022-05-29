using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    double firstEntry; //toplama çýkarma çarpma ve bölmede ilk yazýlan sayý
    double result = 0.0;
    string operation = "";  //yaptýðýmýz iþlemin sembolü
    double wantedResult;  //bulunmasýný istediðimiz sonuç
    static Text calculatorScreen; //iþlemi ve sonucu yazacaðýmýz yer
    int number;

    // Start is called before the first frame update
    void Start()
    {
        calculatorScreen = GetComponent<Text>();
        calculatorScreen.text = "Sonucu "+ wantedResult+" olan bir iþlem yap!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Number1()
    {
        addDigit(1);
        //yazdýðýmýz sayýya basamak ekliyoruz
        calculatorScreen.text = result.ToString();
        //yazýlan sayýyý ekranda gösteriyoruz
    }

    public void Number2()
    {
        addDigit(2);
        calculatorScreen.text = result.ToString();
    }
    public void Number3()
    {
        addDigit(3);
        calculatorScreen.text = result.ToString();
    }
    public void Number4()
    {
        addDigit(4);
        calculatorScreen.text = result.ToString();
    }
    public void Number5()
    {
        addDigit(5);
        calculatorScreen.text = result.ToString();
    }
    public void Number6()
    {
        addDigit(6);
        calculatorScreen.text = result.ToString();
    }
    public void Number7()
    {
        addDigit(7);
        calculatorScreen.text = result.ToString();
    }
    public void Number8()
    {
        addDigit(8);
        calculatorScreen.text = result.ToString();
    }
    public void Number9()
    {
        addDigit(9);
        calculatorScreen.text = result.ToString();

    }
    public void Number0()
    {
        addDigit(0);
        calculatorScreen.text = result.ToString();

    }


    public void addDigit(int a)
    {
        result *= 10;
        result += a;
        //yeni basamak eklerken sayýyý onla çarpýp basýlan tuþtaki rakam ekleniyor

    }
    public void addition()
    {
        if (operation.Equals("")) //baþka iþlem yapýlmadýysa bu tuþ çalýþýr
        {
        firstEntry = result;
        result = 0;
        operation = "+";
        calculatorScreen.text = operation;
        }
        
    }

    public void subtraction()
    {
        if (operation.Equals(""))
        {
        firstEntry = result;
        result = 0;
        operation = "-";
        calculatorScreen.text = operation;
        }
        
    }

    public void division()
    {
        if (operation.Equals(""))
        {
        firstEntry = result;
        result = 0;
        operation = "/";
        calculatorScreen.text = operation;
        }
        
    }

    public void multiplication()
    {
        if (operation.Equals(""))
        {
        firstEntry = result;
        result = 0;
        operation = "*";
        calculatorScreen.text = operation;
        }
        
    }

    public void takeRoot() //kök alma
    {
        if (operation.Equals(""))
        {
        operation = "^1/2";
        calculatorScreen.text = operation;
        }
        
    }
    //hesap makinesindeki her tuþa bastýðýmýzda bu fonksiyonlar çalýþabilir

    public void doTheOperation()
    {
        switch (operation)
        {
            case "+":
                result = firstEntry + result;
                
                break;
            case"-":
                result = firstEntry - result;
                
                break;
            case "*":
                result = firstEntry * result;
                
                break;
            case "/":
                result = firstEntry / result;
                
                break;
            case "^1/2":
                result = Math.Sqrt(result);
                
                break;
        }

        operation = "";
       
    }
    //eþittir tuþuna basýnca bu çalýþabilir. Eþittir yazdýðýmýz iþlemin sonucunu bulan tuþ.


    //submit tuþuna basýnca çalýþabilir. Submit bulduðumuz sonucu istenen sonuçla karþýlaþtýran buton.
    public void writeInfo(double result)  //iþlem tamamlandýðýnda ekranda bilgilendirme yazýsý yazabilir
    {
        if(wantedResult == result)
        {
            calculatorScreen.text = "Ýþlemin doðru!";
            result = 0.0;
        }
        else
        {
            calculatorScreen.text = "Tekrar dene!";
            result = 0.0;
        }
    }
    
}
