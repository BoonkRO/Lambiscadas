using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Lambiscadas.Clases
{
    public static class Extensions
    {
        // Funciones Genericas

        public static T To<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string ToJSONString(this object input)
        {
            return JsonConvert.SerializeObject(input);
        }

        //Converts para JObjects

        public static int getInt(this JObject json, string token)
        {
            return Convert.ToInt32(json.SelectToken(token));
        }

        public static T get<T>(this JObject json, string token)
        {
            return JsonConvert.DeserializeObject<T>(json.getString(token));
        }

        public static string getString(this JObject json, string token)
        {
            return Convert.ToString(json.SelectToken(token));
        }

        public static DateTime? getDateTime(this JObject json, string token)
        {
            return Convert.ToDateTime(json.SelectToken(token).ToString());
        }

        public static bool getBool(this JObject json, string token)
        {
            return Convert.ToBoolean(json.SelectToken(token));
        }

        public static float getFloat(this JObject json, string token)
        {
            return float.Parse(json.SelectToken(token).ToString(), CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string toJArray(this DataTable dt)
        {
            JArray array = new JArray();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    array.Add((string)dr[0]);
                }
            }
            catch (Exception e)
            {
                array = new JArray();
            }
            return array.ToString();
        }

        //Converts para DataRow

        public static DateTime? toDateTime(this DataRow dr, string selector)
        {
            if (!string.IsNullOrEmpty(dr[selector].ToString()))
            {
                return DateTime.Parse(dr[selector].ToString());
            }
            return null;
        }

        public static DateTime toDateTime(this string date)
        {
            return DateTime.Parse(date);
        }

        public static bool getBoolean(this DataRow dr, string token)
        {
            return Convert.ToBoolean(dr[token]);
        }

        public static string getString(this DataRow dr, string parametro)
        {
            return dr[parametro].ToString();
        }

        public static int getInt(this DataRow dr, string token)
        {
            return Convert.ToInt32(dr[token]);
        }

        public static float getFloat(this DataRow dr, string token)
        {
            return float.Parse(dr[token].ToString());
        }

        // GetParam with Type

        public static int getInt(this HttpContext context, string paramName)
        {
            return Convert.ToInt32(Utilities.getParam(context, paramName));
        }
    }
}