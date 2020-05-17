﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class TechnicianDAL
    {
        //A "global" SqlConnection object that can be use as needed for methods below.
        private static readonly SqlConnection tsDBConn = TechSupportDB.GetTechSupportConnection();

        public TechnicianDAL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Queries TechSupport database to retrieve the TechID and Name of 
        /// all technicians in the Technicians tables.
        /// </summary>
        /// <returns>A DataTable of the TechID and Name of all technicians.</returns>
        public DataTable RetrieveTechnicianNames()
        {
            DataTable dtTechnicianNames = new DataTable();

            string selectStatement =
                "SELECT TechID, Name " +
                "FROM dbo.Technicians;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectTechnicianNames = new SqlCommand(selectStatement, tsDBConn);

            try
            {
                selectTechnicianNames.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtTechnicianNames.Load(selectTechnicianNames.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectTechnicianNames.Connection.Close();
            }

            return dtTechnicianNames;
        }

        /// <summary>
        /// Queries TechSupport database to retrieve the Email 
        /// and Phone information of the specified technician.
        /// </summary>
        /// <param name="techID">An integer containing the technician's ID.</param>
        /// <returns>A DataTable containing the Email and Phone information for the specified technician.</returns>
        public DataTable RetrieveTechnicianDetails(int techID)
        {
            DataTable dtTechnicianDetails = new DataTable();

            string selectStatement =
                "SELECT Email, Phone " +
                "FROM dbo.Technicians " +
                "WHERE TechID = @techID;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectTechnicianDetails = new SqlCommand(selectStatement, tsDBConn);

            //Sets up and adds parameter to SqlCommand.
            selectTechnicianDetails.Parameters.AddWithValue("@techID", techID);

            try
            {
                selectTechnicianDetails.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtTechnicianDetails.Load(selectTechnicianDetails.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectTechnicianDetails.Connection.Close();
            }

            return dtTechnicianDetails;
        }
    }
}
