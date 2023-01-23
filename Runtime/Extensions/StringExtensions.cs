using System.Text.RegularExpressions;
using System;
using System.Globalization;
using UnityEngine;

namespace Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);
        public static bool NotNullOrEmpty(this string str) => !string.IsNullOrEmpty(str);
        
        /// <summary>
        /// "CamelCaseString" => "Camel Case String"
        /// </summary>
        public static string SplitCamelCase(this string camelCaseString)
        {
            if (string.IsNullOrEmpty(camelCaseString)) return camelCaseString;

            string camelCase = Regex.Replace(Regex.Replace(camelCaseString, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), @"(\p{Ll})(\P{Ll})", "$1 $2");
            string firstLetter = camelCase.Substring(0, 1).ToUpper();

            if (camelCaseString.Length > 1)
            {
                string rest = camelCase.Substring(1);

                return firstLetter + rest;
            }

            return firstLetter;
        }
    }
}