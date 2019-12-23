public static class CustomConverter
    {
        public static string ToString(Object obj)
        {
            return Convert.ToString(obj);
        }

        public static int ToInt32(Object obj)
        {
            Int32 result = 0;
            Int32.TryParse(Convert.ToString(obj), out result);
            return result;
        }

        public static long ToInt64(Object obj)
        {
            Int64 result = 0;
            Int64.TryParse(Convert.ToString(obj), out result);
            return result;
        }

        public static short ToInt16(object obj)
        {
            Int16 result = 0;
            Int16.TryParse(Convert.ToString(obj), out result);
            return result;
        }

        public static decimal ToDecimal(object obj)
        {
            decimal result = 0;
            decimal.TryParse(Convert.ToString(obj), out result);
            return result;
        }

        public static DateTime ToDateTime(object obj)
        {
            DateTime result;
            DateTime.TryParse(Convert.ToString(obj), out result);
            return result;
        }

        public static double ToDouble(object obj)
        {
            Double result = 0;
            Double.TryParse(Convert.ToString(obj), out result);
            return result;
        }

        public static DateTime ToDateTimeFromUnix(object obj)
        {
            double seconds = ToDouble(obj);
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(seconds);
        }
    
       public static bool ToBool(object obj)
        {
            bool result = false;
            bool flag = false;
            result = Boolean.TryParse(Convert.ToString(obj), out flag);
            return flag;
        }
    }
