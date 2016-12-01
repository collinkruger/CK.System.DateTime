using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK.System
{
    public static class DateTimeTimeZoneExt
    {
        static readonly TimeZoneInfo _AfghanistanStandardTime;
        ///<summary>
        ///Converts UTC to Afghanistan Standard Time
        ///<para>Id: Afghanistan Standard Time</para>
        ///<para>Display Name: (UTC+04:30) Kabul</para>
        ///<para>Standard Name: Afghanistan Standard Time</para>
        ///<para>Daylight Name: Afghanistan Daylight Time</para>
        ///<para>Base Utc Offset: 04:30:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToAfghanistanStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AfghanistanStandardTime);

        static readonly TimeZoneInfo _AlaskanStandardTime;
        ///<summary>
        ///Converts UTC to Alaskan Standard Time
        ///<para>Id: Alaskan Standard Time</para>
        ///<para>Display Name: (UTC-09:00) Alaska</para>
        ///<para>Standard Name: Alaskan Standard Time</para>
        ///<para>Daylight Name: Alaskan Daylight Time</para>
        ///<para>Base Utc Offset: -09:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToAlaskanStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AlaskanStandardTime);

        static readonly TimeZoneInfo _AleutianStandardTime;
        ///<summary>
        ///Converts UTC to Aleutian Standard Time
        ///<para>Id: Aleutian Standard Time</para>
        ///<para>Display Name: (UTC-10:00) Aleutian Islands</para>
        ///<para>Standard Name: Aleutian Standard Time</para>
        ///<para>Daylight Name: Aleutian Daylight Time</para>
        ///<para>Base Utc Offset: -10:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToAleutianStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AleutianStandardTime);

        static readonly TimeZoneInfo _AltaiStandardTime;
        ///<summary>
        ///Converts UTC to Altai Standard Time
        ///<para>Id: Altai Standard Time</para>
        ///<para>Display Name: (UTC+07:00) Barnaul, Gorno-Altaysk</para>
        ///<para>Standard Name: Altai Standard Time</para>
        ///<para>Daylight Name: Altai Daylight Time</para>
        ///<para>Base Utc Offset: 07:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToAltaiStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AltaiStandardTime);

        static readonly TimeZoneInfo _ArabStandardTime;
        ///<summary>
        ///Converts UTC to Arab Standard Time
        ///<para>Id: Arab Standard Time</para>
        ///<para>Display Name: (UTC+03:00) Kuwait, Riyadh</para>
        ///<para>Standard Name: Arab Standard Time</para>
        ///<para>Daylight Name: Arab Daylight Time</para>
        ///<para>Base Utc Offset: 03:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToArabStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _ArabStandardTime);

        static readonly TimeZoneInfo _ArabianStandardTime;
        ///<summary>
        ///Converts UTC to Arabian Standard Time
        ///<para>Id: Arabian Standard Time</para>
        ///<para>Display Name: (UTC+04:00) Abu Dhabi, Muscat</para>
        ///<para>Standard Name: Arabian Standard Time</para>
        ///<para>Daylight Name: Arabian Daylight Time</para>
        ///<para>Base Utc Offset: 04:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToArabianStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _ArabianStandardTime);

        static readonly TimeZoneInfo _ArabicStandardTime;
        ///<summary>
        ///Converts UTC to Arabic Standard Time
        ///<para>Id: Arabic Standard Time</para>
        ///<para>Display Name: (UTC+03:00) Baghdad</para>
        ///<para>Standard Name: Arabic Standard Time</para>
        ///<para>Daylight Name: Arabic Daylight Time</para>
        ///<para>Base Utc Offset: 03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToArabicStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _ArabicStandardTime);

        static readonly TimeZoneInfo _ArgentinaStandardTime;
        ///<summary>
        ///Converts UTC to Argentina Standard Time
        ///<para>Id: Argentina Standard Time</para>
        ///<para>Display Name: (UTC-03:00) City of Buenos Aires</para>
        ///<para>Standard Name: Argentina Standard Time</para>
        ///<para>Daylight Name: Argentina Daylight Time</para>
        ///<para>Base Utc Offset: -03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToArgentinaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _ArgentinaStandardTime);

        static readonly TimeZoneInfo _AstrakhanStandardTime;
        ///<summary>
        ///Converts UTC to Astrakhan Standard Time
        ///<para>Id: Astrakhan Standard Time</para>
        ///<para>Display Name: (UTC+04:00) Astrakhan, Ulyanovsk</para>
        ///<para>Standard Name: Astrakhan Standard Time</para>
        ///<para>Daylight Name: Astrakhan Daylight Time</para>
        ///<para>Base Utc Offset: 04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToAstrakhanStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AstrakhanStandardTime);

        static readonly TimeZoneInfo _AtlanticStandardTime;
        ///<summary>
        ///Converts UTC to Atlantic Standard Time
        ///<para>Id: Atlantic Standard Time</para>
        ///<para>Display Name: (UTC-04:00) Atlantic Time (Canada)</para>
        ///<para>Standard Name: Atlantic Standard Time</para>
        ///<para>Daylight Name: Atlantic Daylight Time</para>
        ///<para>Base Utc Offset: -04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToAtlanticStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AtlanticStandardTime);

        static readonly TimeZoneInfo _AUSCentralStandardTime;
        ///<summary>
        ///Converts UTC to AUS Central Standard Time
        ///<para>Id: AUS Central Standard Time</para>
        ///<para>Display Name: (UTC+09:30) Darwin</para>
        ///<para>Standard Name: AUS Central Standard Time</para>
        ///<para>Daylight Name: AUS Central Daylight Time</para>
        ///<para>Base Utc Offset: 09:30:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToAUSCentralStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AUSCentralStandardTime);

        static readonly TimeZoneInfo _AusCentralWStandardTime;
        ///<summary>
        ///Converts UTC to Aus Central W. Standard Time
        ///<para>Id: Aus Central W. Standard Time</para>
        ///<para>Display Name: (UTC+08:45) Eucla</para>
        ///<para>Standard Name: Aus Central W. Standard Time</para>
        ///<para>Daylight Name: Aus Central W. Daylight Time</para>
        ///<para>Base Utc Offset: 08:45:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToAusCentralWStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AusCentralWStandardTime);

        static readonly TimeZoneInfo _AUSEasternStandardTime;
        ///<summary>
        ///Converts UTC to AUS Eastern Standard Time
        ///<para>Id: AUS Eastern Standard Time</para>
        ///<para>Display Name: (UTC+10:00) Canberra, Melbourne, Sydney</para>
        ///<para>Standard Name: AUS Eastern Standard Time</para>
        ///<para>Daylight Name: AUS Eastern Daylight Time</para>
        ///<para>Base Utc Offset: 10:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToAUSEasternStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AUSEasternStandardTime);

        static readonly TimeZoneInfo _AzerbaijanStandardTime;
        ///<summary>
        ///Converts UTC to Azerbaijan Standard Time
        ///<para>Id: Azerbaijan Standard Time</para>
        ///<para>Display Name: (UTC+04:00) Baku</para>
        ///<para>Standard Name: Azerbaijan Standard Time</para>
        ///<para>Daylight Name: Azerbaijan Daylight Time</para>
        ///<para>Base Utc Offset: 04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToAzerbaijanStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AzerbaijanStandardTime);

        static readonly TimeZoneInfo _AzoresStandardTime;
        ///<summary>
        ///Converts UTC to Azores Standard Time
        ///<para>Id: Azores Standard Time</para>
        ///<para>Display Name: (UTC-01:00) Azores</para>
        ///<para>Standard Name: Azores Standard Time</para>
        ///<para>Daylight Name: Azores Daylight Time</para>
        ///<para>Base Utc Offset: -01:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToAzoresStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _AzoresStandardTime);

        static readonly TimeZoneInfo _BahiaStandardTime;
        ///<summary>
        ///Converts UTC to Bahia Standard Time
        ///<para>Id: Bahia Standard Time</para>
        ///<para>Display Name: (UTC-03:00) Salvador</para>
        ///<para>Standard Name: Bahia Standard Time</para>
        ///<para>Daylight Name: Bahia Daylight Time</para>
        ///<para>Base Utc Offset: -03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToBahiaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _BahiaStandardTime);

        static readonly TimeZoneInfo _BangladeshStandardTime;
        ///<summary>
        ///Converts UTC to Bangladesh Standard Time
        ///<para>Id: Bangladesh Standard Time</para>
        ///<para>Display Name: (UTC+06:00) Dhaka</para>
        ///<para>Standard Name: Bangladesh Standard Time</para>
        ///<para>Daylight Name: Bangladesh Daylight Time</para>
        ///<para>Base Utc Offset: 06:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToBangladeshStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _BangladeshStandardTime);

        static readonly TimeZoneInfo _BelarusStandardTime;
        ///<summary>
        ///Converts UTC to Belarus Standard Time
        ///<para>Id: Belarus Standard Time</para>
        ///<para>Display Name: (UTC+03:00) Minsk</para>
        ///<para>Standard Name: Belarus Standard Time</para>
        ///<para>Daylight Name: Belarus Daylight Time</para>
        ///<para>Base Utc Offset: 03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToBelarusStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _BelarusStandardTime);

        static readonly TimeZoneInfo _BougainvilleStandardTime;
        ///<summary>
        ///Converts UTC to Bougainville Standard Time
        ///<para>Id: Bougainville Standard Time</para>
        ///<para>Display Name: (UTC+11:00) Bougainville Island</para>
        ///<para>Standard Name: Bougainville Standard Time</para>
        ///<para>Daylight Name: Bougainville Daylight Time</para>
        ///<para>Base Utc Offset: 11:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToBougainvilleStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _BougainvilleStandardTime);

        static readonly TimeZoneInfo _CanadaCentralStandardTime;
        ///<summary>
        ///Converts UTC to Canada Central Standard Time
        ///<para>Id: Canada Central Standard Time</para>
        ///<para>Display Name: (UTC-06:00) Saskatchewan</para>
        ///<para>Standard Name: Canada Central Standard Time</para>
        ///<para>Daylight Name: Canada Central Daylight Time</para>
        ///<para>Base Utc Offset: -06:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToCanadaCentralStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CanadaCentralStandardTime);

        static readonly TimeZoneInfo _CapeVerdeStandardTime;
        ///<summary>
        ///Converts UTC to Cape Verde Standard Time
        ///<para>Id: Cape Verde Standard Time</para>
        ///<para>Display Name: (UTC-01:00) Cabo Verde Is.</para>
        ///<para>Standard Name: Cabo Verde Standard Time</para>
        ///<para>Daylight Name: Cabo Verde Daylight Time</para>
        ///<para>Base Utc Offset: -01:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToCapeVerdeStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CapeVerdeStandardTime);

        static readonly TimeZoneInfo _CaucasusStandardTime;
        ///<summary>
        ///Converts UTC to Caucasus Standard Time
        ///<para>Id: Caucasus Standard Time</para>
        ///<para>Display Name: (UTC+04:00) Yerevan</para>
        ///<para>Standard Name: Caucasus Standard Time</para>
        ///<para>Daylight Name: Caucasus Daylight Time</para>
        ///<para>Base Utc Offset: 04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToCaucasusStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CaucasusStandardTime);

        static readonly TimeZoneInfo _CenAustraliaStandardTime;
        ///<summary>
        ///Converts UTC to Cen. Australia Standard Time
        ///<para>Id: Cen. Australia Standard Time</para>
        ///<para>Display Name: (UTC+09:30) Adelaide</para>
        ///<para>Standard Name: Cen. Australia Standard Time</para>
        ///<para>Daylight Name: Cen. Australia Daylight Time</para>
        ///<para>Base Utc Offset: 09:30:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToCenAustraliaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CenAustraliaStandardTime);

        static readonly TimeZoneInfo _CentralAmericaStandardTime;
        ///<summary>
        ///Converts UTC to Central America Standard Time
        ///<para>Id: Central America Standard Time</para>
        ///<para>Display Name: (UTC-06:00) Central America</para>
        ///<para>Standard Name: Central America Standard Time</para>
        ///<para>Daylight Name: Central America Daylight Time</para>
        ///<para>Base Utc Offset: -06:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToCentralAmericaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CentralAmericaStandardTime);

        static readonly TimeZoneInfo _CentralAsiaStandardTime;
        ///<summary>
        ///Converts UTC to Central Asia Standard Time
        ///<para>Id: Central Asia Standard Time</para>
        ///<para>Display Name: (UTC+06:00) Astana</para>
        ///<para>Standard Name: Central Asia Standard Time</para>
        ///<para>Daylight Name: Central Asia Daylight Time</para>
        ///<para>Base Utc Offset: 06:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToCentralAsiaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CentralAsiaStandardTime);

        static readonly TimeZoneInfo _CentralBrazilianStandardTime;
        ///<summary>
        ///Converts UTC to Central Brazilian Standard Time
        ///<para>Id: Central Brazilian Standard Time</para>
        ///<para>Display Name: (UTC-04:00) Cuiaba</para>
        ///<para>Standard Name: Central Brazilian Standard Time</para>
        ///<para>Daylight Name: Central Brazilian Daylight Time</para>
        ///<para>Base Utc Offset: -04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToCentralBrazilianStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CentralBrazilianStandardTime);

        static readonly TimeZoneInfo _CentralEuropeStandardTime;
        ///<summary>
        ///Converts UTC to Central Europe Standard Time
        ///<para>Id: Central Europe Standard Time</para>
        ///<para>Display Name: (UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague</para>
        ///<para>Standard Name: Central Europe Standard Time</para>
        ///<para>Daylight Name: Central Europe Daylight Time</para>
        ///<para>Base Utc Offset: 01:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToCentralEuropeStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CentralEuropeStandardTime);

        static readonly TimeZoneInfo _CentralEuropeanStandardTime;
        ///<summary>
        ///Converts UTC to Central European Standard Time
        ///<para>Id: Central European Standard Time</para>
        ///<para>Display Name: (UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb</para>
        ///<para>Standard Name: Central European Standard Time</para>
        ///<para>Daylight Name: Central European Daylight Time</para>
        ///<para>Base Utc Offset: 01:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToCentralEuropeanStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CentralEuropeanStandardTime);

        static readonly TimeZoneInfo _CentralPacificStandardTime;
        ///<summary>
        ///Converts UTC to Central Pacific Standard Time
        ///<para>Id: Central Pacific Standard Time</para>
        ///<para>Display Name: (UTC+11:00) Solomon Is., New Caledonia</para>
        ///<para>Standard Name: Central Pacific Standard Time</para>
        ///<para>Daylight Name: Central Pacific Daylight Time</para>
        ///<para>Base Utc Offset: 11:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToCentralPacificStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CentralPacificStandardTime);

        static readonly TimeZoneInfo _CentralStandardTime;
        ///<summary>
        ///Converts UTC to Central Standard Time
        ///<para>Id: Central Standard Time</para>
        ///<para>Display Name: (UTC-06:00) Central Time (US & Canada)</para>
        ///<para>Standard Name: Central Standard Time</para>
        ///<para>Daylight Name: Central Daylight Time</para>
        ///<para>Base Utc Offset: -06:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToCentralStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CentralStandardTime);

        static readonly TimeZoneInfo _CentralStandardTimeInMexico;
        ///<summary>
        ///Converts UTC to Central Standard Time (Mexico)
        ///<para>Id: Central Standard Time (Mexico)</para>
        ///<para>Display Name: (UTC-06:00) Guadalajara, Mexico City, Monterrey</para>
        ///<para>Standard Name: Central Standard Time (Mexico)</para>
        ///<para>Daylight Name: Central Daylight Time (Mexico)</para>
        ///<para>Base Utc Offset: -06:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToCentralStandardTimeInMexicoFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CentralStandardTimeInMexico);

        static readonly TimeZoneInfo _ChathamIslandsStandardTime;
        ///<summary>
        ///Converts UTC to Chatham Islands Standard Time
        ///<para>Id: Chatham Islands Standard Time</para>
        ///<para>Display Name: (UTC+12:45) Chatham Islands</para>
        ///<para>Standard Name: Chatham Islands Standard Time</para>
        ///<para>Daylight Name: Chatham Islands Daylight Time</para>
        ///<para>Base Utc Offset: 12:45:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToChathamIslandsStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _ChathamIslandsStandardTime);

        static readonly TimeZoneInfo _ChinaStandardTime;
        ///<summary>
        ///Converts UTC to China Standard Time
        ///<para>Id: China Standard Time</para>
        ///<para>Display Name: (UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi</para>
        ///<para>Standard Name: China Standard Time</para>
        ///<para>Daylight Name: China Daylight Time</para>
        ///<para>Base Utc Offset: 08:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToChinaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _ChinaStandardTime);

        static readonly TimeZoneInfo _CubaStandardTime;
        ///<summary>
        ///Converts UTC to Cuba Standard Time
        ///<para>Id: Cuba Standard Time</para>
        ///<para>Display Name: (UTC-05:00) Havana</para>
        ///<para>Standard Name: Cuba Standard Time</para>
        ///<para>Daylight Name: Cuba Daylight Time</para>
        ///<para>Base Utc Offset: -05:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToCubaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _CubaStandardTime);

        static readonly TimeZoneInfo _DatelineStandardTime;
        ///<summary>
        ///Converts UTC to Dateline Standard Time
        ///<para>Id: Dateline Standard Time</para>
        ///<para>Display Name: (UTC-12:00) International Date Line West</para>
        ///<para>Standard Name: Dateline Standard Time</para>
        ///<para>Daylight Name: Dateline Daylight Time</para>
        ///<para>Base Utc Offset: -12:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToDatelineStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _DatelineStandardTime);

        static readonly TimeZoneInfo _EAfricaStandardTime;
        ///<summary>
        ///Converts UTC to E. Africa Standard Time
        ///<para>Id: E. Africa Standard Time</para>
        ///<para>Display Name: (UTC+03:00) Nairobi</para>
        ///<para>Standard Name: E. Africa Standard Time</para>
        ///<para>Daylight Name: E. Africa Daylight Time</para>
        ///<para>Base Utc Offset: 03:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToEAfricaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _EAfricaStandardTime);

        static readonly TimeZoneInfo _EAustraliaStandardTime;
        ///<summary>
        ///Converts UTC to E. Australia Standard Time
        ///<para>Id: E. Australia Standard Time</para>
        ///<para>Display Name: (UTC+10:00) Brisbane</para>
        ///<para>Standard Name: E. Australia Standard Time</para>
        ///<para>Daylight Name: E. Australia Daylight Time</para>
        ///<para>Base Utc Offset: 10:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToEAustraliaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _EAustraliaStandardTime);

        static readonly TimeZoneInfo _EEuropeStandardTime;
        ///<summary>
        ///Converts UTC to E. Europe Standard Time
        ///<para>Id: E. Europe Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Chisinau</para>
        ///<para>Standard Name: E. Europe Standard Time</para>
        ///<para>Daylight Name: E. Europe Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToEEuropeStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _EEuropeStandardTime);

        static readonly TimeZoneInfo _ESouthAmericaStandardTime;
        ///<summary>
        ///Converts UTC to E. South America Standard Time
        ///<para>Id: E. South America Standard Time</para>
        ///<para>Display Name: (UTC-03:00) Brasilia</para>
        ///<para>Standard Name: E. South America Standard Time</para>
        ///<para>Daylight Name: E. South America Daylight Time</para>
        ///<para>Base Utc Offset: -03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToESouthAmericaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _ESouthAmericaStandardTime);

        static readonly TimeZoneInfo _EasterIslandStandardTime;
        ///<summary>
        ///Converts UTC to Easter Island Standard Time
        ///<para>Id: Easter Island Standard Time</para>
        ///<para>Display Name: (UTC-06:00) Easter Island</para>
        ///<para>Standard Name: Easter Island Standard Time</para>
        ///<para>Daylight Name: Easter Island Daylight Time</para>
        ///<para>Base Utc Offset: -06:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToEasterIslandStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _EasterIslandStandardTime);

        static readonly TimeZoneInfo _EasternStandardTime;
        ///<summary>
        ///Converts UTC to Eastern Standard Time
        ///<para>Id: Eastern Standard Time</para>
        ///<para>Display Name: (UTC-05:00) Eastern Time (US & Canada)</para>
        ///<para>Standard Name: Eastern Standard Time</para>
        ///<para>Daylight Name: Eastern Daylight Time</para>
        ///<para>Base Utc Offset: -05:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToEasternStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _EasternStandardTime);

        static readonly TimeZoneInfo _EasternStandardTimeInMexico;
        ///<summary>
        ///Converts UTC to Eastern Standard Time (Mexico)
        ///<para>Id: Eastern Standard Time (Mexico)</para>
        ///<para>Display Name: (UTC-05:00) Chetumal</para>
        ///<para>Standard Name: Eastern Standard Time (Mexico)</para>
        ///<para>Daylight Name: Eastern Daylight Time (Mexico)</para>
        ///<para>Base Utc Offset: -05:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToEasternStandardTimeInMexicoFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _EasternStandardTimeInMexico);

        static readonly TimeZoneInfo _EgyptStandardTime;
        ///<summary>
        ///Converts UTC to Egypt Standard Time
        ///<para>Id: Egypt Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Cairo</para>
        ///<para>Standard Name: Egypt Standard Time</para>
        ///<para>Daylight Name: Egypt Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToEgyptStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _EgyptStandardTime);

        static readonly TimeZoneInfo _EkaterinburgStandardTime;
        ///<summary>
        ///Converts UTC to Ekaterinburg Standard Time
        ///<para>Id: Ekaterinburg Standard Time</para>
        ///<para>Display Name: (UTC+05:00) Ekaterinburg</para>
        ///<para>Standard Name: Russia TZ 4 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 4 Daylight Time</para>
        ///<para>Base Utc Offset: 05:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToEkaterinburgStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _EkaterinburgStandardTime);

        static readonly TimeZoneInfo _FijiStandardTime;
        ///<summary>
        ///Converts UTC to Fiji Standard Time
        ///<para>Id: Fiji Standard Time</para>
        ///<para>Display Name: (UTC+12:00) Fiji</para>
        ///<para>Standard Name: Fiji Standard Time</para>
        ///<para>Daylight Name: Fiji Daylight Time</para>
        ///<para>Base Utc Offset: 12:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToFijiStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _FijiStandardTime);

        static readonly TimeZoneInfo _FLEStandardTime;
        ///<summary>
        ///Converts UTC to FLE Standard Time
        ///<para>Id: FLE Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius</para>
        ///<para>Standard Name: FLE Standard Time</para>
        ///<para>Daylight Name: FLE Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToFLEStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _FLEStandardTime);

        static readonly TimeZoneInfo _GeorgianStandardTime;
        ///<summary>
        ///Converts UTC to Georgian Standard Time
        ///<para>Id: Georgian Standard Time</para>
        ///<para>Display Name: (UTC+04:00) Tbilisi</para>
        ///<para>Standard Name: Georgian Standard Time</para>
        ///<para>Daylight Name: Georgian Daylight Time</para>
        ///<para>Base Utc Offset: 04:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToGeorgianStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _GeorgianStandardTime);

        static readonly TimeZoneInfo _GMTStandardTime;
        ///<summary>
        ///Converts UTC to GMT Standard Time
        ///<para>Id: GMT Standard Time</para>
        ///<para>Display Name: (UTC+00:00) Dublin, Edinburgh, Lisbon, London</para>
        ///<para>Standard Name: GMT Standard Time</para>
        ///<para>Daylight Name: GMT Daylight Time</para>
        ///<para>Base Utc Offset: 00:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToGMTStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _GMTStandardTime);

        static readonly TimeZoneInfo _GreenlandStandardTime;
        ///<summary>
        ///Converts UTC to Greenland Standard Time
        ///<para>Id: Greenland Standard Time</para>
        ///<para>Display Name: (UTC-03:00) Greenland</para>
        ///<para>Standard Name: Greenland Standard Time</para>
        ///<para>Daylight Name: Greenland Daylight Time</para>
        ///<para>Base Utc Offset: -03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToGreenlandStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _GreenlandStandardTime);

        static readonly TimeZoneInfo _GreenwichStandardTime;
        ///<summary>
        ///Converts UTC to Greenwich Standard Time
        ///<para>Id: Greenwich Standard Time</para>
        ///<para>Display Name: (UTC+00:00) Monrovia, Reykjavik</para>
        ///<para>Standard Name: Greenwich Standard Time</para>
        ///<para>Daylight Name: Greenwich Daylight Time</para>
        ///<para>Base Utc Offset: 00:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToGreenwichStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _GreenwichStandardTime);

        static readonly TimeZoneInfo _GTBStandardTime;
        ///<summary>
        ///Converts UTC to GTB Standard Time
        ///<para>Id: GTB Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Athens, Bucharest</para>
        ///<para>Standard Name: GTB Standard Time</para>
        ///<para>Daylight Name: GTB Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToGTBStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _GTBStandardTime);

        static readonly TimeZoneInfo _HaitiStandardTime;
        ///<summary>
        ///Converts UTC to Haiti Standard Time
        ///<para>Id: Haiti Standard Time</para>
        ///<para>Display Name: (UTC-05:00) Haiti</para>
        ///<para>Standard Name: Haiti Standard Time</para>
        ///<para>Daylight Name: Haiti Daylight Time</para>
        ///<para>Base Utc Offset: -05:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToHaitiStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _HaitiStandardTime);

        static readonly TimeZoneInfo _HawaiianStandardTime;
        ///<summary>
        ///Converts UTC to Hawaiian Standard Time
        ///<para>Id: Hawaiian Standard Time</para>
        ///<para>Display Name: (UTC-10:00) Hawaii</para>
        ///<para>Standard Name: Hawaiian Standard Time</para>
        ///<para>Daylight Name: Hawaiian Daylight Time</para>
        ///<para>Base Utc Offset: -10:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToHawaiianStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _HawaiianStandardTime);

        static readonly TimeZoneInfo _IndiaStandardTime;
        ///<summary>
        ///Converts UTC to India Standard Time
        ///<para>Id: India Standard Time</para>
        ///<para>Display Name: (UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi</para>
        ///<para>Standard Name: India Standard Time</para>
        ///<para>Daylight Name: India Daylight Time</para>
        ///<para>Base Utc Offset: 05:30:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToIndiaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _IndiaStandardTime);

        static readonly TimeZoneInfo _IranStandardTime;
        ///<summary>
        ///Converts UTC to Iran Standard Time
        ///<para>Id: Iran Standard Time</para>
        ///<para>Display Name: (UTC+03:30) Tehran</para>
        ///<para>Standard Name: Iran Standard Time</para>
        ///<para>Daylight Name: Iran Daylight Time</para>
        ///<para>Base Utc Offset: 03:30:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToIranStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _IranStandardTime);

        static readonly TimeZoneInfo _IsraelStandardTime;
        ///<summary>
        ///Converts UTC to Israel Standard Time
        ///<para>Id: Israel Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Jerusalem</para>
        ///<para>Standard Name: Jerusalem Standard Time</para>
        ///<para>Daylight Name: Jerusalem Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToIsraelStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _IsraelStandardTime);

        static readonly TimeZoneInfo _JordanStandardTime;
        ///<summary>
        ///Converts UTC to Jordan Standard Time
        ///<para>Id: Jordan Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Amman</para>
        ///<para>Standard Name: Jordan Standard Time</para>
        ///<para>Daylight Name: Jordan Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToJordanStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _JordanStandardTime);

        static readonly TimeZoneInfo _KaliningradStandardTime;
        ///<summary>
        ///Converts UTC to Kaliningrad Standard Time
        ///<para>Id: Kaliningrad Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Kaliningrad</para>
        ///<para>Standard Name: Russia TZ 1 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 1 Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToKaliningradStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _KaliningradStandardTime);

        static readonly TimeZoneInfo _KamchatkaStandardTime;
        ///<summary>
        ///Converts UTC to Kamchatka Standard Time
        ///<para>Id: Kamchatka Standard Time</para>
        ///<para>Display Name: (UTC+12:00) Petropavlovsk-Kamchatsky - Old</para>
        ///<para>Standard Name: Kamchatka Standard Time</para>
        ///<para>Daylight Name: Kamchatka Daylight Time</para>
        ///<para>Base Utc Offset: 12:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToKamchatkaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _KamchatkaStandardTime);

        static readonly TimeZoneInfo _KoreaStandardTime;
        ///<summary>
        ///Converts UTC to Korea Standard Time
        ///<para>Id: Korea Standard Time</para>
        ///<para>Display Name: (UTC+09:00) Seoul</para>
        ///<para>Standard Name: Korea Standard Time</para>
        ///<para>Daylight Name: Korea Daylight Time</para>
        ///<para>Base Utc Offset: 09:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToKoreaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _KoreaStandardTime);

        static readonly TimeZoneInfo _LibyaStandardTime;
        ///<summary>
        ///Converts UTC to Libya Standard Time
        ///<para>Id: Libya Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Tripoli</para>
        ///<para>Standard Name: Libya Standard Time</para>
        ///<para>Daylight Name: Libya Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToLibyaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _LibyaStandardTime);

        static readonly TimeZoneInfo _LineIslandsStandardTime;
        ///<summary>
        ///Converts UTC to Line Islands Standard Time
        ///<para>Id: Line Islands Standard Time</para>
        ///<para>Display Name: (UTC+14:00) Kiritimati Island</para>
        ///<para>Standard Name: Line Islands Standard Time</para>
        ///<para>Daylight Name: Line Islands Daylight Time</para>
        ///<para>Base Utc Offset: 14:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToLineIslandsStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _LineIslandsStandardTime);

        static readonly TimeZoneInfo _LordHoweStandardTime;
        ///<summary>
        ///Converts UTC to Lord Howe Standard Time
        ///<para>Id: Lord Howe Standard Time</para>
        ///<para>Display Name: (UTC+10:30) Lord Howe Island</para>
        ///<para>Standard Name: Lord Howe Standard Time</para>
        ///<para>Daylight Name: Lord Howe Daylight Time</para>
        ///<para>Base Utc Offset: 10:30:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToLordHoweStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _LordHoweStandardTime);

        static readonly TimeZoneInfo _MagadanStandardTime;
        ///<summary>
        ///Converts UTC to Magadan Standard Time
        ///<para>Id: Magadan Standard Time</para>
        ///<para>Display Name: (UTC+11:00) Magadan</para>
        ///<para>Standard Name: Magadan Standard Time</para>
        ///<para>Daylight Name: Magadan Daylight Time</para>
        ///<para>Base Utc Offset: 11:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToMagadanStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MagadanStandardTime);

        static readonly TimeZoneInfo _MarquesasStandardTime;
        ///<summary>
        ///Converts UTC to Marquesas Standard Time
        ///<para>Id: Marquesas Standard Time</para>
        ///<para>Display Name: (UTC-09:30) Marquesas Islands</para>
        ///<para>Standard Name: Marquesas Standard Time</para>
        ///<para>Daylight Name: Marquesas Daylight Time</para>
        ///<para>Base Utc Offset: -09:30:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToMarquesasStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MarquesasStandardTime);

        static readonly TimeZoneInfo _MauritiusStandardTime;
        ///<summary>
        ///Converts UTC to Mauritius Standard Time
        ///<para>Id: Mauritius Standard Time</para>
        ///<para>Display Name: (UTC+04:00) Port Louis</para>
        ///<para>Standard Name: Mauritius Standard Time</para>
        ///<para>Daylight Name: Mauritius Daylight Time</para>
        ///<para>Base Utc Offset: 04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToMauritiusStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MauritiusStandardTime);

        static readonly TimeZoneInfo _MidMinusAtlanticStandardTime;
        ///<summary>
        ///Converts UTC to Mid-Atlantic Standard Time
        ///<para>Id: Mid-Atlantic Standard Time</para>
        ///<para>Display Name: (UTC-02:00) Mid-Atlantic - Old</para>
        ///<para>Standard Name: Mid-Atlantic Standard Time</para>
        ///<para>Daylight Name: Mid-Atlantic Daylight Time</para>
        ///<para>Base Utc Offset: -02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToMidMinusAtlanticStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MidMinusAtlanticStandardTime);

        static readonly TimeZoneInfo _MiddleEastStandardTime;
        ///<summary>
        ///Converts UTC to Middle East Standard Time
        ///<para>Id: Middle East Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Beirut</para>
        ///<para>Standard Name: Middle East Standard Time</para>
        ///<para>Daylight Name: Middle East Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToMiddleEastStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MiddleEastStandardTime);

        static readonly TimeZoneInfo _MontevideoStandardTime;
        ///<summary>
        ///Converts UTC to Montevideo Standard Time
        ///<para>Id: Montevideo Standard Time</para>
        ///<para>Display Name: (UTC-03:00) Montevideo</para>
        ///<para>Standard Name: Montevideo Standard Time</para>
        ///<para>Daylight Name: Montevideo Daylight Time</para>
        ///<para>Base Utc Offset: -03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToMontevideoStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MontevideoStandardTime);

        static readonly TimeZoneInfo _MoroccoStandardTime;
        ///<summary>
        ///Converts UTC to Morocco Standard Time
        ///<para>Id: Morocco Standard Time</para>
        ///<para>Display Name: (UTC+00:00) Casablanca</para>
        ///<para>Standard Name: Morocco Standard Time</para>
        ///<para>Daylight Name: Morocco Daylight Time</para>
        ///<para>Base Utc Offset: 00:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToMoroccoStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MoroccoStandardTime);

        static readonly TimeZoneInfo _MountainStandardTime;
        ///<summary>
        ///Converts UTC to Mountain Standard Time
        ///<para>Id: Mountain Standard Time</para>
        ///<para>Display Name: (UTC-07:00) Mountain Time (US & Canada)</para>
        ///<para>Standard Name: Mountain Standard Time</para>
        ///<para>Daylight Name: Mountain Daylight Time</para>
        ///<para>Base Utc Offset: -07:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToMountainStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MountainStandardTime);

        static readonly TimeZoneInfo _MountainStandardTimeInMexico;
        ///<summary>
        ///Converts UTC to Mountain Standard Time (Mexico)
        ///<para>Id: Mountain Standard Time (Mexico)</para>
        ///<para>Display Name: (UTC-07:00) Chihuahua, La Paz, Mazatlan</para>
        ///<para>Standard Name: Mountain Standard Time (Mexico)</para>
        ///<para>Daylight Name: Mountain Daylight Time (Mexico)</para>
        ///<para>Base Utc Offset: -07:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToMountainStandardTimeInMexicoFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MountainStandardTimeInMexico);

        static readonly TimeZoneInfo _MyanmarStandardTime;
        ///<summary>
        ///Converts UTC to Myanmar Standard Time
        ///<para>Id: Myanmar Standard Time</para>
        ///<para>Display Name: (UTC+06:30) Yangon (Rangoon)</para>
        ///<para>Standard Name: Myanmar Standard Time</para>
        ///<para>Daylight Name: Myanmar Daylight Time</para>
        ///<para>Base Utc Offset: 06:30:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToMyanmarStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _MyanmarStandardTime);

        static readonly TimeZoneInfo _NCentralAsiaStandardTime;
        ///<summary>
        ///Converts UTC to N. Central Asia Standard Time
        ///<para>Id: N. Central Asia Standard Time</para>
        ///<para>Display Name: (UTC+07:00) Novosibirsk</para>
        ///<para>Standard Name: Novosibirsk Standard Time</para>
        ///<para>Daylight Name: Novosibirsk Daylight Time</para>
        ///<para>Base Utc Offset: 07:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToNCentralAsiaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NCentralAsiaStandardTime);

        static readonly TimeZoneInfo _NamibiaStandardTime;
        ///<summary>
        ///Converts UTC to Namibia Standard Time
        ///<para>Id: Namibia Standard Time</para>
        ///<para>Display Name: (UTC+01:00) Windhoek</para>
        ///<para>Standard Name: Namibia Standard Time</para>
        ///<para>Daylight Name: Namibia Daylight Time</para>
        ///<para>Base Utc Offset: 01:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToNamibiaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NamibiaStandardTime);

        static readonly TimeZoneInfo _NepalStandardTime;
        ///<summary>
        ///Converts UTC to Nepal Standard Time
        ///<para>Id: Nepal Standard Time</para>
        ///<para>Display Name: (UTC+05:45) Kathmandu</para>
        ///<para>Standard Name: Nepal Standard Time</para>
        ///<para>Daylight Name: Nepal Daylight Time</para>
        ///<para>Base Utc Offset: 05:45:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToNepalStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NepalStandardTime);

        static readonly TimeZoneInfo _NewZealandStandardTime;
        ///<summary>
        ///Converts UTC to New Zealand Standard Time
        ///<para>Id: New Zealand Standard Time</para>
        ///<para>Display Name: (UTC+12:00) Auckland, Wellington</para>
        ///<para>Standard Name: New Zealand Standard Time</para>
        ///<para>Daylight Name: New Zealand Daylight Time</para>
        ///<para>Base Utc Offset: 12:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToNewZealandStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NewZealandStandardTime);

        static readonly TimeZoneInfo _NewfoundlandStandardTime;
        ///<summary>
        ///Converts UTC to Newfoundland Standard Time
        ///<para>Id: Newfoundland Standard Time</para>
        ///<para>Display Name: (UTC-03:30) Newfoundland</para>
        ///<para>Standard Name: Newfoundland Standard Time</para>
        ///<para>Daylight Name: Newfoundland Daylight Time</para>
        ///<para>Base Utc Offset: -03:30:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToNewfoundlandStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NewfoundlandStandardTime);

        static readonly TimeZoneInfo _NorfolkStandardTime;
        ///<summary>
        ///Converts UTC to Norfolk Standard Time
        ///<para>Id: Norfolk Standard Time</para>
        ///<para>Display Name: (UTC+11:00) Norfolk Island</para>
        ///<para>Standard Name: Norfolk Standard Time</para>
        ///<para>Daylight Name: Norfolk Daylight Time</para>
        ///<para>Base Utc Offset: 11:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToNorfolkStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NorfolkStandardTime);

        static readonly TimeZoneInfo _NorthAsiaEastStandardTime;
        ///<summary>
        ///Converts UTC to North Asia East Standard Time
        ///<para>Id: North Asia East Standard Time</para>
        ///<para>Display Name: (UTC+08:00) Irkutsk</para>
        ///<para>Standard Name: Russia TZ 7 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 7 Daylight Time</para>
        ///<para>Base Utc Offset: 08:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToNorthAsiaEastStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NorthAsiaEastStandardTime);

        static readonly TimeZoneInfo _NorthAsiaStandardTime;
        ///<summary>
        ///Converts UTC to North Asia Standard Time
        ///<para>Id: North Asia Standard Time</para>
        ///<para>Display Name: (UTC+07:00) Krasnoyarsk</para>
        ///<para>Standard Name: Russia TZ 6 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 6 Daylight Time</para>
        ///<para>Base Utc Offset: 07:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToNorthAsiaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NorthAsiaStandardTime);

        static readonly TimeZoneInfo _NorthKoreaStandardTime;
        ///<summary>
        ///Converts UTC to North Korea Standard Time
        ///<para>Id: North Korea Standard Time</para>
        ///<para>Display Name: (UTC+08:30) Pyongyang</para>
        ///<para>Standard Name: North Korea Standard Time</para>
        ///<para>Daylight Name: North Korea Daylight Time</para>
        ///<para>Base Utc Offset: 08:30:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToNorthKoreaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _NorthKoreaStandardTime);

        static readonly TimeZoneInfo _OmskStandardTime;
        ///<summary>
        ///Converts UTC to Omsk Standard Time
        ///<para>Id: Omsk Standard Time</para>
        ///<para>Display Name: (UTC+06:00) Omsk</para>
        ///<para>Standard Name: Omsk Standard Time</para>
        ///<para>Daylight Name: Omsk Daylight Time</para>
        ///<para>Base Utc Offset: 06:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToOmskStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _OmskStandardTime);

        static readonly TimeZoneInfo _PacificSAStandardTime;
        ///<summary>
        ///Converts UTC to Pacific SA Standard Time
        ///<para>Id: Pacific SA Standard Time</para>
        ///<para>Display Name: (UTC-04:00) Santiago</para>
        ///<para>Standard Name: Pacific SA Standard Time</para>
        ///<para>Daylight Name: Pacific SA Daylight Time</para>
        ///<para>Base Utc Offset: -04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToPacificSAStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _PacificSAStandardTime);

        static readonly TimeZoneInfo _PacificStandardTime;
        ///<summary>
        ///Converts UTC to Pacific Standard Time
        ///<para>Id: Pacific Standard Time</para>
        ///<para>Display Name: (UTC-08:00) Pacific Time (US & Canada)</para>
        ///<para>Standard Name: Pacific Standard Time</para>
        ///<para>Daylight Name: Pacific Daylight Time</para>
        ///<para>Base Utc Offset: -08:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToPacificStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _PacificStandardTime);

        static readonly TimeZoneInfo _PacificStandardTimeInMexico;
        ///<summary>
        ///Converts UTC to Pacific Standard Time (Mexico)
        ///<para>Id: Pacific Standard Time (Mexico)</para>
        ///<para>Display Name: (UTC-08:00) Baja California</para>
        ///<para>Standard Name: Pacific Standard Time (Mexico)</para>
        ///<para>Daylight Name: Pacific Daylight Time (Mexico)</para>
        ///<para>Base Utc Offset: -08:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToPacificStandardTimeInMexicoFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _PacificStandardTimeInMexico);

        static readonly TimeZoneInfo _PakistanStandardTime;
        ///<summary>
        ///Converts UTC to Pakistan Standard Time
        ///<para>Id: Pakistan Standard Time</para>
        ///<para>Display Name: (UTC+05:00) Islamabad, Karachi</para>
        ///<para>Standard Name: Pakistan Standard Time</para>
        ///<para>Daylight Name: Pakistan Daylight Time</para>
        ///<para>Base Utc Offset: 05:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToPakistanStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _PakistanStandardTime);

        static readonly TimeZoneInfo _ParaguayStandardTime;
        ///<summary>
        ///Converts UTC to Paraguay Standard Time
        ///<para>Id: Paraguay Standard Time</para>
        ///<para>Display Name: (UTC-04:00) Asuncion</para>
        ///<para>Standard Name: Paraguay Standard Time</para>
        ///<para>Daylight Name: Paraguay Daylight Time</para>
        ///<para>Base Utc Offset: -04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToParaguayStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _ParaguayStandardTime);

        static readonly TimeZoneInfo _RomanceStandardTime;
        ///<summary>
        ///Converts UTC to Romance Standard Time
        ///<para>Id: Romance Standard Time</para>
        ///<para>Display Name: (UTC+01:00) Brussels, Copenhagen, Madrid, Paris</para>
        ///<para>Standard Name: Romance Standard Time</para>
        ///<para>Daylight Name: Romance Daylight Time</para>
        ///<para>Base Utc Offset: 01:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToRomanceStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _RomanceStandardTime);

        static readonly TimeZoneInfo _RussiaTimeZone10;
        ///<summary>
        ///Converts UTC to Russia Time Zone 10
        ///<para>Id: Russia Time Zone 10</para>
        ///<para>Display Name: (UTC+11:00) Chokurdakh</para>
        ///<para>Standard Name: Russia TZ 10 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 10 Daylight Time</para>
        ///<para>Base Utc Offset: 11:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToRussiaTimeZone10FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _RussiaTimeZone10);

        static readonly TimeZoneInfo _RussiaTimeZone11;
        ///<summary>
        ///Converts UTC to Russia Time Zone 11
        ///<para>Id: Russia Time Zone 11</para>
        ///<para>Display Name: (UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky</para>
        ///<para>Standard Name: Russia TZ 11 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 11 Daylight Time</para>
        ///<para>Base Utc Offset: 12:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToRussiaTimeZone11FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _RussiaTimeZone11);

        static readonly TimeZoneInfo _RussiaTimeZone3;
        ///<summary>
        ///Converts UTC to Russia Time Zone 3
        ///<para>Id: Russia Time Zone 3</para>
        ///<para>Display Name: (UTC+04:00) Izhevsk, Samara</para>
        ///<para>Standard Name: Russia TZ 3 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 3 Daylight Time</para>
        ///<para>Base Utc Offset: 04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToRussiaTimeZone3FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _RussiaTimeZone3);

        static readonly TimeZoneInfo _RussianStandardTime;
        ///<summary>
        ///Converts UTC to Russian Standard Time
        ///<para>Id: Russian Standard Time</para>
        ///<para>Display Name: (UTC+03:00) Moscow, St. Petersburg, Volgograd</para>
        ///<para>Standard Name: Russia TZ 2 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 2 Daylight Time</para>
        ///<para>Base Utc Offset: 03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToRussianStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _RussianStandardTime);

        static readonly TimeZoneInfo _SAEasternStandardTime;
        ///<summary>
        ///Converts UTC to SA Eastern Standard Time
        ///<para>Id: SA Eastern Standard Time</para>
        ///<para>Display Name: (UTC-03:00) Cayenne, Fortaleza</para>
        ///<para>Standard Name: SA Eastern Standard Time</para>
        ///<para>Daylight Name: SA Eastern Daylight Time</para>
        ///<para>Base Utc Offset: -03:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToSAEasternStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SAEasternStandardTime);

        static readonly TimeZoneInfo _SAPacificStandardTime;
        ///<summary>
        ///Converts UTC to SA Pacific Standard Time
        ///<para>Id: SA Pacific Standard Time</para>
        ///<para>Display Name: (UTC-05:00) Bogota, Lima, Quito, Rio Branco</para>
        ///<para>Standard Name: SA Pacific Standard Time</para>
        ///<para>Daylight Name: SA Pacific Daylight Time</para>
        ///<para>Base Utc Offset: -05:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToSAPacificStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SAPacificStandardTime);

        static readonly TimeZoneInfo _SAWesternStandardTime;
        ///<summary>
        ///Converts UTC to SA Western Standard Time
        ///<para>Id: SA Western Standard Time</para>
        ///<para>Display Name: (UTC-04:00) Georgetown, La Paz, Manaus, San Juan</para>
        ///<para>Standard Name: SA Western Standard Time</para>
        ///<para>Daylight Name: SA Western Daylight Time</para>
        ///<para>Base Utc Offset: -04:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToSAWesternStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SAWesternStandardTime);

        static readonly TimeZoneInfo _SaintPierreStandardTime;
        ///<summary>
        ///Converts UTC to Saint Pierre Standard Time
        ///<para>Id: Saint Pierre Standard Time</para>
        ///<para>Display Name: (UTC-03:00) Saint Pierre and Miquelon</para>
        ///<para>Standard Name: Saint Pierre Standard Time</para>
        ///<para>Daylight Name: Saint Pierre Daylight Time</para>
        ///<para>Base Utc Offset: -03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToSaintPierreStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SaintPierreStandardTime);

        static readonly TimeZoneInfo _SakhalinStandardTime;
        ///<summary>
        ///Converts UTC to Sakhalin Standard Time
        ///<para>Id: Sakhalin Standard Time</para>
        ///<para>Display Name: (UTC+11:00) Sakhalin</para>
        ///<para>Standard Name: Sakhalin Standard Time</para>
        ///<para>Daylight Name: Sakhalin Daylight Time</para>
        ///<para>Base Utc Offset: 11:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToSakhalinStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SakhalinStandardTime);

        static readonly TimeZoneInfo _SamoaStandardTime;
        ///<summary>
        ///Converts UTC to Samoa Standard Time
        ///<para>Id: Samoa Standard Time</para>
        ///<para>Display Name: (UTC+13:00) Samoa</para>
        ///<para>Standard Name: Samoa Standard Time</para>
        ///<para>Daylight Name: Samoa Daylight Time</para>
        ///<para>Base Utc Offset: 13:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToSamoaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SamoaStandardTime);

        static readonly TimeZoneInfo _SEAsiaStandardTime;
        ///<summary>
        ///Converts UTC to SE Asia Standard Time
        ///<para>Id: SE Asia Standard Time</para>
        ///<para>Display Name: (UTC+07:00) Bangkok, Hanoi, Jakarta</para>
        ///<para>Standard Name: SE Asia Standard Time</para>
        ///<para>Daylight Name: SE Asia Daylight Time</para>
        ///<para>Base Utc Offset: 07:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToSEAsiaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SEAsiaStandardTime);

        static readonly TimeZoneInfo _SingaporeStandardTime;
        ///<summary>
        ///Converts UTC to Singapore Standard Time
        ///<para>Id: Singapore Standard Time</para>
        ///<para>Display Name: (UTC+08:00) Kuala Lumpur, Singapore</para>
        ///<para>Standard Name: Malay Peninsula Standard Time</para>
        ///<para>Daylight Name: Malay Peninsula Daylight Time</para>
        ///<para>Base Utc Offset: 08:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToSingaporeStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SingaporeStandardTime);

        static readonly TimeZoneInfo _SouthAfricaStandardTime;
        ///<summary>
        ///Converts UTC to South Africa Standard Time
        ///<para>Id: South Africa Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Harare, Pretoria</para>
        ///<para>Standard Name: South Africa Standard Time</para>
        ///<para>Daylight Name: South Africa Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToSouthAfricaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SouthAfricaStandardTime);

        static readonly TimeZoneInfo _SriLankaStandardTime;
        ///<summary>
        ///Converts UTC to Sri Lanka Standard Time
        ///<para>Id: Sri Lanka Standard Time</para>
        ///<para>Display Name: (UTC+05:30) Sri Jayawardenepura</para>
        ///<para>Standard Name: Sri Lanka Standard Time</para>
        ///<para>Daylight Name: Sri Lanka Daylight Time</para>
        ///<para>Base Utc Offset: 05:30:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToSriLankaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SriLankaStandardTime);

        static readonly TimeZoneInfo _SyriaStandardTime;
        ///<summary>
        ///Converts UTC to Syria Standard Time
        ///<para>Id: Syria Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Damascus</para>
        ///<para>Standard Name: Syria Standard Time</para>
        ///<para>Daylight Name: Syria Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToSyriaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _SyriaStandardTime);

        static readonly TimeZoneInfo _TaipeiStandardTime;
        ///<summary>
        ///Converts UTC to Taipei Standard Time
        ///<para>Id: Taipei Standard Time</para>
        ///<para>Display Name: (UTC+08:00) Taipei</para>
        ///<para>Standard Name: Taipei Standard Time</para>
        ///<para>Daylight Name: Taipei Daylight Time</para>
        ///<para>Base Utc Offset: 08:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToTaipeiStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TaipeiStandardTime);

        static readonly TimeZoneInfo _TasmaniaStandardTime;
        ///<summary>
        ///Converts UTC to Tasmania Standard Time
        ///<para>Id: Tasmania Standard Time</para>
        ///<para>Display Name: (UTC+10:00) Hobart</para>
        ///<para>Standard Name: Tasmania Standard Time</para>
        ///<para>Daylight Name: Tasmania Daylight Time</para>
        ///<para>Base Utc Offset: 10:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToTasmaniaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TasmaniaStandardTime);

        static readonly TimeZoneInfo _TocantinsStandardTime;
        ///<summary>
        ///Converts UTC to Tocantins Standard Time
        ///<para>Id: Tocantins Standard Time</para>
        ///<para>Display Name: (UTC-03:00) Araguaina</para>
        ///<para>Standard Name: Tocantins Standard Time</para>
        ///<para>Daylight Name: Tocantins Daylight Time</para>
        ///<para>Base Utc Offset: -03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToTocantinsStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TocantinsStandardTime);

        static readonly TimeZoneInfo _TokyoStandardTime;
        ///<summary>
        ///Converts UTC to Tokyo Standard Time
        ///<para>Id: Tokyo Standard Time</para>
        ///<para>Display Name: (UTC+09:00) Osaka, Sapporo, Tokyo</para>
        ///<para>Standard Name: Tokyo Standard Time</para>
        ///<para>Daylight Name: Tokyo Daylight Time</para>
        ///<para>Base Utc Offset: 09:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToTokyoStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TokyoStandardTime);

        static readonly TimeZoneInfo _TomskStandardTime;
        ///<summary>
        ///Converts UTC to Tomsk Standard Time
        ///<para>Id: Tomsk Standard Time</para>
        ///<para>Display Name: (UTC+07:00) Tomsk</para>
        ///<para>Standard Name: Tomsk Standard Time</para>
        ///<para>Daylight Name: Tomsk Daylight Time</para>
        ///<para>Base Utc Offset: 07:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToTomskStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TomskStandardTime);

        static readonly TimeZoneInfo _TongaStandardTime;
        ///<summary>
        ///Converts UTC to Tonga Standard Time
        ///<para>Id: Tonga Standard Time</para>
        ///<para>Display Name: (UTC+13:00) Nuku'alofa</para>
        ///<para>Standard Name: Tonga Standard Time</para>
        ///<para>Daylight Name: Tonga Daylight Time</para>
        ///<para>Base Utc Offset: 13:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToTongaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TongaStandardTime);

        static readonly TimeZoneInfo _TransbaikalStandardTime;
        ///<summary>
        ///Converts UTC to Transbaikal Standard Time
        ///<para>Id: Transbaikal Standard Time</para>
        ///<para>Display Name: (UTC+09:00) Chita</para>
        ///<para>Standard Name: Transbaikal Standard Time</para>
        ///<para>Daylight Name: Transbaikal Daylight Time</para>
        ///<para>Base Utc Offset: 09:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToTransbaikalStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TransbaikalStandardTime);

        static readonly TimeZoneInfo _TurkeyStandardTime;
        ///<summary>
        ///Converts UTC to Turkey Standard Time
        ///<para>Id: Turkey Standard Time</para>
        ///<para>Display Name: (UTC+03:00) Istanbul</para>
        ///<para>Standard Name: Turkey Standard Time</para>
        ///<para>Daylight Name: Turkey Daylight Time</para>
        ///<para>Base Utc Offset: 03:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToTurkeyStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TurkeyStandardTime);

        static readonly TimeZoneInfo _TurksAndCaicosStandardTime;
        ///<summary>
        ///Converts UTC to Turks And Caicos Standard Time
        ///<para>Id: Turks And Caicos Standard Time</para>
        ///<para>Display Name: (UTC-04:00) Turks and Caicos</para>
        ///<para>Standard Name: Turks and Caicos Standard Time</para>
        ///<para>Daylight Name: Turks and Caicos Daylight Time</para>
        ///<para>Base Utc Offset: -04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToTurksAndCaicosStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _TurksAndCaicosStandardTime);

        static readonly TimeZoneInfo _UlaanbaatarStandardTime;
        ///<summary>
        ///Converts UTC to Ulaanbaatar Standard Time
        ///<para>Id: Ulaanbaatar Standard Time</para>
        ///<para>Display Name: (UTC+08:00) Ulaanbaatar</para>
        ///<para>Standard Name: Ulaanbaatar Standard Time</para>
        ///<para>Daylight Name: Ulaanbaatar Daylight Time</para>
        ///<para>Base Utc Offset: 08:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToUlaanbaatarStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _UlaanbaatarStandardTime);

        static readonly TimeZoneInfo _USEasternStandardTime;
        ///<summary>
        ///Converts UTC to US Eastern Standard Time
        ///<para>Id: US Eastern Standard Time</para>
        ///<para>Display Name: (UTC-05:00) Indiana (East)</para>
        ///<para>Standard Name: US Eastern Standard Time</para>
        ///<para>Daylight Name: US Eastern Daylight Time</para>
        ///<para>Base Utc Offset: -05:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToUSEasternStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _USEasternStandardTime);

        static readonly TimeZoneInfo _USMountainStandardTime;
        ///<summary>
        ///Converts UTC to US Mountain Standard Time
        ///<para>Id: US Mountain Standard Time</para>
        ///<para>Display Name: (UTC-07:00) Arizona</para>
        ///<para>Standard Name: US Mountain Standard Time</para>
        ///<para>Daylight Name: US Mountain Daylight Time</para>
        ///<para>Base Utc Offset: -07:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToUSMountainStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _USMountainStandardTime);

        static readonly TimeZoneInfo _UTC;
        ///<summary>
        ///Converts UTC to UTC
        ///<para>Id: UTC</para>
        ///<para>Display Name: (UTC) Coordinated Universal Time</para>
        ///<para>Standard Name: Coordinated Universal Time</para>
        ///<para>Daylight Name: Coordinated Universal Time</para>
        ///<para>Base Utc Offset: 00:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToUTCFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _UTC);

        static readonly TimeZoneInfo _UTCPlus12;
        ///<summary>
        ///Converts UTC to UTC+12
        ///<para>Id: UTC+12</para>
        ///<para>Display Name: (UTC+12:00) Coordinated Universal Time+12</para>
        ///<para>Standard Name: UTC+12</para>
        ///<para>Daylight Name: UTC+12</para>
        ///<para>Base Utc Offset: 12:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToUTCPlus12FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _UTCPlus12);

        static readonly TimeZoneInfo _UTCMinus02;
        ///<summary>
        ///Converts UTC to UTC-02
        ///<para>Id: UTC-02</para>
        ///<para>Display Name: (UTC-02:00) Coordinated Universal Time-02</para>
        ///<para>Standard Name: UTC-02</para>
        ///<para>Daylight Name: UTC-02</para>
        ///<para>Base Utc Offset: -02:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToUTCMinus02FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _UTCMinus02);

        static readonly TimeZoneInfo _UTCMinus08;
        ///<summary>
        ///Converts UTC to UTC-08
        ///<para>Id: UTC-08</para>
        ///<para>Display Name: (UTC-08:00) Coordinated Universal Time-08</para>
        ///<para>Standard Name: UTC-08</para>
        ///<para>Daylight Name: UTC-08</para>
        ///<para>Base Utc Offset: -08:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToUTCMinus08FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _UTCMinus08);

        static readonly TimeZoneInfo _UTCMinus09;
        ///<summary>
        ///Converts UTC to UTC-09
        ///<para>Id: UTC-09</para>
        ///<para>Display Name: (UTC-09:00) Coordinated Universal Time-09</para>
        ///<para>Standard Name: UTC-09</para>
        ///<para>Daylight Name: UTC-09</para>
        ///<para>Base Utc Offset: -09:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToUTCMinus09FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _UTCMinus09);

        static readonly TimeZoneInfo _UTCMinus11;
        ///<summary>
        ///Converts UTC to UTC-11
        ///<para>Id: UTC-11</para>
        ///<para>Display Name: (UTC-11:00) Coordinated Universal Time-11</para>
        ///<para>Standard Name: UTC-11</para>
        ///<para>Daylight Name: UTC-11</para>
        ///<para>Base Utc Offset: -11:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToUTCMinus11FromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _UTCMinus11);

        static readonly TimeZoneInfo _VenezuelaStandardTime;
        ///<summary>
        ///Converts UTC to Venezuela Standard Time
        ///<para>Id: Venezuela Standard Time</para>
        ///<para>Display Name: (UTC-04:00) Caracas</para>
        ///<para>Standard Name: Venezuela Standard Time</para>
        ///<para>Daylight Name: Venezuela Daylight Time</para>
        ///<para>Base Utc Offset: -04:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToVenezuelaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _VenezuelaStandardTime);

        static readonly TimeZoneInfo _VladivostokStandardTime;
        ///<summary>
        ///Converts UTC to Vladivostok Standard Time
        ///<para>Id: Vladivostok Standard Time</para>
        ///<para>Display Name: (UTC+10:00) Vladivostok</para>
        ///<para>Standard Name: Russia TZ 9 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 9 Daylight Time</para>
        ///<para>Base Utc Offset: 10:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToVladivostokStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _VladivostokStandardTime);

        static readonly TimeZoneInfo _WAustraliaStandardTime;
        ///<summary>
        ///Converts UTC to W. Australia Standard Time
        ///<para>Id: W. Australia Standard Time</para>
        ///<para>Display Name: (UTC+08:00) Perth</para>
        ///<para>Standard Name: W. Australia Standard Time</para>
        ///<para>Daylight Name: W. Australia Daylight Time</para>
        ///<para>Base Utc Offset: 08:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToWAustraliaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _WAustraliaStandardTime);

        static readonly TimeZoneInfo _WCentralAfricaStandardTime;
        ///<summary>
        ///Converts UTC to W. Central Africa Standard Time
        ///<para>Id: W. Central Africa Standard Time</para>
        ///<para>Display Name: (UTC+01:00) West Central Africa</para>
        ///<para>Standard Name: W. Central Africa Standard Time</para>
        ///<para>Daylight Name: W. Central Africa Daylight Time</para>
        ///<para>Base Utc Offset: 01:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToWCentralAfricaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _WCentralAfricaStandardTime);

        static readonly TimeZoneInfo _WEuropeStandardTime;
        ///<summary>
        ///Converts UTC to W. Europe Standard Time
        ///<para>Id: W. Europe Standard Time</para>
        ///<para>Display Name: (UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna</para>
        ///<para>Standard Name: W. Europe Standard Time</para>
        ///<para>Daylight Name: W. Europe Daylight Time</para>
        ///<para>Base Utc Offset: 01:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToWEuropeStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _WEuropeStandardTime);

        static readonly TimeZoneInfo _WMongoliaStandardTime;
        ///<summary>
        ///Converts UTC to W. Mongolia Standard Time
        ///<para>Id: W. Mongolia Standard Time</para>
        ///<para>Display Name: (UTC+07:00) Hovd</para>
        ///<para>Standard Name: W. Mongolia Standard Time</para>
        ///<para>Daylight Name: W. Mongolia Daylight Time</para>
        ///<para>Base Utc Offset: 07:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToWMongoliaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _WMongoliaStandardTime);

        static readonly TimeZoneInfo _WestAsiaStandardTime;
        ///<summary>
        ///Converts UTC to West Asia Standard Time
        ///<para>Id: West Asia Standard Time</para>
        ///<para>Display Name: (UTC+05:00) Ashgabat, Tashkent</para>
        ///<para>Standard Name: West Asia Standard Time</para>
        ///<para>Daylight Name: West Asia Daylight Time</para>
        ///<para>Base Utc Offset: 05:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToWestAsiaStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _WestAsiaStandardTime);

        static readonly TimeZoneInfo _WestBankStandardTime;
        ///<summary>
        ///Converts UTC to West Bank Standard Time
        ///<para>Id: West Bank Standard Time</para>
        ///<para>Display Name: (UTC+02:00) Gaza, Hebron</para>
        ///<para>Standard Name: West Bank Gaza Standard Time</para>
        ///<para>Daylight Name: West Bank Gaza Daylight Time</para>
        ///<para>Base Utc Offset: 02:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToWestBankStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _WestBankStandardTime);

        static readonly TimeZoneInfo _WestPacificStandardTime;
        ///<summary>
        ///Converts UTC to West Pacific Standard Time
        ///<para>Id: West Pacific Standard Time</para>
        ///<para>Display Name: (UTC+10:00) Guam, Port Moresby</para>
        ///<para>Standard Name: West Pacific Standard Time</para>
        ///<para>Daylight Name: West Pacific Daylight Time</para>
        ///<para>Base Utc Offset: 10:00:00</para>
        ///<para>Supports Daylight Savings Time: False</para>
        ///</summary>
        public static DateTime ToWestPacificStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _WestPacificStandardTime);

        static readonly TimeZoneInfo _YakutskStandardTime;
        ///<summary>
        ///Converts UTC to Yakutsk Standard Time
        ///<para>Id: Yakutsk Standard Time</para>
        ///<para>Display Name: (UTC+09:00) Yakutsk</para>
        ///<para>Standard Name: Russia TZ 8 Standard Time</para>
        ///<para>Daylight Name: Russia TZ 8 Daylight Time</para>
        ///<para>Base Utc Offset: 09:00:00</para>
        ///<para>Supports Daylight Savings Time: True</para>
        ///</summary>
        public static DateTime ToYakutskStandardTimeFromUTC(DateTime dateTimeUTC) => TimeZoneInfo.ConvertTimeFromUtc(dateTimeUTC, _YakutskStandardTime);

        static DateTimeTimeZoneExt()
        {
            var tzis = TimeZoneInfo.GetSystemTimeZones();
            _AfghanistanStandardTime = tzis.First(x => x.Id == "Afghanistan Standard Time");
            _AlaskanStandardTime = tzis.First(x => x.Id == "Alaskan Standard Time");
            _AleutianStandardTime = tzis.First(x => x.Id == "Aleutian Standard Time");
            _AltaiStandardTime = tzis.First(x => x.Id == "Altai Standard Time");
            _ArabStandardTime = tzis.First(x => x.Id == "Arab Standard Time");
            _ArabianStandardTime = tzis.First(x => x.Id == "Arabian Standard Time");
            _ArabicStandardTime = tzis.First(x => x.Id == "Arabic Standard Time");
            _ArgentinaStandardTime = tzis.First(x => x.Id == "Argentina Standard Time");
            _AstrakhanStandardTime = tzis.First(x => x.Id == "Astrakhan Standard Time");
            _AtlanticStandardTime = tzis.First(x => x.Id == "Atlantic Standard Time");
            _AUSCentralStandardTime = tzis.First(x => x.Id == "AUS Central Standard Time");
            _AusCentralWStandardTime = tzis.First(x => x.Id == "Aus Central W. Standard Time");
            _AUSEasternStandardTime = tzis.First(x => x.Id == "AUS Eastern Standard Time");
            _AzerbaijanStandardTime = tzis.First(x => x.Id == "Azerbaijan Standard Time");
            _AzoresStandardTime = tzis.First(x => x.Id == "Azores Standard Time");
            _BahiaStandardTime = tzis.First(x => x.Id == "Bahia Standard Time");
            _BangladeshStandardTime = tzis.First(x => x.Id == "Bangladesh Standard Time");
            _BelarusStandardTime = tzis.First(x => x.Id == "Belarus Standard Time");
            _BougainvilleStandardTime = tzis.First(x => x.Id == "Bougainville Standard Time");
            _CanadaCentralStandardTime = tzis.First(x => x.Id == "Canada Central Standard Time");
            _CapeVerdeStandardTime = tzis.First(x => x.Id == "Cape Verde Standard Time");
            _CaucasusStandardTime = tzis.First(x => x.Id == "Caucasus Standard Time");
            _CenAustraliaStandardTime = tzis.First(x => x.Id == "Cen. Australia Standard Time");
            _CentralAmericaStandardTime = tzis.First(x => x.Id == "Central America Standard Time");
            _CentralAsiaStandardTime = tzis.First(x => x.Id == "Central Asia Standard Time");
            _CentralBrazilianStandardTime = tzis.First(x => x.Id == "Central Brazilian Standard Time");
            _CentralEuropeStandardTime = tzis.First(x => x.Id == "Central Europe Standard Time");
            _CentralEuropeanStandardTime = tzis.First(x => x.Id == "Central European Standard Time");
            _CentralPacificStandardTime = tzis.First(x => x.Id == "Central Pacific Standard Time");
            _CentralStandardTime = tzis.First(x => x.Id == "Central Standard Time");
            _CentralStandardTimeInMexico = tzis.First(x => x.Id == "Central Standard Time (Mexico)");
            _ChathamIslandsStandardTime = tzis.First(x => x.Id == "Chatham Islands Standard Time");
            _ChinaStandardTime = tzis.First(x => x.Id == "China Standard Time");
            _CubaStandardTime = tzis.First(x => x.Id == "Cuba Standard Time");
            _DatelineStandardTime = tzis.First(x => x.Id == "Dateline Standard Time");
            _EAfricaStandardTime = tzis.First(x => x.Id == "E. Africa Standard Time");
            _EAustraliaStandardTime = tzis.First(x => x.Id == "E. Australia Standard Time");
            _EEuropeStandardTime = tzis.First(x => x.Id == "E. Europe Standard Time");
            _ESouthAmericaStandardTime = tzis.First(x => x.Id == "E. South America Standard Time");
            _EasterIslandStandardTime = tzis.First(x => x.Id == "Easter Island Standard Time");
            _EasternStandardTime = tzis.First(x => x.Id == "Eastern Standard Time");
            _EasternStandardTimeInMexico = tzis.First(x => x.Id == "Eastern Standard Time (Mexico)");
            _EgyptStandardTime = tzis.First(x => x.Id == "Egypt Standard Time");
            _EkaterinburgStandardTime = tzis.First(x => x.Id == "Ekaterinburg Standard Time");
            _FijiStandardTime = tzis.First(x => x.Id == "Fiji Standard Time");
            _FLEStandardTime = tzis.First(x => x.Id == "FLE Standard Time");
            _GeorgianStandardTime = tzis.First(x => x.Id == "Georgian Standard Time");
            _GMTStandardTime = tzis.First(x => x.Id == "GMT Standard Time");
            _GreenlandStandardTime = tzis.First(x => x.Id == "Greenland Standard Time");
            _GreenwichStandardTime = tzis.First(x => x.Id == "Greenwich Standard Time");
            _GTBStandardTime = tzis.First(x => x.Id == "GTB Standard Time");
            _HaitiStandardTime = tzis.First(x => x.Id == "Haiti Standard Time");
            _HawaiianStandardTime = tzis.First(x => x.Id == "Hawaiian Standard Time");
            _IndiaStandardTime = tzis.First(x => x.Id == "India Standard Time");
            _IranStandardTime = tzis.First(x => x.Id == "Iran Standard Time");
            _IsraelStandardTime = tzis.First(x => x.Id == "Israel Standard Time");
            _JordanStandardTime = tzis.First(x => x.Id == "Jordan Standard Time");
            _KaliningradStandardTime = tzis.First(x => x.Id == "Kaliningrad Standard Time");
            _KamchatkaStandardTime = tzis.First(x => x.Id == "Kamchatka Standard Time");
            _KoreaStandardTime = tzis.First(x => x.Id == "Korea Standard Time");
            _LibyaStandardTime = tzis.First(x => x.Id == "Libya Standard Time");
            _LineIslandsStandardTime = tzis.First(x => x.Id == "Line Islands Standard Time");
            _LordHoweStandardTime = tzis.First(x => x.Id == "Lord Howe Standard Time");
            _MagadanStandardTime = tzis.First(x => x.Id == "Magadan Standard Time");
            _MarquesasStandardTime = tzis.First(x => x.Id == "Marquesas Standard Time");
            _MauritiusStandardTime = tzis.First(x => x.Id == "Mauritius Standard Time");
            _MidMinusAtlanticStandardTime = tzis.First(x => x.Id == "Mid-Atlantic Standard Time");
            _MiddleEastStandardTime = tzis.First(x => x.Id == "Middle East Standard Time");
            _MontevideoStandardTime = tzis.First(x => x.Id == "Montevideo Standard Time");
            _MoroccoStandardTime = tzis.First(x => x.Id == "Morocco Standard Time");
            _MountainStandardTime = tzis.First(x => x.Id == "Mountain Standard Time");
            _MountainStandardTimeInMexico = tzis.First(x => x.Id == "Mountain Standard Time (Mexico)");
            _MyanmarStandardTime = tzis.First(x => x.Id == "Myanmar Standard Time");
            _NCentralAsiaStandardTime = tzis.First(x => x.Id == "N. Central Asia Standard Time");
            _NamibiaStandardTime = tzis.First(x => x.Id == "Namibia Standard Time");
            _NepalStandardTime = tzis.First(x => x.Id == "Nepal Standard Time");
            _NewZealandStandardTime = tzis.First(x => x.Id == "New Zealand Standard Time");
            _NewfoundlandStandardTime = tzis.First(x => x.Id == "Newfoundland Standard Time");
            _NorfolkStandardTime = tzis.First(x => x.Id == "Norfolk Standard Time");
            _NorthAsiaEastStandardTime = tzis.First(x => x.Id == "North Asia East Standard Time");
            _NorthAsiaStandardTime = tzis.First(x => x.Id == "North Asia Standard Time");
            _NorthKoreaStandardTime = tzis.First(x => x.Id == "North Korea Standard Time");
            _OmskStandardTime = tzis.First(x => x.Id == "Omsk Standard Time");
            _PacificSAStandardTime = tzis.First(x => x.Id == "Pacific SA Standard Time");
            _PacificStandardTime = tzis.First(x => x.Id == "Pacific Standard Time");
            _PacificStandardTimeInMexico = tzis.First(x => x.Id == "Pacific Standard Time (Mexico)");
            _PakistanStandardTime = tzis.First(x => x.Id == "Pakistan Standard Time");
            _ParaguayStandardTime = tzis.First(x => x.Id == "Paraguay Standard Time");
            _RomanceStandardTime = tzis.First(x => x.Id == "Romance Standard Time");
            _RussiaTimeZone10 = tzis.First(x => x.Id == "Russia Time Zone 10");
            _RussiaTimeZone11 = tzis.First(x => x.Id == "Russia Time Zone 11");
            _RussiaTimeZone3 = tzis.First(x => x.Id == "Russia Time Zone 3");
            _RussianStandardTime = tzis.First(x => x.Id == "Russian Standard Time");
            _SAEasternStandardTime = tzis.First(x => x.Id == "SA Eastern Standard Time");
            _SAPacificStandardTime = tzis.First(x => x.Id == "SA Pacific Standard Time");
            _SAWesternStandardTime = tzis.First(x => x.Id == "SA Western Standard Time");
            _SaintPierreStandardTime = tzis.First(x => x.Id == "Saint Pierre Standard Time");
            _SakhalinStandardTime = tzis.First(x => x.Id == "Sakhalin Standard Time");
            _SamoaStandardTime = tzis.First(x => x.Id == "Samoa Standard Time");
            _SEAsiaStandardTime = tzis.First(x => x.Id == "SE Asia Standard Time");
            _SingaporeStandardTime = tzis.First(x => x.Id == "Singapore Standard Time");
            _SouthAfricaStandardTime = tzis.First(x => x.Id == "South Africa Standard Time");
            _SriLankaStandardTime = tzis.First(x => x.Id == "Sri Lanka Standard Time");
            _SyriaStandardTime = tzis.First(x => x.Id == "Syria Standard Time");
            _TaipeiStandardTime = tzis.First(x => x.Id == "Taipei Standard Time");
            _TasmaniaStandardTime = tzis.First(x => x.Id == "Tasmania Standard Time");
            _TocantinsStandardTime = tzis.First(x => x.Id == "Tocantins Standard Time");
            _TokyoStandardTime = tzis.First(x => x.Id == "Tokyo Standard Time");
            _TomskStandardTime = tzis.First(x => x.Id == "Tomsk Standard Time");
            _TongaStandardTime = tzis.First(x => x.Id == "Tonga Standard Time");
            _TransbaikalStandardTime = tzis.First(x => x.Id == "Transbaikal Standard Time");
            _TurkeyStandardTime = tzis.First(x => x.Id == "Turkey Standard Time");
            _TurksAndCaicosStandardTime = tzis.First(x => x.Id == "Turks And Caicos Standard Time");
            _UlaanbaatarStandardTime = tzis.First(x => x.Id == "Ulaanbaatar Standard Time");
            _USEasternStandardTime = tzis.First(x => x.Id == "US Eastern Standard Time");
            _USMountainStandardTime = tzis.First(x => x.Id == "US Mountain Standard Time");
            _UTC = tzis.First(x => x.Id == "UTC");
            _UTCPlus12 = tzis.First(x => x.Id == "UTC+12");
            _UTCMinus02 = tzis.First(x => x.Id == "UTC-02");
            _UTCMinus08 = tzis.First(x => x.Id == "UTC-08");
            _UTCMinus09 = tzis.First(x => x.Id == "UTC-09");
            _UTCMinus11 = tzis.First(x => x.Id == "UTC-11");
            _VenezuelaStandardTime = tzis.First(x => x.Id == "Venezuela Standard Time");
            _VladivostokStandardTime = tzis.First(x => x.Id == "Vladivostok Standard Time");
            _WAustraliaStandardTime = tzis.First(x => x.Id == "W. Australia Standard Time");
            _WCentralAfricaStandardTime = tzis.First(x => x.Id == "W. Central Africa Standard Time");
            _WEuropeStandardTime = tzis.First(x => x.Id == "W. Europe Standard Time");
            _WMongoliaStandardTime = tzis.First(x => x.Id == "W. Mongolia Standard Time");
            _WestAsiaStandardTime = tzis.First(x => x.Id == "West Asia Standard Time");
            _WestBankStandardTime = tzis.First(x => x.Id == "West Bank Standard Time");
            _WestPacificStandardTime = tzis.First(x => x.Id == "West Pacific Standard Time");
            _YakutskStandardTime = tzis.First(x => x.Id == "Yakutsk Standard Time");
        }
    }
}