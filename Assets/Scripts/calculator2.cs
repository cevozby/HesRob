using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//iþlem önceliðine göre çalýþan bir hesap makinesi. Her tuþa bastýðýnda tuþta yazaný ekranda gösteriyor.
public class calculator2 : MonoBehaviour
{
    static int hesapSkoru = 0;
    System.Random rnd = new System.Random();
     static double firstEntry=0; //toplama çýkarma çarpma ve bölmede ilk yazýlan sayý
     static double secondEntry=0;
     static double thirdEntry=0;
     static string firstOperation = "";
     static string secondOperation = "";
     static string thirdOperation = "";
     static int enteredNumber = 1;
     static double wantedResult = 2;  //bulunmasýný istediðimiz sonuç
    [SerializeField] calculator2 thisScene;
    [SerializeField] TextMeshProUGUI infoScreen;
    [SerializeField] TextMeshProUGUI calculatorScreen; //iþlemi ve sonucu yazacaðýmýz yer
    static Boolean written = false; //first second veya third entry için rakam girilmiþse written true olacak
                             // + - * / ya basýnca tekrar sayý giriþi olmasý gerektiði için false a dönecek
    static Boolean screenText = true;

    // Start is called before the first frame update
    void Start()
    {
        
        wantedResult = rnd.Next(1,20); //her seviyede 1 ile 20 arasý rastgele bir sayýyý bulmamýzý isteyecek
        infoScreen.text = "Sonucu "+ wantedResult+" olan bir iþlem yap!";
        calculatorScreen.text = "";
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
            hesapSkoru += 5;
            written = false;
            if (enteredNumber == 1)
            {
                firstOperation = "+";
                enteredNumber = 2;
                calculatorScreen.text += firstOperation;
            }

            else  if (enteredNumber == 2)
            {
                secondOperation = "+";
                enteredNumber = 3;
                calculatorScreen.text += secondOperation;

            }
            else if (enteredNumber == 3)
            {
                thirdOperation = "+";
                calculatorScreen.text += thirdOperation;
                doTheMath();
            }
        }


    }

    //eksi tuþu
    public void subtraction()
    {
        if (written == true)
        {
            hesapSkoru += 5;
            written = false;
            if (enteredNumber == 1)
            {
                    firstOperation = "-";
                    enteredNumber = 2;
                    calculatorScreen.text += firstOperation;
            }

            else if (enteredNumber == 2)
            {
                    secondOperation = "-";
                    enteredNumber = 3;
                    calculatorScreen.text += secondOperation;
                
            }
            else if (enteredNumber == 3)
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

        else if (firstOperation.Equals("-"))
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

       else  if (firstOperation.Equals("/"))
        {
            firstEntry /= secondEntry;
            secondEntry = thirdEntry;
            thirdEntry = 0;
            firstOperation = secondOperation;
            secondOperation = thirdOperation;
            written = false;

        }

        else if (firstOperation.Equals("*"))
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
            hesapSkoru += 5;
            written = false;
            if (enteredNumber == 1)
            {
                firstOperation = "/";
                enteredNumber = 2;
                calculatorScreen.text += firstOperation;
            }

            else if (enteredNumber == 2)
            {
                secondOperation = "/";
                enteredNumber = 3;
                calculatorScreen.text += secondOperation;

            }
            else if (enteredNumber == 3)
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
        hesapSkoru += 5;
        if (written == true)
        {
            written = false;
            if (enteredNumber == 1)
            {
                firstOperation = "*";
                enteredNumber = 2;
                calculatorScreen.text += firstOperation;
            }

            else if (enteredNumber == 2)
            {
                secondOperation = "*";
                enteredNumber = 3;
                calculatorScreen.text += secondOperation;

            }
            else if (enteredNumber == 3)
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
                infoScreen.text = "Ýþlemin doðru! Skor: "+ hesapSkoru;
                
                firstEntry = 0; 
                secondEntry = 0;
                thirdEntry = 0;
                firstOperation = "";
                secondOperation = "";
                thirdOperation = "";
                enteredNumber = 1;
                silme();


            }
            else
            {
                infoScreen.text = "Bulduðun sonuç "+firstEntry+". Tekrar dene!";
                
                firstEntry = 0; 
                secondEntry = 0;
                thirdEntry = 0;
                firstOperation = "";
                secondOperation = "";
                thirdOperation = "";
                enteredNumber = 1;
                silme();
                hesapSkoru = 0;


            }
        }
     
    }

    public void silme()
    {
        firstEntry = 0;
        secondEntry = 0;
        thirdEntry = 0;
        firstOperation = "";
        secondOperation = "";
        thirdOperation = "";
        enteredNumber = 1;
        calculatorScreen.text = "";
        written = false;
    }
    
}
