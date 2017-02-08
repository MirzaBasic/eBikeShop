using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PeP_API.Util
{
    public class ExceptionHandler
    {

        public static string HandleException(EntityException ex)
        {
            SqlException error = ex.InnerException as SqlException;

            switch (error.Number)
            {
                case 2627: return getConstraintExceptionMessage(error);
                  

                
                    



            }
            return error.Message + "(" + error.Number + ")";

        }

        private static string getConstraintExceptionMessage(SqlException error)
        {

            string msg = error.Message;

            int start = msg.IndexOf("'");
            int end = msg.IndexOf("'", start + 1);
            if(start>0&&end>0)
            {
                string constraintName = msg.Substring(start + 1, end - start-1);
                if (constraintName == "CS_Email")
                    msg = "email_con";
                else if (constraintName == "CS_KorisnickoIme")
                    msg = "username_con";

            }


            return msg;
        }

     
    }
}