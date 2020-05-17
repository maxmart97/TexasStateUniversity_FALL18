﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class CustomerDAL
    {
        public CustomerDAL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Queries TechSupport database to get CustomerID and Name for all customers from the Customers table.
        /// </summary>
        /// <returns>A DataTable containing the CustomerID and Name of all customers.</returns>
        public DataTable GetCustomerIDandName()
        {
            DataTable dtCustomerIDandName = new DataTable();

            string selectStatement =
                "SELECT CustomerID, Name " +
                "FROM dbo.Customers;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectCommand = new SqlCommand(selectStatement, TechSupportDB.GetTechSupportConnection());

            try
            {
                selectCommand.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtCustomerIDandName.Load(selectCommand.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectCommand.Connection.Close();
            }

            return dtCustomerIDandName;
        }
    }
}
