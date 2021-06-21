﻿using System.Collections.Generic;

namespace CAD.Nomenclature
{
    /// <summary>
    /// Номенклатура за тип текст
    /// </summary>
    public static class CADTextType
    {
        /// <summary>
        /// Връща типа на текстa за подаденият код
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string Get(int code)
        {
            return texts.ContainsKey(code)
                ? texts[code]
                : null;
        }

        private static readonly Dictionary<int, string> texts = new Dictionary<int, string>()
        {
            {1,"Номер на триангулачна точка"},
            {2,"Триангулачна точка - кота"},
            {3,"Кота на теренна точка"},
            {4,"Височина на хоризонтал"},
            {5,"Височина на слог"},
            {6,"Височина на подпорна стена"},
            {7,"Числен надпис и характеристика на постройка"},
            {8,"Номер на имот"},
            {9,"Окръжен град"},
            {10,"Град"},
            {11,"Село"},
            {12,"Махала, колиба"},
            {13,"Към населено място"},
            {14,"Предградие, квартал"},
            {15,"Обособено държавно стопанство"},
            {16,"Хижа, замък, дворец"},
            {17,"Пояснителен надпис"},
            {18,"Пояснителен надпис на обект"},
            {19,"Номер на граничен знак и горски квартал"},
            {20,"Пояснителен надпис"},
            {21,"Улица или площад"},
            {22,"Улица 2,0"},
            {23,"Улица 1,7"},
            {24,"Улица 1,4"},
            {25,"Местност 5,7"},
            {26,"Местност 4,5"},
            {27,"Местност 4,0"},
            {28,"Местност 3,3"},
            {29,"Местност 2,8"},
            {30,"Местност 2,3"},
            {31,"Местност 2,0"},
            {32,"Море, реки, езера и др."},
            {33,"Море 5,7"},
            {34,"Море 4,0"},
            {35,"Море 2,8"},
            {36,"Плавателна река"},
            {37,"Неплавателна река"},
            {38,"Дерета"},
            {39,"Извор"},
            {40,"Планина 4,0"},
            {41,"Планина 3,3"},
            {42,"Планина 2,5"},
            {43,"Планина 2,0"},
            {44,"Планина 1,7"},
            {45,"Могила"},
            {46,"Съседна държава"},
            {47,"Номенклатура на картен лист"},
            {48,"Мащаб"},
            {49,"Издател"},
            {50,"Координатна система"},
            {51,"Степен на секретност"},
            {52,"Номенклатура на съседни картни листове"},
            {60,"Местност и квартал"},
            {66,"Надпис на напречен профил (червени арабски циф¬ри, с височина 2 mm)"},
            {67,"Номер на осова точка (червени арабски цифри, с височина 2mm)"},
            {68,"Номер на сграда със самостоятелни обекти"},
            {69,"Номер на сграда"},
            {70,"Номер на определяща точка"},
            {71,"Административен номер"},
            {72,"Водна площ"},
            {73,"Наименование на местност"},
            {74,"Надпис на землищна граница"},
            {501,"Подотдел - числител"},
            {502,"Подотдел - знаменател"},
            {503,"Отдел - числител"},
            {504,"Отдел - знаменател"},
            {505,"Име на съседно лесничейство"},
            {506,"Име на съседен участък"},
            {507,"Съседна държава"},
            {508,"Съседна държава"},
            {509,"Столица"},
            {510,"Столица"},
            {511,"Град - област"},
            {512,"Град - община"},
            {513,"Село - община"},
            {514,"Село - кметство"},
            {515,"Посока към ..."},
            {516,"Посока към Манастир"},
            {517,"Посока към Хижа"},
            {518,"Посока към Местност"},
            {519,"Име на Р,ИМ,ПЗ,ЗМ,НП"},
            {520,"Име на Р,ИМ,ПЗ,ЗМ,НП"},
            {521,"Име на Р,ИМ,ПЗ,ЗМ,НП"},
            {522,"Езеро 5мм"},
            {523,"Язовир 5мм"},
            {524,"Язовир 3мм"},
            {525,"микроязовир"},
            {526,"Р.Дунав"},
            {527,"Река 3.5мм"},
            {528,"Сухо дере"},
            {529,"Извор"},
            {530,"Било"},
            {531,"Съкращения"},
            {532,"Надморска височина"},
            {533,"Име на област"},
            {534,"Име на община"},
            {535,"Име на кметство"},
            {536,"Име на землище"},
            {537,"Планина 8мм"},
            {538,"Планина 6мм"},
            {539,"Море 5.4мм"},
            {540,"Язовир 5.5мм"},
            {541,"Име на административна граница"},
            {542,"Началник отдел"},
            {543,"скала на мащаба"},
            {61,"Отреждане за обществени мероприятия"},
            {62,"Номер на квартал"},
            {63,"Номер на дворищен парцел"},
            {64,"Номер на обществен парцел"},
            {65,"Отреждане на дворищно-регулационен парцел"}
        };
    }
}