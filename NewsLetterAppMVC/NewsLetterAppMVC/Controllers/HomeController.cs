using NewsLetterAppMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewsLetter;Integrated Security=True;Connect Timeout=30;Encrypt=False;"; // Connection string to the database
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress)) //Validate the input
            {
                return View("~/Views/Shared/Error.cshtml"); // Redirect to an error view if validation fails
            }
            else
            {
                
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES (@FirstName, @LastName, @EmailAddress);";

                // Create and open a connection to the database, execute the query
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create the command and set its parameters
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", System.Data.SqlDbType.VarChar);

                    // Set parameter values
                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery(); // Execute the query
                    connection.Close();
                }
                return View("Success"); // Redirect to a success view if validation passes
            }
        }
        
        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber FROM SignUps";

            //create a list of the model to hold the data from the database
            List<Models.NewsLetterSignUp> signups = new List<Models.NewsLetterSignUp>();

            // Create and open a connection to the database, execute the query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open(); // Open the connection
                
                SqlDataReader reader = command.ExecuteReader(); // Execute the query and get a data reader 

                while (reader.Read())
                {
                    var signup = new Models.NewsLetterSignUp();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString(); // Read the Social Security Number

                    signups.Add(signup); // Add the object to the list
                }
            }

            // Map the list of NewsLetterSignUp to a list of SignupVm
            var signupVms = new List<SignupVm>();

            foreach (var signup in signups)
            {
                var signupVm = new SignupVm();
                signupVm.FirstName = signup.FirstName;
                signupVm.LastName = signup.LastName;
                signupVm.EmailAddress = signup.EmailAddress;
                signupVms.Add(signupVm);
            }
            return View(signupVms);
        }
    }
}