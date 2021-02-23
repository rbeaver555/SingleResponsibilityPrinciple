The helper layer is a bit of an oddity. It effectively contains those things that don't fit anywhere else. Usually dedicated to small tools or classes that offer assistance to your core application. Examples of that might be:

1. Custom Error Logging Classes
2. Classes that map data from a database entity to a model class
3. JSON serialization classes.

Use this layer to cleanly separate those small classes and methods that help your application, but aren't a core part of the application.