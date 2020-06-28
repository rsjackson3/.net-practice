namespace DatingApp.API.Models
{
    // a model for the database, the attributes in the class are fields
    // each instance of a Value object will correspond to a row within a database table
    // each property of the object maps to a column
    public class Value
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}