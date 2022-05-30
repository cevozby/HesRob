using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//iþlem önceliðine göre çalýþan bir hesap makinesi. Her tuþa bastýðýnda tuþta yazaný ekranda gösteriyor.
public class calculator2 : MonoBehaviour
{


    double firstEntry=0; //toplama çýkarma çarpma ve bölmede ilk yazýlan sayý
    double secondEntry=0;
    double thirdEntry=0;
    string firstOperation = "";
    string secondOperation = "";
    string thirdOperation = "";
    int enteredNumber = 1;
    double wantedResult;  //bulunmasýný istediðimiz sonuç
    Text calculatorScreen; //iþlemi ve sonucu yazacaðýmýz yer
    Boolean written = false; //first second veya third entry için rakam girilmiþse written true olacak
                             // + - * / ya basýnca tekrar sayý giriþi olmasý gerektiði için false a dönecek
    Boolean screenText = true;

    // Start is called before the first frame update
    void Start()
    {
        calculatorScreen = GetComponent<Text>();
        calculatorScreen.text = "Sonucu " + wantedResult + " olan bir iþlem yap!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //rakam tuþlarý
    public void Number1()
    {
        addDigit(1);
        //yazdýðýmýz sayýya basamak ekliyoruz
        calculatorScreen.text += "1";
        //yazýlan sayýyý ekranda gösteriyoruz
        
    }

    public void Number2()
    {
        addDigit(2);
        calculatorScreen.text += "2";
        
    }
    public void Number3()
    {
        addDigit(3);
        calculatorScreen.text += "3";
        
    }
    public void Number4()
    {
        addDigit(4);
        calculatorScreen.text += "4";
        
    }
    public void Number5()
    {
        addDigit(5);
        calculatorScreen.text += "5";
        
    }
    public void Number6()
    {
        addDigit(6);
        calculatorScreen.text += "6";
        
    }
    public void Number7()
    {
        addDigit(7);
        calculatorScreen.text += "7";
        
    }
    public void Number8()
    {
        addDigit(8);
        calculatorScreen.text += "8";
        
    }
    public void Number9()
    {
        addDigit(9);
        calculatorScreen.text += "9";
       

    }
    public void Number0()
    {
        addDigit(0);
        calculatorScreen.text += "0";
        

    }

    //rakam tuþlarýnýn kullandýðý bir fonksiyon
    public void addDigit(int a)
    {
        written = true;

        if(enteredNumber == 1)
        {
            if(screenText)
            {
                calculatorScreen.text = "";
                screenText = false;
            }  
            firstEntry *= 10;
            firstEntry += a;
        }
        if (enteredNumber == 2)
        {
            secondEntry *= 10;
            secondEntry += a;
        }
        if (enteredNumber == 3)
        {
            thirdEntry *= 10;
            thirdEntry += a;
        }

        //yeni basamak eklerken sayýyý onla çarpýp basýlan tuþtaki rakam ekleniyor

    }

    //artý tuþu
    public void addition()
    {
        if (written == true)
        {
            written = false;
            if (enteredNumber == 1)
            {
                firstOperation = "+";
                enteredNumber = 2;
                calculatorScreen.text += firstOperation;
            }

            if (enteredNumber == 2)
            {
                secondOperation = "+";
                enteredNumber = 3;
                calculatorScreen.text += secondOperation;

            }
            if (enteredNumber == 3)
            {
                thirdOperation = "+";
                calculatorScreen.text += thirdOperation;

            }
        }


    }

    //eksi tuþu
    public void subtraction()
    {
        if (written == true)
        {
            written = false;
            if (enteredNumber == 1)
            {
                    firstOperation = "-";
                    enteredNumber = 2;
                    calculatorScreen.text += firstOperation;
            }

            if (enteredNumber == 2)
            {
                    secondOperation = "-";
                    enteredNumber = 3;
                    calculatorScreen.text += secondOperation;
                
            }
            if (enteredNumber == 3)
            {
                    thirdOperation = "-";
                    calculatorScreen.text += thirdOperation;
                
                    doTheMath();
                
            }
        }
      
    }

    //iþlem tuþlarýnýn kullandýðý bir fonksiyon
    public void doTheMath()
    {
        
        if (firstOperation.Equals("+"))
        {
            switch (secondOperation)
            {
                case "+":
                    firstEntry += secondEntry;
                    secondEntry = thirdEntry;
                    thirdEntry = 0;
                    firstOperation = secondOperation;
                    secondOperation = thirdOperation;
                    written = false;
                    break;
                case "-":
                    firstEntry += secondEntry;
                    secondEntry = thirdEntry;
                    thirdEntry = 0;
                    firstOperation = secondOperation;
                    secondOperation = thirdOperation;
                    written = false;
                    break;
                case "*":
                    secondEntry *= thirdEntry;
                    secondOperation = thirdOperation;
                    thirdEntry = 0;
                    written = false;
                   break;
                case "/":
                    secondEntry /= thirdEntry;
                    secondOperation = thirdOperation;
                    thirdEntry = 0;
                    written = false;
                    break;
                
            }


        }

        if (firstOperation.Equals("-"))
        {
            switch (secondOperation)
            {
                case "+":
                    firstEntry -= secondEntry;
                    secondEntry = thirdEntry;
                    thirdEntry = 0;
                    firstOperation = secondOperation;
                    secondOperation = thirdOperation;
                    written = false;
                    break;
                case "-":
                    firstEntry -= secondEntry;
                    secondEntry = thirdEntry;
                    thirdEntry = 0;
                    firstOperation = secondOperation;
                    secondOperation = thirdOperation;
                    written = false;
                    break;
                case "*":
                    secondEntry *= thirdEntry;
                    secondOperation = thirdOperation;
                    thirdEntry = 0;
                    written = false;
                    break;
                case "/":
                    secondEntry /= thirdEntry;
                    secondOperation = thirdOperation;
                    thirdEntry = 0;
                    written = false;
                    break;
                
            }

        }

        if (firstOperation.Equals("/"))
        {
            firstEntry /= secondEntry;
            secondEntry = thirdEntry;
            thirdEntry = 0;
            firstOperation = secondOperation;
            secondOperation = thirdOperation;
            written = false;

        }

        if (firstOperation.Equals("*"))
        {
            firstEntry *= secondEntry;
            secondEntry = thirdEntry;
            thirdEntry = 0;
            firstOperation = secondOperation;
            secondOperation = thirdOperation;
            written = false;

        }



    }

    // bölü tuþu
    public void division()
    {
        if (written == true)
        {
            written = false;
            if (enteredNumber == 1)
            {
                firstOperation = "/";
                enteredNumber = 2;
                calculatorScreen.text += firstOperation;
            }

            if (enteredNumber == 2)
            {
                secondOperation = "/";
                enteredNumber = 3;
                calculatorScreen.text += secondOperation;

            }
            if (enteredNumber == 3)
            {
                thirdOperation = "/";
                calculatorScreen.text += thirdOperation;
                doTheMath();

            }
        }

    }

    //çarpma tuþu
    public void multiplication()
    {
        if (written == true)
        {
            written = false;
            if (enteredNumber == 1)
            {
                firstOperation = "*";
                enteredNumber = 2;
                calculatorScreen.text += firstOperation;
            }

            if (enteredNumber == 2)
            {
                secondOperation = "*";
                enteredNumber = 3;
                calculatorScreen.text += secondOperation;

            }
            if (enteredNumber == 3)
            {
                thirdOperation = "*";
                calculatorScreen.text += thirdOperation;
                doTheMath();

            }
        }

    }

    //hesap makinesindeki her tuþa bastýðýmýzda bu fonksiyonlar çalýþabilir

    //eþittir tuþuna basýnca bu çalýþabilir. Eþittir yazdýðýmýz iþlemin sonucunu bulan tuþ.
    public void doTheOperation()
    {
        if(written == true)
        {
            if (firstOperation.Equals(""))
            {
                 
            }
            else if (secondOperation.Equals(""))
            {
                switch (firstOperation)
                {
                    case "+":
                        firstEntry += secondEntry;
                        break;
                    case "-":
                        firstEntry -= secondEntry;
                        break;
                    case "*":
                        firstEntry *= secondEntry;
                        break;
                    case "/":
                        firstEntry /= secondEntry;
                        break;

                }
            }
            else
            {
                doTheMath();
                switch (firstOperation)
                {
                    case "+":
                        firstEntry += secondEntry;
                        break;
                    case "-":
                        firstEntry -= secondEntry;
                        break;
                    case "*":
                        firstEntry *= secondEntry;
                        break;
                    case "/":
                        firstEntry /= secondEntry;
                        break;

                }

            }


            if (wantedResult.Equals(firstEntry))
            {
                calculatorScreen.text = "Ýþlemin doðru!";
                screenText = true;
                firstEntry = 0; 
                secondEntry = 0;
                thirdEntry = 0;
                firstOperation = "";
                secondOperation = "";
                thirdOperation = "";
                enteredNumber = 1;


            }
            else
            {
                calculatorScreen.text = "Bulduðun sonuç "+firstEntry+". Tekrar dene!";
                screenText = true;
                firstEntry = 0; 
                secondEntry = 0;
                thirdEntry = 0;
                firstOperation = "";
                secondOperation = "";
                thirdOperation = "";
                enteredNumber = 1;


            }
        }
     
    }
    
}
