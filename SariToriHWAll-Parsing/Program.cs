using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpssLib.SpssDataset;
using SpssLib.DataReader;
using System.IO;

namespace SariToriHWAll_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int SurveyID = 600612;
            //string SurveyPeriod = "2014-09-30";//survey period
            string AttendedOn = "2018-09-30";
            //string year = getYear(SurveyPeriod); 
            string country = "Indonesia";//survey country
            DB_insertion_SariRotiHWAll iobj = new DB_insertion_SariRotiHWAll();
            string questions = "id,weight,S9,S8,S2,B1,B2_1,B2_2,B2_3,B2_4,B2_5,B2_6,B2_7,B2_8,B2_9,B2_10,B2_11,B2_12,B2_13,B2_14,B2_15,B2_16,B2_17,B2_18,B2_19,B2_20,B2_21,B2_22,B2_23,B2_24,B4a,B5_1,B5_2,B5_3,B5_4,B5_5,B5_6,B5_7,B5_8,B5_9,B5_10,B5_11,B5_12,B5_13,B5_14,B5_15,B5_16,B5_17,B5_18,B5_19,B5_20,B5_21,B5_22,B5_23,B5_24,B5b_1,B5b_2,B5b_3,B5b_4,B5b_5,B5b_6,B5b_7,B10,B3,B8_1,B8_2,B8_3,B8_4,B8_5,B8_6,B8_7,B8_8,B8_9,B8_10,B8_11,B8_12,B8_13,B8_14,B8_15,B8_16,B8_17,B8_18,B8_19,B8_20,B8_21,B8_22,B8_23,B8_24,B7_1,B7_2,B7_3,B7_4,B7_5,B7_6,B7_7,B7_8,B7_9,B7_10,B7_11,B7_12,B7_13,B7_14,B7_15,B7_16,B7_17,B7_18,B7_19,B7_20,B7_21,B7_22,B7_23,B7_24,B6_1,B6_2,B6_3,B6_4,B6_5,B6_6,B6_7,B6_8,B6_9,B6_10,B6_11,B6_12,B6_13,B6_14,B6_15,B6_16,B6_17,B6_18,B6_19,B6_20,B6_21,B6_22,B6_23,B6_24,B38,B39,B40_1,B40_2,B40_3,B40_4,B41b_1,B41b_2,B41b_3,B41b_4,B42_1,B42_2,B43a_1,B43a_2,P1,P2_1,P2_2,P2_3,P2_4,P2_5,P2_6,P2_7,P2_8,P2_9,P2_10,P3,C4_1,C4_2,C4_3,C4_4,C4_5,C4_6,C4_7,C3_1,C3_2,C3_3,C3_4,C3_5,C3_6,C3_7,C2_1,C2_2,C2_3,C2_4,C2_5,C2_6,C2_7,C1_1,C1_2,C1_3,C1_4,C1_5,C1_6,C1_7,NETT_SR_User,NETT_Non_SR_User";// dashboard variable value   
            //string questions = "NETT_SR_User,NETT_Non_SR_User";
            string[] spss_variable_name = questions.Split(',');
            SpssReader spssDataset;
            using (FileStream fileStream = new FileStream(@"D:\spssparsing\SariRoriHW\All\SR_HW_ALL-final recoded and weighted-sep18 (S16=yes).sav", FileMode.Open, FileAccess.Read, FileShare.Read, 2048 * 10, FileOptions.SequentialScan))
            {
                spssDataset = new SpssReader(fileStream); // Create the reader, this will read the file header
                foreach (string spss_v in spss_variable_name)
                {
                    foreach (var variable in spssDataset.Variables)  // Iterate through all the varaibles
                    {
                        if (variable.Name.Equals(spss_v))
                        {
                            foreach (KeyValuePair<double, string> label in variable.ValueLabels)
                            {
                                string VARIABLE_NAME = spss_v;
                                string VARIABLE_NAME_SUB_NAME = variable.Name;
                                string VARIABLE_ID = label.Key.ToString();
                                string VARIABLE_VALUE = label.Value;
                                string VARIABLE_NAME_QUESTION = variable.Label;
                                string BASE_VARIABLE_NAME = variable.Name;
                                //iobj.insert_Dashboard_variable_values(VARIABLE_NAME, VARIABLE_NAME_SUB_NAME, VARIABLE_ID, VARIABLE_VALUE, VARIABLE_NAME_QUESTION, SurveyID, country, BASE_VARIABLE_NAME, AttendedOn);
                            }
                        }

                    }
                }
                foreach (var record in spssDataset.Records)
                {
                    string userID = null;
                    string u_id = null;
                    string variable_name;
                    decimal Weight = 0;
                    string Country = "-- Not Available --";
                    string Region = "-- Not Available --";               
                    string AgeGroup = "-- Not Available --";
                    string SES = "-- Not Available --";
                    string BrTom= "-- Not Available --";
                    string BrSpontArnon= "-- Not Available --";
                    string BrSpontAroma= "-- Not Available --";
                    string BrSpontBima= "-- Not Available --";
                    string BrSpontBread_Talk= "-- Not Available --";
                    string BrSpontBread_Co= "-- Not Available --";
                    string BrSpontGarmelia= "-- Not Available --";
                    string BrSpontHolland_Bakery= "-- Not Available --";
                    string BrSpontLauw= "-- Not Available --";
                    string BrSpontLe_Gitt= "-- Not Available --";
                    string BrSpontMatahari= "-- Not Available --";
                    string BrSpontMaxim= "-- Not Available --";
                    string BrSpontMr_Bread= "-- Not Available --";
                    string BrSpontMy_Roti= "-- Not Available --";
                    string BrSpontParoti= "-- Not Available --";
                    string BrSpontPrime_Bread= "-- Not Available --";
                    string BrSpontRamona= "-- Not Available --";
                    string BrSpontRoti_Boy= "-- Not Available --";
                    string BrSpontRoti_O= "-- Not Available --";
                    string BrSpontSari_Roti= "-- Not Available --";
                    string BrSpontSay_Bread= "-- Not Available --";
                    string BrSpontSharon= "-- Not Available --";
                    string BrSpontSuzana= "-- Not Available --";
                    string BrSpontSwanish= "-- Not Available --";
                    string BrSpontVanessa= "-- Not Available --";
                    string AdTom= "-- Not Available --";
                    string AdSpontArnon= "-- Not Available --";
                    string AdSpontAroma= "-- Not Available --";
                    string AdSpontBima= "-- Not Available --";
                    string AdSpontAdead_Talk= "-- Not Available --";
                    string AdSpontAdead_Co= "-- Not Available --";
                    string AdSpontGarmelia= "-- Not Available --";
                    string AdSpontHolland_Bakery= "-- Not Available --";
                    string AdSpontLauw= "-- Not Available --";
                    string AdSpontLe_Gitt= "-- Not Available --";
                    string AdSpontMatahari= "-- Not Available --";
                    string AdSpontMaxim= "-- Not Available --";
                    string AdSpontMr_Adead= "-- Not Available --";
                    string AdSpontMy_Roti= "-- Not Available --";
                    string AdSpontParoti= "-- Not Available --";
                    string AdSpontPrime_Adead= "-- Not Available --";
                    string AdSpontRamona= "-- Not Available --";
                    string AdSpontRoti_Boy= "-- Not Available --";
                    string AdSpontRoti_O= "-- Not Available --";
                    string AdSpontSari_Roti= "-- Not Available --";
                    string AdSpontSay_Adead= "-- Not Available --";
                    string AdSpontSharon= "-- Not Available --";
                    string AdSpontSuzana= "-- Not Available --";
                    string AdSpontSwanish= "-- Not Available --";
                    string AdSpontVanessa= "-- Not Available --";
                    string B5b_1= "-- Not Available --";
                    string B5b_2= "-- Not Available --";
                    string B5b_3= "-- Not Available --";
                    string B5b_4= "-- Not Available --";
                    string B5b_5= "-- Not Available --";
                    string B5b_6= "-- Not Available --";
                    string B5b_7= "-- Not Available --";
                    string Bumo= "-- Not Available --";
                    string Favourite_Brand= "-- Not Available --";
                    string ConL1W_Arnon= "-- Not Available --";
                    string ConL1W_Aroma= "-- Not Available --";
                    string ConL1W_Bima= "-- Not Available --";
                    string ConL1W_Adead_Talk= "-- Not Available --";
                    string ConL1W_Adead_Co= "-- Not Available --";
                    string ConL1W_Garmelia= "-- Not Available --";
                    string ConL1W_Holland_Bakery= "-- Not Available --";
                    string ConL1W_Lauw= "-- Not Available --";
                    string ConL1W_Le_Gitt= "-- Not Available --";
                    string ConL1W_Matahari= "-- Not Available --";
                    string ConL1W_Maxim= "-- Not Available --";
                    string ConL1W_Mr_Adead= "-- Not Available --";
                    string ConL1W_My_Roti= "-- Not Available --";
                    string ConL1W_Paroti= "-- Not Available --";
                    string ConL1W_Prime_Adead= "-- Not Available --";
                    string ConL1W_Ramona= "-- Not Available --";
                    string ConL1W_Roti_Boy= "-- Not Available --";
                    string ConL1W_Roti_O= "-- Not Available --";
                    string ConL1W_Sari_Roti= "-- Not Available --";
                    string ConL1W_Say_Adead= "-- Not Available --";
                    string ConL1W_Sharon= "-- Not Available --";
                    string ConL1W_Suzana= "-- Not Available --";
                    string ConL1W_Swanish= "-- Not Available --";
                    string ConL1W_Vanessa= "-- Not Available --";
                    string ConL1M_Arnon= "-- Not Available --";
                    string ConL1M_Aroma= "-- Not Available --";
                    string ConL1M_Bima= "-- Not Available --";
                    string ConL1M_Adead_Talk= "-- Not Available --";
                    string ConL1M_Adead_Co= "-- Not Available --";
                    string ConL1M_Garmelia= "-- Not Available --";
                    string ConL1M_Holland_Bakery= "-- Not Available --";
                    string ConL1M_Lauw= "-- Not Available --";
                    string ConL1M_Le_Gitt= "-- Not Available --";
                    string ConL1M_Matahari= "-- Not Available --";
                    string ConL1M_Maxim= "-- Not Available --";
                    string ConL1M_Mr_Adead= "-- Not Available --";
                    string ConL1M_My_Roti= "-- Not Available --";
                    string ConL1M_Paroti= "-- Not Available --";
                    string ConL1M_Prime_Adead= "-- Not Available --";
                    string ConL1M_Ramona= "-- Not Available --";
                    string ConL1M_Roti_Boy= "-- Not Available --";
                    string ConL1M_Roti_O= "-- Not Available --";
                    string ConL1M_Sari_Roti= "-- Not Available --";
                    string ConL1M_Say_Adead= "-- Not Available --";
                    string ConL1M_Sharon= "-- Not Available --";
                    string ConL1M_Suzana= "-- Not Available --";
                    string ConL1M_Swanish= "-- Not Available --";
                    string ConL1M_Vanessa= "-- Not Available --";
                    string ConL3M_Arnon= "-- Not Available --";
                    string ConL3M_Aroma= "-- Not Available --";
                    string ConL3M_Bima= "-- Not Available --";
                    string ConL3M_Adead_Talk= "-- Not Available --";
                    string ConL3M_Adead_Co= "-- Not Available --";
                    string ConL3M_Garmelia= "-- Not Available --";
                    string ConL3M_Holland_Bakery= "-- Not Available --";
                    string ConL3M_Lauw= "-- Not Available --";
                    string ConL3M_Le_Gitt= "-- Not Available --";
                    string ConL3M_Matahari= "-- Not Available --";
                    string ConL3M_Maxim= "-- Not Available --";
                    string ConL3M_Mr_Adead= "-- Not Available --";
                    string ConL3M_My_Roti= "-- Not Available --";
                    string ConL3M_Paroti= "-- Not Available --";
                    string ConL3M_Prime_Adead= "-- Not Available --";
                    string ConL3M_Ramona= "-- Not Available --";
                    string ConL3M_Roti_Boy= "-- Not Available --";
                    string ConL3M_Roti_O= "-- Not Available --";
                    string ConL3M_Sari_Roti= "-- Not Available --";
                    string ConL3M_Say_Adead= "-- Not Available --";
                    string ConL3M_Sharon= "-- Not Available --";
                    string ConL3M_Suzana= "-- Not Available --";
                    string ConL3M_Swanish= "-- Not Available --";
                    string ConL3M_Vanessa= "-- Not Available --";
                    string Slogan_Aware= "-- Not Available --";
                    string Slogan_Correct_brand= "-- Not Available --";
                    string B40_1= "-- Not Available --";
                    string B40_2= "-- Not Available --";
                    string B40_3= "-- Not Available --";
                    string B40_4= "-- Not Available --";
                    string B41b_1= "-- Not Available --";
                    string B41b_2= "-- Not Available --";
                    string B41b_3= "-- Not Available --";
                    string B41b_4= "-- Not Available --";
                    string B42_1= "-- Not Available --";
                    string B42_2= "-- Not Available --";
                    string B43a_1= "-- Not Available --";
                    string B43a_2= "-- Not Available --";
                    string P1= "-- Not Available --";
                    string P2_1= "-- Not Available --";
                    string P2_2= "-- Not Available --";
                    string P2_3= "-- Not Available --";
                    string P2_4= "-- Not Available --";
                    string P2_5= "-- Not Available --";
                    string P2_6= "-- Not Available --";
                    string P2_7= "-- Not Available --";
                    string P2_8= "-- Not Available --";
                    string P2_9= "-- Not Available --";
                    string P2_10= "-- Not Available --";
                    string P3= "-- Not Available --";
                    string ConsP1WSharon_Steamed_Cheese_Cake= "-- Not Available --";
                    string ConsP1WSharon_Dorayaki= "-- Not Available --";
                    string ConsP1WSharon_Japanese_Ring_Cake= "-- Not Available --";
                    string ConsP1WSharon_Soft_Waffle= "-- Not Available --";
                    string ConsP1WSari_roti_Lapis_Bamkuhen= "-- Not Available --";
                    string ConsP1WSari_roti_Dorayaki= "-- Not Available --";
                    string ConsP1WSari_roti_Cheese_Cake= "-- Not Available --";
                    string ConsP1MSharon_Steamed_Cheese_Cake= "-- Not Available --";
                    string ConsP1MSharon_Dorayaki= "-- Not Available --";
                    string ConsP1MSharon_Japanese_Ring_Cake= "-- Not Available --";
                    string ConsP1MSharon_Soft_Waffle= "-- Not Available --";
                    string ConsP1MSari_roti_Lapis_Bamkuhen= "-- Not Available --";
                    string ConsP1MSari_roti_Dorayaki= "-- Not Available --";
                    string ConsP1MSari_roti_Cheese_Cake= "-- Not Available --";
                    string ConsP3MSharon_Steamed_Cheese_Cake= "-- Not Available --";
                    string ConsP3MSharon_Dorayaki= "-- Not Available --";
                    string ConsP3MSharon_Japanese_Ring_Cake= "-- Not Available --";
                    string ConsP3MSharon_Soft_Waffle= "-- Not Available --";
                    string ConsP3MSari_roti_Lapis_Bamkuhen= "-- Not Available --";
                    string ConsP3MSari_roti_Dorayaki= "-- Not Available --";
                    string ConsP3MSari_roti_Cheese_Cake= "-- Not Available --";
                    string AidBrSharon_Steamed_Cheese_Cake= "-- Not Available --";
                    string AidBrSharon_Dorayaki= "-- Not Available --";
                    string AidBrSharon_Japanese_Ring_Cake= "-- Not Available --";
                    string AidBrSharon_Soft_Waffle= "-- Not Available --";
                    string AidBrSari_roti_Lapis_Bamkuhen= "-- Not Available --";
                    string AidBrSari_roti_Dorayaki= "-- Not Available --";
                    string AidBrSari_roti_Cheese_Cake= "-- Not Available --";
                    string NETT_SR_User = "-- Not Available --";
                    string NETT_Non_SR_User= "-- Not Available --";

                    foreach (var variable in spssDataset.Variables)
                    {
                        foreach (string spss_v in spss_variable_name)
                        {
                            if (variable.Name.Equals(spss_v))
                            {
                                variable_name = variable.Name;

                                switch (variable_name)
                                {
                                    case "id":
                                        {
                                            u_id = Convert.ToString(record.GetValue(variable));
                                            userID = find_UserId(SurveyID, AttendedOn, u_id);
                                            break;
                                        }
                                    case "weight":
                                        {
                                            Weight = Convert.ToDecimal(record.GetValue(variable));
                                            break;
                                        }
                                    case "S9": { SES = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S8": { Region = Convert.ToString(record.GetValue(variable)); break; }
                                    case "S2": { AgeGroup = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B1": { BrTom = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_1": { BrSpontArnon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_2": { BrSpontAroma = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_3": { BrSpontBima = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_4": { BrSpontBread_Talk = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_5": { BrSpontBread_Co = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_6": { BrSpontGarmelia = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_7": { BrSpontHolland_Bakery = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_8": { BrSpontLauw = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_9": { BrSpontLe_Gitt = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_10": { BrSpontMatahari = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_11": { BrSpontMaxim = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_12": { BrSpontMr_Bread = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_13": { BrSpontMy_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_14": { BrSpontParoti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_15": { BrSpontPrime_Bread = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_16": { BrSpontRamona = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_17": { BrSpontRoti_Boy = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_18": { BrSpontRoti_O = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_19": { BrSpontSari_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_20": { BrSpontSay_Bread = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_21": { BrSpontSharon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_22": { BrSpontSuzana = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_23": { BrSpontSwanish = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B2_24": { BrSpontVanessa = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B4a": { AdTom = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_1": { AdSpontArnon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_2": { AdSpontAroma = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_3": { AdSpontBima = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_4": { AdSpontAdead_Talk = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_5": { AdSpontAdead_Co = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_6": { AdSpontGarmelia = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_7": { AdSpontHolland_Bakery = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_8": { AdSpontLauw = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_9": { AdSpontLe_Gitt = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_10": { AdSpontMatahari = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_11": { AdSpontMaxim = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_12": { AdSpontMr_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_13": { AdSpontMy_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_14": { AdSpontParoti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_15": { AdSpontPrime_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_16": { AdSpontRamona = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_17": { AdSpontRoti_Boy = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_18": { AdSpontRoti_O = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_19": { AdSpontSari_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_20": { AdSpontSay_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_21": { AdSpontSharon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_22": { AdSpontSuzana = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_23": { AdSpontSwanish = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5_24": { AdSpontVanessa = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5b_1": { B5b_1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5b_2": { B5b_2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5b_3": { B5b_3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5b_4": { B5b_4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5b_5": { B5b_5 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5b_6": { B5b_6 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B5b_7": { B5b_7 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B10": { Bumo = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B3": { Favourite_Brand = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_1": { ConL1W_Arnon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_2": { ConL1W_Aroma = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_3": { ConL1W_Bima = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_4": { ConL1W_Adead_Talk = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_5": { ConL1W_Adead_Co = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_6": { ConL1W_Garmelia = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_7": { ConL1W_Holland_Bakery = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_8": { ConL1W_Lauw = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_9": { ConL1W_Le_Gitt = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_10": { ConL1W_Matahari = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_11": { ConL1W_Maxim = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_12": { ConL1W_Mr_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_13": { ConL1W_My_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_14": { ConL1W_Paroti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_15": { ConL1W_Prime_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_16": { ConL1W_Ramona = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_17": { ConL1W_Roti_Boy = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_18": { ConL1W_Roti_O = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_19": { ConL1W_Sari_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_20": { ConL1W_Say_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_21": { ConL1W_Sharon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_22": { ConL1W_Suzana = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_23": { ConL1W_Swanish = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B8_24": { ConL1W_Vanessa = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_1": { ConL1M_Arnon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_2": { ConL1M_Aroma = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_3": { ConL1M_Bima = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_4": { ConL1M_Adead_Talk = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_5": { ConL1M_Adead_Co = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_6": { ConL1M_Garmelia = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_7": { ConL1M_Holland_Bakery = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_8": { ConL1M_Lauw = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_9": { ConL1M_Le_Gitt = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_10": { ConL1M_Matahari = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_11": { ConL1M_Maxim = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_12": { ConL1M_Mr_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_13": { ConL1M_My_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_14": { ConL1M_Paroti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_15": { ConL1M_Prime_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_16": { ConL1M_Ramona = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_17": { ConL1M_Roti_Boy = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_18": { ConL1M_Roti_O = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_19": { ConL1M_Sari_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_20": { ConL1M_Say_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_21": { ConL1M_Sharon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_22": { ConL1M_Suzana = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_23": { ConL1M_Swanish = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B7_24": { ConL1M_Vanessa = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_1": { ConL3M_Arnon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_2": { ConL3M_Aroma = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_3": { ConL3M_Bima = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_4": { ConL3M_Adead_Talk = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_5": { ConL3M_Adead_Co = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_6": { ConL3M_Garmelia = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_7": { ConL3M_Holland_Bakery = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_8": { ConL3M_Lauw = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_9": { ConL3M_Le_Gitt = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_10": { ConL3M_Matahari = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_11": { ConL3M_Maxim = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_12": { ConL3M_Mr_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_13": { ConL3M_My_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_14": { ConL3M_Paroti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_15": { ConL3M_Prime_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_16": { ConL3M_Ramona = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_17": { ConL3M_Roti_Boy = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_18": { ConL3M_Roti_O = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_19": { ConL3M_Sari_Roti = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_20": { ConL3M_Say_Adead = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_21": { ConL3M_Sharon = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_22": { ConL3M_Suzana = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_23": { ConL3M_Swanish = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B6_24": { ConL3M_Vanessa = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B38": { Slogan_Aware = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B39": { Slogan_Correct_brand = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B40_1": { B40_1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B40_2": { B40_2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B40_3": { B40_3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B40_4": { B40_4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B41b_1": { B41b_1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B41b_2": { B41b_2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B41b_3": { B41b_3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B41b_4": { B41b_4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B42_1": { B42_1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B42_2": { B42_2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B43a_1": { B43a_1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "B43a_2": { B43a_2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P1": { P1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_1": { P2_1 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_2": { P2_2 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_3": { P2_3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_4": { P2_4 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_5": { P2_5 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_6": { P2_6 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_7": { P2_7 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_8": { P2_8 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_9": { P2_9 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P2_10": { P2_10 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "P3": { P3 = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C4_1": { ConsP1WSharon_Steamed_Cheese_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C4_2": { ConsP1WSharon_Dorayaki = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C4_3": { ConsP1WSharon_Japanese_Ring_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C4_4": { ConsP1WSharon_Soft_Waffle = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C4_5": { ConsP1WSari_roti_Lapis_Bamkuhen = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C4_6": { ConsP1WSari_roti_Dorayaki = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C4_7": { ConsP1WSari_roti_Cheese_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C3_1": { ConsP1MSharon_Steamed_Cheese_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C3_2": { ConsP1MSharon_Dorayaki = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C3_3": { ConsP1MSharon_Japanese_Ring_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C3_4": { ConsP1MSharon_Soft_Waffle = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C3_5": { ConsP1MSari_roti_Lapis_Bamkuhen = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C3_6": { ConsP1MSari_roti_Dorayaki = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C3_7": { ConsP1MSari_roti_Cheese_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C2_1": { ConsP3MSharon_Steamed_Cheese_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C2_2": { ConsP3MSharon_Dorayaki = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C2_3": { ConsP3MSharon_Japanese_Ring_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C2_4": { ConsP3MSharon_Soft_Waffle = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C2_5": { ConsP3MSari_roti_Lapis_Bamkuhen = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C2_6": { ConsP3MSari_roti_Dorayaki = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C2_7": { ConsP3MSari_roti_Cheese_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C1_1": { AidBrSharon_Steamed_Cheese_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C1_2": { AidBrSharon_Dorayaki = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C1_3": { AidBrSharon_Japanese_Ring_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C1_4": { AidBrSharon_Soft_Waffle = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C1_5": { AidBrSari_roti_Lapis_Bamkuhen = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C1_6": { AidBrSari_roti_Dorayaki = Convert.ToString(record.GetValue(variable)); break; }
                                    case "C1_7": { AidBrSari_roti_Cheese_Cake = Convert.ToString(record.GetValue(variable)); break; }
                                    case "NETT_SR_User": { NETT_SR_User = Convert.ToString(record.GetValue(variable)); break; }
                                    case "NETT_Non_SR_User": { NETT_Non_SR_User = Convert.ToString(record.GetValue(variable)); break; }

                                    
                                }
                            }
                        }
                    }
                    if (userID != null && Weight != 0 )
                    {
                       iobj.insert_Dashboard_values(userID, SurveyID, AttendedOn, Weight, country, Region, AgeGroup, SES, BrTom, BrSpontArnon, BrSpontAroma, BrSpontBima, BrSpontBread_Talk, BrSpontBread_Co, BrSpontGarmelia, BrSpontHolland_Bakery, BrSpontLauw, BrSpontLe_Gitt, BrSpontMatahari, BrSpontMaxim, BrSpontMr_Bread, BrSpontMy_Roti, BrSpontParoti, BrSpontPrime_Bread, BrSpontRamona, BrSpontRoti_Boy, BrSpontRoti_O, BrSpontSari_Roti, BrSpontSay_Bread, BrSpontSharon, BrSpontSuzana, BrSpontSwanish, BrSpontVanessa, AdTom, AdSpontArnon, AdSpontAroma, AdSpontBima, AdSpontAdead_Talk, AdSpontAdead_Co, AdSpontGarmelia, AdSpontHolland_Bakery, AdSpontLauw, AdSpontLe_Gitt, AdSpontMatahari, AdSpontMaxim, AdSpontMr_Adead, AdSpontMy_Roti, AdSpontParoti, AdSpontPrime_Adead, AdSpontRamona, AdSpontRoti_Boy, AdSpontRoti_O, AdSpontSari_Roti, AdSpontSay_Adead, AdSpontSharon, AdSpontSuzana, AdSpontSwanish, AdSpontVanessa, B5b_1, B5b_2, B5b_3, B5b_4, B5b_5, B5b_6, B5b_7, Bumo, Favourite_Brand, ConL1W_Arnon, ConL1W_Aroma, ConL1W_Bima, ConL1W_Adead_Talk, ConL1W_Adead_Co, ConL1W_Garmelia, ConL1W_Holland_Bakery, ConL1W_Lauw, ConL1W_Le_Gitt, ConL1W_Matahari, ConL1W_Maxim, ConL1W_Mr_Adead, ConL1W_My_Roti, ConL1W_Paroti, ConL1W_Prime_Adead, ConL1W_Ramona, ConL1W_Roti_Boy, ConL1W_Roti_O, ConL1W_Sari_Roti, ConL1W_Say_Adead, ConL1W_Sharon, ConL1W_Suzana, ConL1W_Swanish, ConL1W_Vanessa, ConL1M_Arnon, ConL1M_Aroma, ConL1M_Bima, ConL1M_Adead_Talk, ConL1M_Adead_Co, ConL1M_Garmelia, ConL1M_Holland_Bakery, ConL1M_Lauw, ConL1M_Le_Gitt, ConL1M_Matahari, ConL1M_Maxim, ConL1M_Mr_Adead, ConL1M_My_Roti, ConL1M_Paroti, ConL1M_Prime_Adead, ConL1M_Ramona, ConL1M_Roti_Boy, ConL1M_Roti_O, ConL1M_Sari_Roti, ConL1M_Say_Adead, ConL1M_Sharon, ConL1M_Suzana, ConL1M_Swanish, ConL1M_Vanessa, ConL3M_Arnon, ConL3M_Aroma, ConL3M_Bima, ConL3M_Adead_Talk, ConL3M_Adead_Co, ConL3M_Garmelia, ConL3M_Holland_Bakery, ConL3M_Lauw, ConL3M_Le_Gitt, ConL3M_Matahari, ConL3M_Maxim, ConL3M_Mr_Adead, ConL3M_My_Roti, ConL3M_Paroti, ConL3M_Prime_Adead, ConL3M_Ramona, ConL3M_Roti_Boy, ConL3M_Roti_O, ConL3M_Sari_Roti, ConL3M_Say_Adead, ConL3M_Sharon, ConL3M_Suzana, ConL3M_Swanish, ConL3M_Vanessa, Slogan_Aware, Slogan_Correct_brand, B40_1, B40_2, B40_3, B40_4, B41b_1, B41b_2, B41b_3, B41b_4, B42_1, B42_2, B43a_1, B43a_2, P1, P2_1, P2_2, P2_3, P2_4, P2_5, P2_6, P2_7, P2_8, P2_9, P2_10, P3, ConsP1WSharon_Steamed_Cheese_Cake, ConsP1WSharon_Dorayaki, ConsP1WSharon_Japanese_Ring_Cake, ConsP1WSharon_Soft_Waffle, ConsP1WSari_roti_Lapis_Bamkuhen, ConsP1WSari_roti_Dorayaki, ConsP1WSari_roti_Cheese_Cake, ConsP1MSharon_Steamed_Cheese_Cake, ConsP1MSharon_Dorayaki, ConsP1MSharon_Japanese_Ring_Cake, ConsP1MSharon_Soft_Waffle, ConsP1MSari_roti_Lapis_Bamkuhen, ConsP1MSari_roti_Dorayaki, ConsP1MSari_roti_Cheese_Cake, ConsP3MSharon_Steamed_Cheese_Cake, ConsP3MSharon_Dorayaki, ConsP3MSharon_Japanese_Ring_Cake, ConsP3MSharon_Soft_Waffle, ConsP3MSari_roti_Lapis_Bamkuhen, ConsP3MSari_roti_Dorayaki, ConsP3MSari_roti_Cheese_Cake, AidBrSharon_Steamed_Cheese_Cake, AidBrSharon_Dorayaki, AidBrSharon_Japanese_Ring_Cake, AidBrSharon_Soft_Waffle, AidBrSari_roti_Lapis_Bamkuhen, AidBrSari_roti_Dorayaki, AidBrSari_roti_Cheese_Cake, NETT_SR_User, NETT_Non_SR_User);
                    }
                }
            }
        }

        private static string find_UserId(int SurveyID, string SurveyPeriod, string u_id)
        {
            string sum = "";
            string[] date = SurveyPeriod.Split('-');
            foreach (string d in date)
            {
                sum = sum + d;

            }
            return u_id + SurveyID + sum;
        }
    }
}
