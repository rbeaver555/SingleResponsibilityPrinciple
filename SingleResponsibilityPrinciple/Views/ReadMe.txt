With MVC, the views represent the html that actually is built by the razor view engine to display pages. Hopefully the javascript and css are in their own file(s) because SRP says they should be!
What we're really focused on in the views is the structure of the page, and referencing the appropiate css/javascript within the pages.

1. Inventory Index
2. Add Inventory
3. Home Page

Use this layer to cleanly separate those files that represent the view from the rest of your solution.