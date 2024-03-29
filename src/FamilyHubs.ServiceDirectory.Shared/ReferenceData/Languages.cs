﻿using System.Collections.ObjectModel;

namespace FamilyHubs.ServiceDirectory.Shared.ReferenceData;
// the international OR standard doesn't have a languages table with a language id
// that services and locations can refer to, instead it has a languages table
// with (optional) foreign keys to service or location, which means we're responsible
// for ensuring language codes and names are consistent (and languages will be repeated)!
// we _could_ still store the canonical languages in the db though

public static class Languages
{
    public static readonly ReadOnlyCollection<string> FilterCodes
        = new(new List<string>
        {
            "af", "sq", "ar", "hy", "eu", "bn", "bg", "ca", "km", "zh",
            "hr", "cs", "da", "nl", "en", "et", "fj", "fi", "fr", "ka",
            "de", "el", "gu", "he", "hi", "hu", "is", "id", "ga", "it",
            "ja", "jv", "ko", "la", "lv", "lt", "mk", "ms", "ml", "mt",
            "mi", "mr", "mn", "ne", "no", "fa", "pl", "pt", "pa", "qu",
            "ro", "ru", "sm", "sr", "sk", "sl", "so", "es", "sw", "sv",
            "ta", "tt", "te", "th", "bo", "to", "tr", "uk", "ur", "uz",
            "vi", "cy", "xh"
        });

