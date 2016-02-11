#region Imports

//C# imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

//Project imports
using PersonListe.BL;

#endregion

namespace PersonListe.DAL
{
    public class PersonDAO
    {
        public DataTable CacheTable { get; set; }
        private string _connectionString = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;

        #region Sql Command Strings

        private string _SqlCommandSelect = "SELECT * FROM Person";
        private string _SqlCommandInsertInto = "INSERT INTO Person (firstName,lastName,position,age) VALUES (@firstName,@lastName,@position,@age)";
        private string _SqlCommandUpdate = "UPDATE Person SET firstName=@firstName, lastName=@lastName, position=@position, age=@age WHERE recID=@recID";
        private string _SqlCommandDelete = "DELETE FROM Person WHERE recID = @recID";

        #endregion

        #region CRUD methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public void CreateObjectInDB(Person obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(_SqlCommandInsertInto, conn))
                {
                    conn.Open();
                    AddParameters(cmd, obj);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable RetrieveObjectsFromDB()
        {                        
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {                
                using (SqlDataAdapter da = new SqlDataAdapter(_SqlCommandSelect, conn))
                {
                    conn.Open();
                    DataTable dTable = new DataTable();
                    da.Fill(dTable);
                    CacheTable = dTable;

                    return dTable;
                }
            }
        }
                
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public void UpdateObjectInDB(Person obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(_SqlCommandUpdate,conn))
                {
                    conn.Open();
                    AddParameters(cmd,obj);
                    cmd.ExecuteNonQuery();
                }
            }
        }
                
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recID"></param>
        /// <returns></returns>
        public void DeleteObjectFromDB(Person obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(_SqlCommandDelete,conn))
                {
                    conn.Open();
                    AddParameters(cmd, obj);
                    cmd.ExecuteNonQuery();                    
                }
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="obj"></param>
        private void AddParameters(SqlCommand cmd, Person obj)
        {
            cmd.Parameters.AddWithValue("@firstName", obj.FirstName);
            cmd.Parameters.AddWithValue("@lastName", obj.LastName);
            cmd.Parameters.AddWithValue("@position", obj.Position);
            cmd.Parameters.AddWithValue("@age", obj.Age);
            cmd.Parameters.AddWithValue("@recID", obj.RecID);
        }

        #endregion
    }
}
