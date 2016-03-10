/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 07.03.2016
 * Time: 18:35
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace GameUI
{
    /// <summary>
    /// Description of ProgramData.
    /// </summary>
    public class ProgramData
    {
        public static string PlayerName;
        public static string RatingFilePath = (Directory.GetCurrentDirectory() + @"\data\records\");
        public static string RatingFileFullPath = RatingFilePath + "top.csv";
        public static Dictionary<string, int> Rating;

    }
}
