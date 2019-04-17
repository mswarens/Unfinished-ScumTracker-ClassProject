# Scrum Project Tracking System
## Project Reflections

### Personal Experiences
#### Scott Shrout
I have personally found the project to be engaging and an interesting learning experience both from a technical perspective and from a project management/time management perspective.  I feel the various sprint activities have given us a glimpse into *real-world* software development practices.  As part of this project, I strengthened my knowledge of C# and largely newly learned Entity Framework.  My role included coding, documentation, and testing activities.
Although I'm satisfied with the product of this effort, in future projects I would likely try to make a more concerted effort to better communicate with other members of the team and ensure we are all on the same page in terms of expectations and direction.




### Final Design Patterns
Our final project includes examples of two design patterns:
**Singleton**
The Singleton design pattern is used in our Main/CurrentUser class; it is a static class that maintains the authentication status, userID, roleID, and teamID for the user currently logged into the system.
**Factory**
The Factory design pattern is used in the DataExports/ExportDocumentFactory class.  It generates objects of type ExportPDFDocument or ExportExcelDocument (both of which implement IExportDocument) based on the format provided in the method parameter.
