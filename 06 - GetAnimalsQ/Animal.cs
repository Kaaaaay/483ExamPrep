using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   * Connect to a Microsoft SQL Database
   * Create Animal objects and populate them with data from the database
   * Return a sequence of popuated Animal objects
   */

/*
 * sqlConnection.Open - Opens a database connection with the property settings specified in the connection string
 * sqlConnection.Closed - Advances the SqlDataReader to the next record
 */

class Animal
    {
        public string Color { get; set; }
        public string Name { get; set; }

    }

    private static IEnumerable<Animal> GetAnimals (string sqlConnectionString)
    {
        var animals = new List<Animal>();
        SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
        using (sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT Name, ColorName FROM Animals", sqlConnection);
            sqlConnection.Open();

            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    var animal = new Animal();
                    animal.Name = (string)sqlDataReader["Name"];
                    animal.Color = (string)sqlDataReader["ColorName"];
                    animals.Add(animal);
                }

            }
        }

        //return customers;
    }

