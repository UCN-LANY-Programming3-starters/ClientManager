using Model;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CustomerDao
    {
        public IEnumerable<Customer> GetAll()
        {
            // TODO: Implement call to database for returning all rows from the Customers table

            // 1. Create and open a connection to the database


            // 2. Create a sql command that will be executed on the database


            // 3. Create a datareader object to retrieve data


            // 4. Pass the data from the reader into a collection of Customer objects


            // 5. Clean up


            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            // TODO: Implement call to database for returning a specific row from the Customers table with the given id

            throw new NotImplementedException();
        }


        public bool Insert(Customer entity)
        {
            // TODO: Implement call to database that inserts the entity into the customers table

            throw new NotImplementedException();
        }

        public bool Update(Customer entity)
        {
            // TODO: Implement call to database that updates the entity in the customers table

            throw new NotImplementedException();
        }

        public bool Delete(Customer entity)
        {
            // TODO: Implement call to database that deletes the entity from the customers table

            throw new NotImplementedException();
        }
    }
}