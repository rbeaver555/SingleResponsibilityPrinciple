With MVC, the Controllers "should" act as a traffic cop for the rest of the application. They inherently manage the http requests associated with serving up pages, reacting to the pages, ect. Ultimately they should be very clear,
simply referencing other classes like repository classes, business classes, helpers, and models to do the actual work. They orchestrate the efforts within MVC.

1. Inventory Controller
2. Home Controller
3. User Controller

Use this layer to cleanly separate that logic which ties all the other pieces of your MVC app together.