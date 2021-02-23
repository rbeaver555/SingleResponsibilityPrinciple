Within ASP.NET MVC, the model class represents the core entities or objects within your system. It will ultimately also be how the application defines your database tables, columns, and relationships as well.
I know what you're thinking, does that fit single responsibility principle? Not really, but rules can be bent for the sake of speed at times. 

1. Inventory Item
2. Patient
3. User

Use this layer to cleanly separate those classes and methods that represent the objects your system serves.