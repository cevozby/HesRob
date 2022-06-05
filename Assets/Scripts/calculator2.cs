using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//i�lem �nceli�ine g�re �al��an bir hesap makinesi. Her tu�a bast���nda tu�ta yazan� ekranda g�steriyor.
public class calculator2 : MonoBehaviour
{
    static int hesapSkoru = 0;
    System.Random rnd = new System.Random();
     static double firstEntry=0; //toplama ��karma �arpma ve b�lmede ilk yaz�lan say�
     static double secondEntry=0;
     static double thirdEntry=0;
     static string firstOperation = "";
     static string secondOperation = "";
     static string thirdOperation = "";
     static int enteredNumber = 1;
     static double wantedResult = 2;  //bulunmas�n� istedi�imiz sonu�
    [SerializeField] calculator2 thisScene;
    [SerializeField] TextMeshProUGUI infoScreen;
    [SerializeField] TextMeshProUGUI calculatorScreen; //i�lemi ve sonucu yazaca��m�z yer
    static Boolean written = false; //first second veya third entry i�in rakam girilmi�se written true olacak
                             // + - * / ya bas�nca tekrar say� giri�i olmas� gerekti�i i�in false a d�necek
    static Boolean screenText = true;

    // Start is called before the first frame update
    void Start()
    {
        
        wantedResult = rnd.Next(1,20); //her seviyede 1 ile 20 aras� rastgele bir say�y� bulmam�z� isteyecek
        infoScreen.text = "Sonucu "+ wantedResult+" olan bir i�lem yap!";
        calculatorScreen.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //rakam tu�lar�
    public void Number1()
    {
        addDigit(1);
        //yazd���m�z say�ya basamak ekliyoruz
        calculatorScreen.text += "1";
        //yaz�lan say�y� ekranda g�steriyoruz
        
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

    //rakam tu�lar�n�n kulland��� bir fonksiyon
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

        //yeni basamak eklerken say�y� onla �arp�p bas�lan tu�taki rakam ekleniyor

    }

    //art� tu�u
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

    //eksi tu�u
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

    //i�lem tu�lar�n�n kulland��� bir fonksiyon
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

    // b�l� tu�u
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

    //�arpma tu�u
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

    //hesap makinesindeki her tu�a bast���m�zda bu fonksiyonlar �al��abilir

    //e�ittir tu�una bas�nca bu �al��abilir. E�ittir yazd���m�z i�lemin sonucunu bulan tu�.
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
                infoScreen.text = "��lemin do�ru! Skor: "+ hesapSkoru;
                
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
                infoScreen.text = "Buldu�un sonu� "+firstEntry+". Tekrar dene!";
                
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
