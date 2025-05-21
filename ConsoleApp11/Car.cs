using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_App
{
    public  class Car//Sınıf oluşturma.
    {
        //Field
        private string _marka;
        private string _model;
        private string _renk;
        private int _kapiSayisi;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }

        public int KapiSayisi
        {
            get { return _kapiSayisi;}

            set
            {
                if(value == 2 || value == 4)//Kapı sayısı Kontrol ediliyor
                {
                    _kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Araç kapısı 2 veya 4 olmak zorundadır.");
                    _kapiSayisi = -1;
                }
            }
        }

        public Car(string model , string marka , string  renk , int kapiSayisi)//consructor tanımlanıyor 
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi=kapiSayisi;
          

        }
        //Bilgileri yazdır adında metot tanımlanıyor.
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Araç Marka : {Marka} , Model : {Model} , Renk : {Renk} , Kapı Sayısı : {KapiSayisi} ");
        }
    }
}
