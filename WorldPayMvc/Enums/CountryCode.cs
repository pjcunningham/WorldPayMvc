using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WorldPayMvc {
    public enum CountryCode {
        [Description("AFGHANISTAN")]
        AF,
        [Description("ÅLAND ISLANDS")]
        AX,
        [Description("ALBANIA")]
        AL,
        [Description("ALGERIA")]
        DZ,
        [Description("AMERICAN SAMOA")]
        AS,
        [Description("ANDORRA")]
        AD,
        [Description("ANGOLA")]
        AO,
        [Description("ANGUILLA")]
        AI,
        [Description("ANTARCTICA")]
        AQ,
        [Description("ANTIGUA AND BARBUDA")]
        AG,
        [Description("ARGENTINA")]
        AR,
        [Description("ARMENIA")]
        AM,
        [Description("ARUBA")]
        AW,
        [Description("AUSTRALIA")]
        AU,
        [Description("AUSTRIA")]
        AT,
        [Description("AZERBAIJAN")]
        AZ,
        [Description("BAHAMAS")]
        BS,
        [Description("BAHRAIN")]
        BH,
        [Description("BANGLADESH")]
        BD,
        [Description("BARBADOS")]
        BB,
        [Description("BELARUS")]
        BY,
        [Description("BELGIUM")]
        BE,
        [Description("BELIZE")]
        BZ,
        [Description("BENIN")]
        BJ,
        [Description("BERMUDA")]
        BM,
        [Description("BHUTAN")]
        BT,
        [Description("BOLIVIA")]
        BO,
        [Description("BOSNIA AND HERZEGOVINA")]
        BA,
        [Description("BOTSWANA")]
        BW,
        [Description("BOUVET ISLAND")]
        BV,
        [Description("BRAZIL")]
        BR,
        [Description("BRITISH INDIAN OCEAN TERRITORY")]
        IO,
        [Description("BRUNEI DARUSSALAM")]
        BN,
        [Description("BULGARIA")]
        BG,
        [Description("BURKINA FASO")]
        BF,
        [Description("BURUNDI")]
        BI,
        [Description("CAMBODIA")]
        KH,
        [Description("CAMEROON")]
        CM,
        [Description("CANADA")]
        CA,
        [Description("CAPE VERDE")]
        CV,
        [Description("CAYMAN ISLANDS")]
        KY,
        [Description("CENTRAL AFRICAN REPUBLIC")]
        CF,
        [Description("CHAD")]
        TD,
        [Description("CHILE")]
        CL,
        [Description("CHINA")]
        CN,
        [Description("CHRISTMAS ISLAND")]
        CX,
        [Description("COCOS (KEELING) ISLANDS")]
        CC,
        [Description("COLOMBIA")]
        CO,
        [Description("COMOROS")]
        KM,
        [Description("CONGO")]
        CG,
        [Description("CONGO, THE DEMOCRATIC REPUBLIC OF THE")]
        CD,
        [Description("COOK ISLANDS")]
        CK,
        [Description("COSTA RICA")]
        CR,
        [Description("CÔTE D'IVOIRE")]
        CI,
        [Description("CROATIA")]
        HR,
        [Description("CUBA")]
        CU,
        [Description("CYPRUS")]
        CY,
        [Description("CZECH REPUBLIC")]
        CZ,
        [Description("DENMARK")]
        DK,
        [Description("DJIBOUTI")]
        DJ,
        [Description("DOMINICA")]
        DM,
        [Description("DOMINICAN REPUBLIC")]
        DO,
        [Description("ECUADOR")]
        EC,
        [Description("EGYPT")]
        EG,
        [Description("EL SALVADOR")]
        SV,
        [Description("EQUATORIAL GUINEA")]
        GQ,
        [Description("ERITREA")]
        ER,
        [Description("ESTONIA")]
        EE,
        [Description("ETHIOPIA")]
        ET,
        [Description("FALKLAND ISLANDS (MALVINAS)")]
        FK,
        [Description("FAROE ISLANDS")]
        FO,
        [Description("FIJI")]
        FJ,
        [Description("FINLAND")]
        FI,
        [Description("FRANCE")]
        FR,
        [Description("FRENCH GUIANA")]
        GF,
        [Description("FRENCH POLYNESIA")]
        PF,
        [Description("FRENCH SOUTHERN TERRITORIES")]
        TF,
        [Description("GABON")]
        GA,
        [Description("GAMBIA")]
        GM,
        [Description("GEORGIA")]
        GE,
        [Description("GERMANY")]
        DE,
        [Description("GHANA")]
        GH,
        [Description("GIBRALTAR")]
        GI,
        [Description("GREECE")]
        GR,
        [Description("GREENLAND")]
        GL,
        [Description("GRENADA")]
        GD,
        [Description("GUADELOUPE")]
        GP,
        [Description("GUAM")]
        GU,
        [Description("GUATEMALA")]
        GT,
        [Description("GUINEA")]
        GN,
        [Description("GUINEA-BISSAU")]
        GW,
        [Description("GUYANA")]
        GY,
        [Description("HAITI")]
        HT,
        [Description("HEARD ISLAND AND MCDONALD ISLANDS")]
        HM,
        [Description("HOLY SEE (VATICAN CITY STATE)")]
        VA,
        [Description("HONDURAS")]
        HN,
        [Description("HONG KONG")]
        HK,
        [Description("HUNGARY")]
        HU,
        [Description("ICELAND")]
        IS,
        [Description("INDIA")]
        IN,
        [Description("INDONESIA")]
        ID,
        [Description("IRAN, ISLAMIC REPUBLIC OF")]
        IR,
        [Description("IRAQ")]
        IQ,
        [Description("IRELAND")]
        IE,
        [Description("ISRAEL")]
        IL,
        [Description("ITALY")]
        IT,
        [Description("JAMAICA")]
        JM,
        [Description("JAPAN")]
        JP,
        [Description("JORDAN")]
        JO,
        [Description("KAZAKHSTAN")]
        KZ,
        [Description("KENYA")]
        KE,
        [Description("KIRIBATI")]
        KI,
        [Description("KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF")]
        KP,
        [Description("KOREA, REPUBLIC OF")]
        KR,
        [Description("KUWAIT")]
        KW,
        [Description("KYRGYZSTAN")]
        KG,
        [Description("LAO PEOPLE'S DEMOCRATIC REPUBLIC")]
        LA,
        [Description("LATVIA")]
        LV,
        [Description("LEBANON")]
        LB,
        [Description("LESOTHO")]
        LS,
        [Description("LIBERIA")]
        LR,
        [Description("LIBYAN ARAB JAMAHIRIYA")]
        LY,
        [Description("LIECHTENSTEIN")]
        LI,
        [Description("LITHUANIA")]
        LT,
        [Description("LUXEMBOURG")]
        LU,
        [Description("MACAO")]
        MO,
        [Description("MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF")]
        MK,
        [Description("MADAGASCAR")]
        MG,
        [Description("MALAWI")]
        MW,
        [Description("MALAYSIA")]
        MY,
        [Description("MALDIVES")]
        MV,
        [Description("MALI")]
        ML,
        [Description("MALTA")]
        MT,
        [Description("MARSHALL ISLANDS")]
        MH,
        [Description("MARTINIQUE")]
        MQ,
        [Description("MAURITANIA")]
        MR,
        [Description("MAURITIUS")]
        MU,
        [Description("MAYOTTE")]
        YT,
        [Description("MEXICO")]
        MX,
        [Description("MICRONESIA, FEDERATED STATES OF")]
        FM,
        [Description("MOLDOVA, REPUBLIC OF")]
        MD,
        [Description("MONACO")]
        MC,
        [Description("MONGOLIA")]
        MN,
        [Description("MONTSERRAT")]
        MS,
        [Description("MOROCCO")]
        MA,
        [Description("MOZAMBIQUE")]
        MZ,
        [Description("MYANMAR")]
        MM,
        [Description("NAMIBIA")]
        NA,
        [Description("NAURU")]
        NR,
        [Description("NEPAL")]
        NP,
        [Description("NETHERLANDS")]
        NL,
        [Description("NETHERLANDS ANTILLES")]
        AN,
        [Description("NEW CALEDONIA")]
        NC,
        [Description("NEW ZEALAND")]
        NZ,
        [Description("NICARAGUA")]
        NI,
        [Description("NIGER")]
        NE,
        [Description("NIGERIA")]
        NG,
        [Description("NIUE")]
        NU,
        [Description("NORFOLK ISLAND")]
        NF,
        [Description("NORTHERN MARIANA ISLANDS")]
        MP,
        [Description("NORWAY")]
        NO,
        [Description("OMAN")]
        OM,
        [Description("PAKISTAN")]
        PK,
        [Description("PALAU")]
        PW,
        [Description("PALESTINIAN TERRITORY, OCCUPIED")]
        PS,
        [Description("PANAMA")]
        PA,
        [Description("PAPUA NEW GUINEA")]
        PG,
        [Description("PARAGUAY")]
        PY,
        [Description("PERU")]
        PE,
        [Description("PHILIPPINES")]
        PH,
        [Description("PITCAIRN")]
        PN,
        [Description("POLAND")]
        PL,
        [Description("PORTUGAL")]
        PT,
        [Description("PUERTO RICO")]
        PR,
        [Description("QATAR")]
        QA,
        [Description("RÉUNION")]
        RE,
        [Description("ROMANIA")]
        RO,
        [Description("RUSSIAN FEDERATION")]
        RU,
        [Description("RWANDA")]
        RW,
        [Description("SAINT HELENA")]
        SH,
        [Description("SAINT KITTS AND NEVIS")]
        KN,
        [Description("SAINT LUCIA")]
        LC,
        [Description("SAINT PIERRE AND MIQUELON")]
        PM,
        [Description("SAINT VINCENT AND THE GRENADINES")]
        VC,
        [Description("SAMOA")]
        WS,
        [Description("SAN MARINO")]
        SM,
        [Description("SAO TOME AND PRINCIPE")]
        ST,
        [Description("SAUDI ARABIA")]
        SA,
        [Description("SENEGAL")]
        SN,
        [Description("SERBIA AND MONTENEGRO")]
        CS,
        [Description("SEYCHELLES")]
        SC,
        [Description("SIERRA LEONE")]
        SL,
        [Description("SINGAPORE")]
        SG,
        [Description("SLOVAKIA")]
        SK,
        [Description("SLOVENIA")]
        SI,
        [Description("SOLOMON ISLANDS")]
        SB,
        [Description("SOMALIA")]
        SO,
        [Description("SOUTH AFRICA")]
        ZA,
        [Description("SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS")]
        GS,
        [Description("SPAIN")]
        ES,
        [Description("SRI LANKA")]
        LK,
        [Description("SUDAN")]
        SD,
        [Description("SURINAME")]
        SR,
        [Description("SVALBARD AND JAN MAYEN")]
        SJ,
        [Description("SWAZILAND")]
        SZ,
        [Description("SWEDEN")]
        SE,
        [Description("SWITZERLAND")]
        CH,
        [Description("SYRIAN ARAB REPUBLIC")]
        SY,
        [Description("TAIWAN, PROVINCE OF CHINA")]
        TW,
        [Description("TAJIKISTAN")]
        TJ,
        [Description("TANZANIA, UNITED REPUBLIC OF")]
        TZ,
        [Description("THAILAND")]
        TH,
        [Description("TIMOR-LESTE")]
        TL,
        [Description("TOGO")]
        TG,
        [Description("TOKELAU")]
        TK,
        [Description("TONGA")]
        TO,
        [Description("TRINIDAD AND TOBAGO")]
        TT,
        [Description("TUNISIA")]
        TN,
        [Description("TURKEY")]
        TR,
        [Description("TURKMENISTAN")]
        TM,
        [Description("TURKS AND CAICOS ISLANDS")]
        TC,
        [Description("TUVALU")]
        TV,
        [Description("UGANDA")]
        UG,
        [Description("UKRAINE")]
        UA,
        [Description("UNITED ARAB EMIRATES")]
        AE,
        [Description("UNITED KINGDOM")]
        GB,
        [Description("UNITED STATES")]
        US,
        [Description("UNITED STATES MINOR OUTLYING ISLANDS")]
        UM,
        [Description("URUGUAY")]
        UY,
        [Description("UZBEKISTAN")]
        UZ,
        [Description("VANUATU")]
        VU,
        [Description("VENEZUELA")]
        VE,
        [Description("VIET NAM")]
        VN,
        [Description("VIRGIN ISLANDS, BRITISH")]
        VG,
        [Description("VIRGIN ISLANDS, U.S.")]
        VI,
        [Description("WALLIS AND FUTUNA")]
        WF,
        [Description("WESTERN SAHARA")]
        EH,
        [Description("YEMEN")]
        YE,
        [Description("ZAMBIA")]
        ZM,

    }
}
