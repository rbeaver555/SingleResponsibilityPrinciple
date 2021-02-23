The repository pattern specifically states many things.... :), but ultimately the idea is hey, let's separate out all of those queries that we utilize for getting, updating, inserting, and deleting data from the database.
It's effectively abstracting that logic (linq generally for MVC), from the rest of your application. This is fully SRP. These repo classes have one job, and it's to transfer data to and from one or more tables in the database.

1. Inventory Item Repository (just a pile of methods for querying)
2. Patient Repository
3. User Repository

Use this layer to cleanly separate those classes and methods that interact with your database.