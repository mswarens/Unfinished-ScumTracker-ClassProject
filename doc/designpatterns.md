# Scrum Project Tracking System
## Design Patterns

### Current Use 

At present, the following design pattern is found within the project:

 **Singleton** (Creational) - As its name may suggest, the singleton design pattern involves use of classes that are limited to a single instance within the application.  In our application, we use this pattern for the CurrentUser class which is responsible for holding the authentication status, user ID, and team ID associated with the current user session.  As a single instance of the application is intended for use by a single user, it is not necessary to create multiple instances of this class.  The properties within the class are used throughout the application when determining the identity and characteristics of the current user.

### Potential Opportunities

There is the potential opportunity to include the following additional design patterns in the application:

 - **Observer** (Behavioral) -- Though it doesn't exist in our project exactly as specified, the intent and use case for this pattern as related to our project is fairly simple to recognize: the interface contains informational elements, displayed in a "dashboard" at the bottom of the screen that update when related entities change state.  This functionality could be modified to more exactly resemble the observer design pattern.
 - **Factory** (Creational) - As one of the planned features for the application allows a user to export data assets in multiple formats, such as PDF, Excel, and plain text, it is conceivable that the factory design pattern, which allows an object to be returned based on a subclass determined at run time,  may find use in the application.
 
