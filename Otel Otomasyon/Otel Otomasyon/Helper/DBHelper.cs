﻿using Otel_Otomasyon.Helper.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon.Helper
{
    //Bu statik sınıf Database işlemleri için yardımcı olmaktadır.
    public static class DBHelper
    {
        public static string GetConnectionString()
        {
            string conString = @"Data Source=DESKTOP-1NR08J8\SQLEXPRESS;Initial Catalog=dbOtelOtomasyon;Integrated Security=True;MultipleActiveResultSets=True;";
            return conString;
        }

        public static string GetConnectionProvider()
        {
            string conProviderString = "System.Data.SqlClient";
            return conProviderString;
        }

        public static void AddParameter(DbCommand command, string paramName, CsType csDataType, ParameterDirection direction, object value)
        {
            if (command == null)
                throw new ArgumentNullException("command", "The AddParameter's Command value is null.");

            try
            {
                DbParameter parameter = command.CreateParameter();
                parameter.ParameterName = paramName;
                parameter.DbType = CSharpDbTypeConverter(csDataType);
                parameter.Value = value ?? DBNull.Value;
                parameter.Direction = direction;
                command.Parameters.Add(parameter);
            }
            catch (Exception ex)
            {
                throw new Exception("DBHelper::AddParameter::Error occured.", ex);
            }
        }

        private static DbType CSharpDbTypeConverter(CsType csDataType)
        {
            var dbType = DbType.String;
            switch (csDataType)
            {
                case CsType.String:
                    dbType = DbType.String;
                    break;
                case CsType.Int:
                    dbType = DbType.Int32;
                    break;
                case CsType.Long:
                    dbType = DbType.Int64;
                    break;
                case CsType.Double:
                    dbType = DbType.Double;
                    break;
                case CsType.Decimal:
                    dbType = DbType.Decimal;
                    break;
                case CsType.Float:
                    dbType = DbType.Single;
                    break;
                case CsType.DateTime:
                    dbType = DbType.DateTime;
                    break;
                case CsType.Boolean:
                    dbType = DbType.Boolean;
                    break;
                case CsType.Short:
                    dbType = DbType.Int16;
                    break;
                case CsType.Guid:
                    dbType = DbType.Guid;
                    break;
                case CsType.ByteArray:
                case CsType.Binary:
                    dbType = DbType.Binary;
                    break;
            }
            return dbType;
        }
    }
}
