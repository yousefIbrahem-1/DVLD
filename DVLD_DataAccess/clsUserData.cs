using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsUserData
    {
        public static string ComputeHash(string Pass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] HashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Pass));
                return BitConverter.ToString(HashBytes).Replace("-", "").ToLower();
            }
        }
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
            ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetUserByUserID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);


                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                        PersonID = (int)reader["PersonID"];
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];


                    }
                    else
                    {
                        // The record was not found
                        isFound = false;
                    }

                }
            

            }
           
            return isFound;
        }


        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName,
          ref string Password,ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetUserByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);


                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                        UserID = (int)reader["UserID"];
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];


                    }
                    else
                    {
                        // The record was not found
                        isFound = false;
                    }

                }

            }

            return isFound;
        }

        public static bool GetUserInfoByUsernameAndPassword(string UserName,  string Password, 
            ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool isFound = false;
            Password=ComputeHash(Password);
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetUserByUsernameAndPassword", connection))
            { 
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;
                        UserID = (int)reader["UserID"];
                        PersonID = (int)reader["PersonID"];
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];


                    }
                    else
                    {
                        // The record was not found
                        isFound = false;
                    }

                }


            }
           
           

            return isFound;
        }

        public static int AddNewUser(int PersonID,  string UserName,
             string Password,  bool IsActive)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int UserID = -1;
            Password = ComputeHash(Password);
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))



            using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            SqlParameter OutputIdParamter = new SqlParameter("@NewUserID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
                command.Parameters.Add(OutputIdParamter);    


                connection.Open();
           command.ExecuteNonQuery();


                UserID = (int)command.Parameters["@NewUserID"].Value;
            }

           

           

            return UserID;
        }


        public static bool UpdateUser(int UserID, int PersonID, string UserName,
             string Password, bool IsActive)
        {
            Password = ComputeHash(Password);
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_UpdateUserByUserID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);


            
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            

            return (rowsAffected > 0);
        }


        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))

            using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
            {

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.HasRows)

                    {
                        dt.Load(reader);
                    }




                }

            }

            return dt;

        }

        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_DeleteUserByUserID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);

           
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
           

            return (rowsAffected > 0);

        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

           using( SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
           using( SqlCommand command = new SqlCommand("SP_IsUserExistByUserID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);

           
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    isFound = reader.HasRows;

                }
            }
          

            return isFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_IsUserExistByUsername", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", UserName);


                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    isFound = reader.HasRows;


                }

            }
            return isFound;
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_IsUserExistByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);


                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    isFound = reader.HasRows;


                }

            }
            return isFound;
        }

      

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            NewPassword= ComputeHash(NewPassword);
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_ChangePasswordByUserID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);

            
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
           

           

            return (rowsAffected > 0);
        }

    }
}
