﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SariToriHWAll_Parsing
{
    class DB_insertion_SariRotiHWAll
    {
        SqlConnection connection = new SqlConnection("Data Source=52.74.59.117;Initial Catalog=ClueboxMobile;Persist Security Info=True;User ID=sa;Password=ClueBox123*;");
        internal void insert_Dashboard_values(string userID, int SurveyID, string AttendedOn, decimal Weight, string country, string Region, string AgeGroup, string SES, string BrTom, string BrSpontArnon, string BrSpontAroma, string BrSpontBima, string BrSpontBread_Talk, string BrSpontBread_Co, string BrSpontGarmelia, string BrSpontHolland_Bakery, string BrSpontLauw, string BrSpontLe_Gitt, string BrSpontMatahari, string BrSpontMaxim, string BrSpontMr_Bread, string BrSpontMy_Roti, string BrSpontParoti, string BrSpontPrime_Bread, string BrSpontRamona, string BrSpontRoti_Boy, string BrSpontRoti_O, string BrSpontSari_Roti, string BrSpontSay_Bread, string BrSpontSharon, string BrSpontSuzana, string BrSpontSwanish, string BrSpontVanessa, string AdTom, string AdSpontArnon, string AdSpontAroma, string AdSpontBima, string AdSpontAdead_Talk, string AdSpontAdead_Co, string AdSpontGarmelia, string AdSpontHolland_Bakery, string AdSpontLauw, string AdSpontLe_Gitt, string AdSpontMatahari, string AdSpontMaxim, string AdSpontMr_Adead, string AdSpontMy_Roti, string AdSpontParoti, string AdSpontPrime_Adead, string AdSpontRamona, string AdSpontRoti_Boy, string AdSpontRoti_O, string AdSpontSari_Roti, string AdSpontSay_Adead, string AdSpontSharon, string AdSpontSuzana, string AdSpontSwanish, string AdSpontVanessa, string B5b_1, string B5b_2, string B5b_3, string B5b_4, string B5b_5, string B5b_6, string B5b_7, string Bumo, string Favourite_Brand, string ConL1W_Arnon, string ConL1W_Aroma, string ConL1W_Bima, string ConL1W_Adead_Talk, string ConL1W_Adead_Co, string ConL1W_Garmelia, string ConL1W_Holland_Bakery, string ConL1W_Lauw, string ConL1W_Le_Gitt, string ConL1W_Matahari, string ConL1W_Maxim, string ConL1W_Mr_Adead, string ConL1W_My_Roti, string ConL1W_Paroti, string ConL1W_Prime_Adead, string ConL1W_Ramona, string ConL1W_Roti_Boy, string ConL1W_Roti_O, string ConL1W_Sari_Roti, string ConL1W_Say_Adead, string ConL1W_Sharon, string ConL1W_Suzana, string ConL1W_Swanish, string ConL1W_Vanessa, string ConL1M_Arnon, string ConL1M_Aroma, string ConL1M_Bima, string ConL1M_Adead_Talk, string ConL1M_Adead_Co, string ConL1M_Garmelia, string ConL1M_Holland_Bakery, string ConL1M_Lauw, string ConL1M_Le_Gitt, string ConL1M_Matahari, string ConL1M_Maxim, string ConL1M_Mr_Adead, string ConL1M_My_Roti, string ConL1M_Paroti, string ConL1M_Prime_Adead, string ConL1M_Ramona, string ConL1M_Roti_Boy, string ConL1M_Roti_O, string ConL1M_Sari_Roti, string ConL1M_Say_Adead, string ConL1M_Sharon, string ConL1M_Suzana, string ConL1M_Swanish, string ConL1M_Vanessa, string ConL3M_Arnon, string ConL3M_Aroma, string ConL3M_Bima, string ConL3M_Adead_Talk, string ConL3M_Adead_Co, string ConL3M_Garmelia, string ConL3M_Holland_Bakery, string ConL3M_Lauw, string ConL3M_Le_Gitt, string ConL3M_Matahari, string ConL3M_Maxim, string ConL3M_Mr_Adead, string ConL3M_My_Roti, string ConL3M_Paroti, string ConL3M_Prime_Adead, string ConL3M_Ramona, string ConL3M_Roti_Boy, string ConL3M_Roti_O, string ConL3M_Sari_Roti, string ConL3M_Say_Adead, string ConL3M_Sharon, string ConL3M_Suzana, string ConL3M_Swanish, string ConL3M_Vanessa, string Slogan_Aware, string Slogan_Correct_brand, string B40_1, string B40_2, string B40_3, string B40_4, string B41b_1, string B41b_2, string B41b_3, string B41b_4, string B42_1, string B42_2, string B43a_1, string B43a_2, string P1, string P2_1, string P2_2, string P2_3, string P2_4, string P2_5, string P2_6, string P2_7, string P2_8, string P2_9, string P2_10, string P3, string ConsP1WSharon_Steamed_Cheese_Cake, string ConsP1WSharon_Dorayaki, string ConsP1WSharon_Japanese_Ring_Cake, string ConsP1WSharon_Soft_Waffle, string ConsP1WSari_roti_Lapis_Bamkuhen, string ConsP1WSari_roti_Dorayaki, string ConsP1WSari_roti_Cheese_Cake, string ConsP1MSharon_Steamed_Cheese_Cake, string ConsP1MSharon_Dorayaki, string ConsP1MSharon_Japanese_Ring_Cake, string ConsP1MSharon_Soft_Waffle, string ConsP1MSari_roti_Lapis_Bamkuhen, string ConsP1MSari_roti_Dorayaki, string ConsP1MSari_roti_Cheese_Cake, string ConsP3MSharon_Steamed_Cheese_Cake, string ConsP3MSharon_Dorayaki, string ConsP3MSharon_Japanese_Ring_Cake, string ConsP3MSharon_Soft_Waffle, string ConsP3MSari_roti_Lapis_Bamkuhen, string ConsP3MSari_roti_Dorayaki, string ConsP3MSari_roti_Cheese_Cake, string AidBrSharon_Steamed_Cheese_Cake, string AidBrSharon_Dorayaki, string AidBrSharon_Japanese_Ring_Cake, string AidBrSharon_Soft_Waffle, string AidBrSari_roti_Lapis_Bamkuhen, string AidBrSari_roti_Dorayaki, string AidBrSari_roti_Cheese_Cake, string NETT_SR_User, string NETT_Non_SR_User)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardFlatTabJava_SRHWAll_temp (UserID,AttendedOn,weight,SurveyID,Country,SES,Region,AgeGroup,BrTom,BrSpontArnon,BrSpontAroma,BrSpontBima,BrSpontBread_Talk,BrSpontBread_Co,BrSpontGarmelia,BrSpontHolland_Bakery,BrSpontLauw,BrSpontLe_Gitt,BrSpontMatahari,BrSpontMaxim,BrSpontMr_Bread,BrSpontMy_Roti,BrSpontParoti,BrSpontPrime_Bread,BrSpontRamona,BrSpontRoti_Boy,BrSpontRoti_O,BrSpontSari_Roti,BrSpontSay_Bread,BrSpontSharon,BrSpontSuzana,BrSpontSwanish,BrSpontVanessa,AdTom,AdSpontArnon,AdSpontAroma,AdSpontBima,AdSpontBread_Talk,AdSpontBread_Co,AdSpontGarmelia,AdSpontHolland_Bakery,AdSpontLauw,AdSpontLe_Gitt,AdSpontMatahari,AdSpontMaxim,AdSpontMr_Bread,AdSpontMy_Roti,AdSpontParoti,AdSpontPrime_Bread,AdSpontRamona,AdSpontRoti_Boy,AdSpontRoti_O,AdSpontSari_Roti,AdSpontSay_Bread,AdSpontSharon,AdSpontSuzana,AdSpontSwanish,AdSpontVanessa,B5b_1,B5b_2,B5b_3,B5b_4,B5b_5,B5b_6,B5b_7,Bumo,Favourite_Brand,ConL1W_Arnon,ConL1W_Aroma,ConL1W_Bima,ConL1W_Bread_Talk,ConL1W_Bread_Co,ConL1W_Garmelia,ConL1W_Holland_Bakery,ConL1W_Lauw,ConL1W_Le_Gitt,ConL1W_Matahari,ConL1W_Maxim,ConL1W_Mr_Bread,ConL1W_My_Roti,ConL1W_Paroti,ConL1W_Prime_Adead,ConL1W_Ramona,ConL1W_Roti_Boy,ConL1W_Roti_O,ConL1W_Sari_Roti,ConL1W_Say_Bread,ConL1W_Sharon,ConL1W_Suzana,ConL1W_Swanish,ConL1W_Vanessa,ConL1M_Arnon,ConL1M_Aroma,ConL1M_Bima,ConL1M_Bread_Talk,ConL1M_Bread_Co,ConL1M_Garmelia,ConL1M_Holland_Bakery,ConL1M_Lauw,ConL1M_Le_Gitt,ConL1M_Matahari,ConL1M_Maxim,ConL1M_Mr_Bread,ConL1M_My_Roti,ConL1M_Paroti,ConL1M_Prime_Bread,ConL1M_Ramona,ConL1M_Roti_Boy,ConL1M_Roti_O,ConL1M_Sari_Roti,ConL1M_Say_Bread,ConL1M_Sharon,ConL1M_Suzana,ConL1M_Swanish,ConL1M_Vanessa,ConL3M_Arnon,ConL3M_Aroma,ConL3M_Bima,ConL3M_Bread_Talk,ConL3M_Bread_Co,ConL3M_Garmelia,ConL3M_Holland_Bakery,ConL3M_Lauw,ConL3M_Le_Gitt,ConL3M_Matahari,ConL3M_Maxim,ConL3M_Mr_Bread,ConL3M_My_Roti,ConL3M_Paroti,ConL3M_Prime_Bread,ConL3M_Ramona,ConL3M_Roti_Boy,ConL3M_Roti_O,ConL3M_Sari_Roti,ConL3M_Say_Bread,ConL3M_Sharon,ConL3M_Suzana,ConL3M_Swanish,ConL3M_Vanessa,Slogan_Aware,Slogan_Correct_brand,B40_1,B40_2,B40_3,B40_4,B41b_1,B41b_2,B41b_3,B41b_4,B42_1,B42_2,B43a_1,B43a_2,P1,P2_1,P2_2,P2_3,P2_4,P2_5,P2_6,P2_7,P2_8,P2_9,P2_10,P3,ConsP1WSharon_Steamed_Cheese_Cake,ConsP1WSharon_Dorayaki,ConsP1WSharon_Japanese_Ring_Cake,ConsP1WSharon_Soft_Waffle,ConsP1WSari_roti_Lapis_Bamkuhen,ConsP1WSari_roti_Dorayaki,ConsP1WSari_roti_Cheese_Cake,ConsP1MSharon_Steamed_Cheese_Cake,ConsP1MSharon_Dorayaki,ConsP1MSharon_Japanese_Ring_Cake,ConsP1MSharon_Soft_Waffle,ConsP1MSari_roti_Lapis_Bamkuhen,ConsP1MSari_roti_Dorayaki,ConsP1MSari_roti_Cheese_Cake,ConsP3MSharon_Steamed_Cheese_Cake,ConsP3MSharon_Dorayaki,ConsP3MSharon_Japanese_Ring_Cake,ConsP3MSharon_Soft_Waffle,ConsP3MSari_roti_Lapis_Bamkuhen,ConsP3MSari_roti_Dorayaki,ConsP3MSari_roti_Cheese_Cake,AidBrSharon_Steamed_Cheese_Cake,AidBrSharon_Dorayaki,AidBrSharon_Japanese_Ring_Cake,AidBrSharon_Soft_Waffle,AidBrSari_roti_Lapis_Bamkuhen,AidBrSari_roti_Dorayaki,AidBrSari_roti_Cheese_Cake,SR_User,Non_SR_user) " + "VALUES('" + userID + "','" + AttendedOn + "','" + Weight + "','" + SurveyID + "','" + country + "','" + SES + "','" + Region + "','" + AgeGroup + "','" + BrTom + "','" + BrSpontArnon + "','" + BrSpontAroma + "','" + BrSpontBima + "','" + BrSpontBread_Talk + "','" + BrSpontBread_Co + "','" + BrSpontGarmelia + "','" + BrSpontHolland_Bakery + "','" + BrSpontLauw + "','" + BrSpontLe_Gitt + "','" + BrSpontMatahari + "','" + BrSpontMaxim + "','" + BrSpontMr_Bread + "','" + BrSpontMy_Roti + "','" + BrSpontParoti + "','" + BrSpontPrime_Bread + "','" + BrSpontRamona + "','" + BrSpontRoti_Boy + "','" + BrSpontRoti_O + "','" + BrSpontSari_Roti + "','" + BrSpontSay_Bread + "','" + BrSpontSharon + "','" + BrSpontSuzana + "','" + BrSpontSwanish + "','" + BrSpontVanessa + "','" + AdTom + "','" + AdSpontArnon + "','" + AdSpontAroma + "','" + AdSpontBima + "','" + AdSpontAdead_Talk + "','" + AdSpontAdead_Co + "','" + AdSpontGarmelia + "','" + AdSpontHolland_Bakery + "','" + AdSpontLauw + "','" + AdSpontLe_Gitt + "','" + AdSpontMatahari + "','" + AdSpontMaxim + "','" + AdSpontMr_Adead + "','" + AdSpontMy_Roti + "','" + AdSpontParoti + "','" + AdSpontPrime_Adead + "','" + AdSpontRamona + "','" + AdSpontRoti_Boy + "','" + AdSpontRoti_O + "','" + AdSpontSari_Roti + "','" + AdSpontSay_Adead + "','" + AdSpontSharon + "','" + AdSpontSuzana + "','" + AdSpontSwanish + "','" + AdSpontVanessa + "','" + B5b_1 + "','" + B5b_2 + "','" + B5b_3 + "','" + B5b_4 + "','" + B5b_5 + "','" + B5b_6 + "','" + B5b_7 + "','" + Bumo + "','" + Favourite_Brand + "','" + ConL1W_Arnon + "','" + ConL1W_Aroma + "','" + ConL1W_Bima + "','" + ConL1W_Adead_Talk + "','" + ConL1W_Adead_Co + "','" + ConL1W_Garmelia + "','" + ConL1W_Holland_Bakery + "','" + ConL1W_Lauw + "','" + ConL1W_Le_Gitt + "','" + ConL1W_Matahari + "','" + ConL1W_Maxim + "','" + ConL1W_Mr_Adead + "','" + ConL1W_My_Roti + "','" + ConL1W_Paroti + "','" + ConL1W_Prime_Adead + "','" + ConL1W_Ramona + "','" + ConL1W_Roti_Boy + "','" + ConL1W_Roti_O + "','" + ConL1W_Sari_Roti + "','" + ConL1W_Say_Adead + "','" + ConL1W_Sharon + "','" + ConL1W_Suzana + "','" + ConL1W_Swanish + "','" + ConL1W_Vanessa + "','" + ConL1M_Arnon + "','" + ConL1M_Aroma + "','" + ConL1M_Bima + "','" + ConL1M_Adead_Talk + "','" + ConL1M_Adead_Co + "','" + ConL1M_Garmelia + "','" + ConL1M_Holland_Bakery + "','" + ConL1M_Lauw + "','" + ConL1M_Le_Gitt + "','" + ConL1M_Matahari + "','" + ConL1M_Maxim + "','" + ConL1M_Mr_Adead + "','" + ConL1M_My_Roti + "','" + ConL1M_Paroti + "','" + ConL1M_Prime_Adead + "','" + ConL1M_Ramona + "','" + ConL1M_Roti_Boy + "','" + ConL1M_Roti_O + "','" + ConL1M_Sari_Roti + "','" + ConL1M_Say_Adead + "','" + ConL1M_Sharon + "','" + ConL1M_Suzana + "','" + ConL1M_Swanish + "','" + ConL1M_Vanessa + "','" + ConL3M_Arnon + "','" + ConL3M_Aroma + "','" + ConL3M_Bima + "','" + ConL3M_Adead_Talk + "','" + ConL3M_Adead_Co + "','" + ConL3M_Garmelia + "','" + ConL3M_Holland_Bakery + "','" + ConL3M_Lauw + "','" + ConL3M_Le_Gitt + "','" + ConL3M_Matahari + "','" + ConL3M_Maxim + "','" + ConL3M_Mr_Adead + "','" + ConL3M_My_Roti + "','" + ConL3M_Paroti + "','" + ConL3M_Prime_Adead + "','" + ConL3M_Ramona + "','" + ConL3M_Roti_Boy + "','" + ConL3M_Roti_O + "','" + ConL3M_Sari_Roti + "','" + ConL3M_Say_Adead + "','" + ConL3M_Sharon + "','" + ConL3M_Suzana + "','" + ConL3M_Swanish + "','" + ConL3M_Vanessa + "','" + Slogan_Aware + "','" + Slogan_Correct_brand + "','" + B40_1 + "','" + B40_2 + "','" + B40_3 + "','" + B40_4 + "','" + B41b_1 + "','" + B41b_2 + "','" + B41b_3 + "','" + B41b_4 + "','" + B42_1 + "','" + B42_2 + "','" + B43a_1 + "','" + B43a_2 + "','" + P1 + "','" + P2_1 + "','" + P2_2 + "','" + P2_3 + "','" + P2_4 + "','" + P2_5 + "','" + P2_6 + "','" + P2_7 + "','" + P2_8 + "','" + P2_9 + "','" + P2_10 + "','" + P3 + "','" + ConsP1WSharon_Steamed_Cheese_Cake + "','" + ConsP1WSharon_Dorayaki + "','" + ConsP1WSharon_Japanese_Ring_Cake + "','" + ConsP1WSharon_Soft_Waffle + "','" + ConsP1WSari_roti_Lapis_Bamkuhen + "','" + ConsP1WSari_roti_Dorayaki + "','" + ConsP1WSari_roti_Cheese_Cake + "','" + ConsP1MSharon_Steamed_Cheese_Cake + "','" + ConsP1MSharon_Dorayaki + "','" + ConsP1MSharon_Japanese_Ring_Cake + "','" + ConsP1MSharon_Soft_Waffle + "','" + ConsP1MSari_roti_Lapis_Bamkuhen + "','" + ConsP1MSari_roti_Dorayaki + "','" + ConsP1MSari_roti_Cheese_Cake + "','" + ConsP3MSharon_Steamed_Cheese_Cake + "','" + ConsP3MSharon_Dorayaki + "','" + ConsP3MSharon_Japanese_Ring_Cake + "','" + ConsP3MSharon_Soft_Waffle + "','" + ConsP3MSari_roti_Lapis_Bamkuhen + "','" + ConsP3MSari_roti_Dorayaki + "','" + ConsP3MSari_roti_Cheese_Cake + "','" + AidBrSharon_Steamed_Cheese_Cake + "','" + AidBrSharon_Dorayaki + "','" + AidBrSharon_Japanese_Ring_Cake + "','" + AidBrSharon_Soft_Waffle + "','" + AidBrSari_roti_Lapis_Bamkuhen + "','" + AidBrSari_roti_Dorayaki + "','" + AidBrSari_roti_Cheese_Cake + "','" + NETT_SR_User + "','" + NETT_Non_SR_User + "')", connection);
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");

            }
            catch (Exception ex)
            {

                connection.Close();
                Console.WriteLine("Exception occured" + ex.ToString());
                Console.WriteLine("Exception occured");

                Console.ReadLine();
            }
            connection.Close();
        }

        internal void insert_Dashboard_variable_values(string VARIABLE_NAME, string VARIABLE_NAME_SUB_NAME, string VARIABLE_ID, string VARIABLE_VALUE, string VARIABLE_NAME_QUESTION, int SurveyID, string country, string BASE_VARIABLE_NAME, string AttendedOn)
        {
            String VARIABLEVALUE = VARIABLE_VALUE.Replace("'", "");
            String VARIABLE_QUESTION = VARIABLE_NAME_QUESTION.Replace("'", "");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DashboardSPS_Variable_Values (VARIABLE_NAME,VARIABLE_NAME_SUB_NAME,VARIABLE_ID,VARIABLE_VALUE,VARIABLE_NAME_QUESTION,SURVEY_ID,SURVEY_COUNTRY,BASE_VARIABLE_NAME,SURVEY_PERIOD) " + "VALUES('" + VARIABLE_NAME + "','" + VARIABLE_NAME_SUB_NAME + "','" + VARIABLE_ID + "','" + VARIABLEVALUE + "','" + VARIABLE_QUESTION + "','" + SurveyID + "','" + country + "','" + BASE_VARIABLE_NAME + "','" + AttendedOn + "')", connection);
            try
            {


                cmd.ExecuteNonQuery();
                Console.WriteLine("Dashboard variable values inserted successfully");

                connection.Close();



            }
            catch (Exception)
            {

                Console.WriteLine("Exception occured");
                Console.ReadLine();
            }
        }
    }
}
