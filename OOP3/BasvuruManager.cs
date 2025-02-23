﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // metod injection
        public void BasvuruYap(IKrediManager krediManager,List< ILoggerService >loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
         
            krediManager.Hesapla();
            foreach (var loggerservice in loggerServices)
            {
                loggerservice.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>  krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
