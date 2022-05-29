using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    double firstEntry; //toplama ��karma �arpma ve b�lmede ilk yaz�lan say�
    double result = 0.0;
    string operation = "";  //yapt���m�z i�lemin sembol�
    double wantedResult;  //bulunmas�n� istedi�imiz sonu�
    static Text calculatorScreen; //i�lemi ve sonucu yazaca��m�z yer
    int number;

    // Start is called before the first frame update
    void Start()
    {
        calculatorScreen = GetComponent<Text>();
        calculatorScreen.text = "Sonucu "+ wantedResult+" olan bir i�lem yap!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Number1()
    {
        addDigit(1);
        //yazd���m�z say�ya basamak ekliyoruz
        calculatorScreen.text = result.ToString();
        //yaz�lan say�y� ekranda g�steriyoruz
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
        //yeni basamak eklerken say�y� onla �arp�p bas�lan tu�taki rakam ekleniyor

    }
    public void addition()
    {
        if (operation.Equals("")) //ba�ka i�lem yap�lmad�ysa bu tu� �al���r
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

    public void takeRoot() //k�k alma
    {
        if (operation.Equals(""))
        {
        operation = "^1/2";
        calculatorScreen.text = operation;
        }
        
    }
    //hesap makinesindeki her tu�a bast���m�zda bu fonksiyonlar �al��abilir

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
    //e�ittir tu�una bas�nca bu �al��abilir. E�ittir yazd���m�z i�lemin sonucunu bulan tu�.


    //submit tu�una bas�nca �al��abilir. Submit buldu�umuz sonucu istenen sonu�la kar��la�t�ran buton.
    public void writeInfo(double result)  //i�lem tamamland���nda ekranda bilgilendirme yaz�s� yazabilir
    {
        if(wantedResult == result)
        {
            calculatorScreen.text = "��lemin do�ru!";
            result = 0.0;
        }
        else
        {
            calculatorScreen.text = "Tekrar dene!";
            result = 0.0;
        }
    }
    
}