    // list taken from https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes#References
    public static readonly IReadOnlyDictionary<string, string> CodeToName
        = new ReadOnlyDictionary<string, string>(new Dictionary<string, string> {
            { "ab", "Abkhazian" },
            { "aa", "Afar" },
            { "af", "Afrikaans" },
            { "ak", "Akan" },
            { "sq", "Albanian" },
            { "am", "Amharic" },
            { "ar", "Arabic" },
            { "an", "Aragonese" },
            { "hy", "Armenian" },
            { "as", "Assamese" },
            { "av", "Avaric" },
            { "ae", "Avestan" },
            { "ay", "Aymara" },
            { "az", "Azerbaijani" },
            { "bm", "Bambara" },
            { "ba", "Bashkir" },
            { "eu", "Basque" },
            { "be", "Belarusian" },
            { "bn", "Bengali" },
            { "bi", "Bislama" },
            { "bs", "Bosnian" },
            { "br", "Breton" },
            { "bg", "Bulgarian" },
            { "my", "Burmese" },
            { "ca", "Catalan; Valencian" },
            { "km", "Central Khmer" },
            { "ch", "Chamorro" },
            { "ce", "Chechen" },
            { "ny", "Chichewa; Chewa; Nyanja" },
            { "zh", "Chinese" },
            { "cu", "Church Slavic; Old Slavonic; Old Church Slavonic" },
            { "cv", "Chuvash" },
            { "kw", "Cornish" },
            { "co", "Corsican" },
            { "cr", "Cree" },
            { "hr", "Croatian" },
            { "cs", "Czech" },
            { "da", "Danish" },
            { "dv", "Divehi; Dhivehi; Maldivian" },
            { "nl", "Dutch; Flemish" },
            { "dz", "Dzongkha" },
            { "en", "English" },
            { "eo", "Esperanto" },
            { "et", "Estonian" },
            { "ee", "Ewe" },
            { "fo", "Faroese" },
            { "fj", "Fijian" },
            { "fi", "Finnish" },
            { "fr", "French" },
            { "ff", "Fulah" },
            { "gd", "Gaelic; Scottish Gaelic" },
            { "gl", "Galician" },
            { "lg", "Ganda" },
            { "ka", "Georgian" },
            { "de", "German" },
            { "el", "Greek" }, // Greek, Modern (1453-)
            { "gn", "Guarani" },
            { "gu", "Gujarati" },
            { "ht", "Haitian; Haitian Creole" },
            { "ha", "Hausa" },
            { "he", "Hebrew" },
            { "hz", "Herero" },
            { "hi", "Hindi" },
            { "ho", "Hiri Motu" },
            { "hu", "Hungarian" },
            { "is", "Icelandic" },
            { "io", "Ido" },
            { "ig", "Igbo" },
            { "id", "Indonesian" },
            { "ia", "Interlingua" }, // Interlingua (International Auxiliary Language Association)
            { "ie", "Interlingue; Occidental" },
            { "iu", "Inuktitut" },
            { "ik", "Inupiaq" },
            { "ga", "Irish" },
            { "it", "Italian" },
            { "ja", "Japanese" },
            { "jv", "Javanese" },
            { "kl", "Kalaallisut; Greenlandic" },
            { "kn", "Kannada" },
            { "kr", "Kanuri" },
            { "ks", "Kashmiri" },
            { "kk", "Kazakh" },
            { "ki", "Kikuyu; Gikuyu" },
            { "rw", "Kinyarwanda" },
            { "ky", "Kirghiz; Kyrgyz" },
            { "kv", "Komi" },
            { "kg", "Kongo" },
            { "ko", "Korean" },
            { "kj", "Kuanyama; Kwanyama" },
            { "ku", "Kurdish" },
            { "lo", "Lao" },
            { "la", "Latin" },
            { "lv", "Latvian" },
            { "li", "Limburgan; Limburger; Limburgish" },
            { "ln", "Lingala" },
            { "lt", "Lithuanian" },
            { "lu", "Luba-Katanga" },
            { "lb", "Luxembourgish; Letzeburgesch" },
            { "mk", "Macedonian" },
            { "mg", "Malagasy" },
            { "ms", "Malay" },
            { "ml", "Malayalam" },
            { "mt", "Maltese" },
            { "gv", "Manx" },
            { "mi", "Maori" },
            { "mr", "Marathi" },
            { "mh", "Marshallese" },
            { "mn", "Mongolian" },
            { "na", "Nauru" },
            { "nv", "Navajo; Navaho" },
            { "ng", "Ndonga" },
            { "ne", "Nepali" },
            { "nd", "North Ndebele" },
            { "se", "Northern Sami" },
            { "no", "Norwegian" },
            { "nb", "Norwegian Bokmål" },
            { "nn", "Norwegian Nynorsk" },
            { "oc", "Occitan" },
            { "oj", "Ojibwa" },
            { "or", "Oriya" },
            { "om", "Oromo" },
            { "os", "Ossetian; Ossetic" },
            { "pi", "Pali" },
            { "ps", "Pashto; Pushto" },
            { "fa", "Persian" },
            { "pl", "Polish" },
            { "pt", "Portuguese" },
            { "pa", "Punjabi; Panjabi" },
            { "qu", "Quechua" },
            { "ro", "Romanian; Moldavian; Moldovan" },
            { "rm", "Romansh" },
            { "rn", "Rundi" },
            { "ru", "Russian" },
            { "sm", "Samoan" },
            { "sg", "Sango" },
            { "sa", "Sanskrit" },
            { "sc", "Sardinian" },
            { "sr", "Serbian" },
            { "sn", "Shona" },
            { "ii", "Sichuan Yi; Nuosu" },
            { "sd", "Sindhi" },
            { "si", "Sinhala; Sinhalese" },
            { "sk", "Slovak" },
            { "sl", "Slovenian" },
            { "so", "Somali" },
            { "nr", "South Ndebele" },
            { "st", "Southern Sotho" },
            { "es", "Spanish; Castilian" },
            { "su", "Sundanese" },
            { "sw", "Swahili" },
            { "ss", "Swati" },
            { "sv", "Swedish" },
            { "tl", "Tagalog" },
            { "ty", "Tahitian" },
            { "tg", "Tajik" },
            { "ta", "Tamil" },
            { "tt", "Tatar" },
            { "te", "Telugu" },
            { "th", "Thai" },
            { "bo", "Tibetan" },
            { "ti", "Tigrinya" },
            { "to", "Tonga (Tonga Islands)" },
            { "ts", "Tsonga" },
            { "tn", "Tswana" },
            { "tr", "Turkish" },
            { "tk", "Turkmen" },
            { "tw", "Twi" },
            { "ug", "Uighur; Uyghur" },
            { "uk", "Ukrainian" },
            { "ur", "Urdu" },
            { "uz", "Uzbek" },
            { "ve", "Venda" },
            { "vi", "Vietnamese" },
            { "vo", "Volapük" },
            { "wa", "Walloon" },
            { "cy", "Welsh" },
            { "fy", "Western Frisian" },
            { "wo", "Wolof" },
            { "xh", "Xhosa" },
            { "yi", "Yiddish" },
            { "yo", "Yoruba" },
            { "za", "Zhuang; Chuang" },
            { "zu", "Zulu" }
        });

    public static readonly IReadOnlyDictionary<string, string> NameToCode
        = new ReadOnlyDictionary<string, string>(CodeToName.ToDictionary(kvp => kvp.Value, kvp => kvp.Key));
}