﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SportsProDALClassLibrary
{
    public class IncidentDAL
    {
        //A "global" SqlConnection object that can be use as needed for methods below.
        private static readonly SqlConnection tsDBConn = TechSupportDB.GetTechSupportConnection();

        public IncidentDAL()
        {
            //Default Constructor
        }

        /// <summary>
        /// Queries TechSupport database to retrieve records of all incidents from the Incidents table.
        /// </summary>
        /// <returns>A DataTable of all incidents with each record containing all attributes.</returns>
        public DataTable RetrieveAllIncidents()
        {
            DataTable dtAllIncidents = new DataTable();

            string selectStatement =
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectAllIncidents = new SqlCommand(selectStatement, tsDBConn);
            
            try
            {
                selectAllIncidents.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtAllIncidents.Load(selectAllIncidents.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectAllIncidents.Connection.Close();
            }

            return dtAllIncidents;
        }

        /// <summary>
        /// Queries TechSupport database to retrieve records of all incidents for a specified 
        /// technician from the Incidents table.
        /// </summary>
        /// <param name="techID">An integer for a specific technician's ID.</param>
        /// <returns>A DataTable of all incidents for the specified technician.</returns>
        public DataTable RetrieveIncidentsByTechnician(int techID)
        {
            DataTable dtIncidentsByTechnician = new DataTable();

            string selectStatement = 
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents " +
                "WHERE TechID = @techID";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectIncidentsByTechID = new SqlCommand(selectStatement, tsDBConn);

            //Sets up and adds parameter to command. Default direction is 'Input'.
            selectIncidentsByTechID.Parameters.AddWithValue("@techID", techID);

            try
            {
                selectIncidentsByTechID.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtIncidentsByTechnician.Load(selectIncidentsByTechID.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectIncidentsByTechID.Connection.Close();
            }

            return dtIncidentsByTechnician;
        }

        /// <summary>
        /// Queries TechSupport database to retrieve records of all open incidents for a specified 
        /// technician from the Incidents table.
        /// </summary>
        /// <param name="techID">An integer for a specific technician's ID.</param>
        /// <returns>A DataTable of all open incidents for the specified technician.</returns>
        public DataTable RetrieveOpenIncidentsByTechnician(int techID)
        {
            DataTable dtOpenIncidentsByTechnician = new DataTable();

            string selectStatement =
                "SELECT IncidentID, CustomerID, ProductCode, TechID, " +
                    "DateOpened, DateClosed, Title, Description " +
                "FROM dbo.Incidents " +
                "WHERE TechID = @techID AND DateClosed IS NULL;";

            //Creates a SqlCommand using the parameterized constructor. CommandType by default is Text.
            SqlCommand selectOpenIncidentsByTechID = new SqlCommand(selectStatement, tsDBConn);

            //Sets up and adds parameter to command. Default direction is 'Input'.
            selectOpenIncidentsByTechID.Parameters.AddWithValue("@techID", techID);

            try
            {
                selectOpenIncidentsByTechID.Connection.Open();

                //Executes query and loads result set into DataTable.
                dtOpenIncidentsByTechnician.Load(selectOpenIncidentsByTechID.ExecuteReader());
            }
            catch //Throws exception to calling method.
            {
                throw;
            }
            finally //Closes connection even if exception occurs.
            {
                selectOpenIncidentsByTechID.Connection.Close();
            }

            return dtOpenIncidentsByTechnician;
        }
    }
}
