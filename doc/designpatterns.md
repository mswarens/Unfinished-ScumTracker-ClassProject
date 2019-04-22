# Scrum Project Tracking System
## Design Patterns

### Final Design Patterns
Our final project includes examples of two design patterns:


**Singleton**
The Singleton design pattern is used in our Main/CurrentUser class; it is a static class that maintains the authentication status, userID, roleID, and teamID for the user currently logged into the system.


**Factory**
The Factory design pattern is used in the DataExports/ExportDocumentFactory class.  It generates objects of type ExportPDFDocument or ExportExcelDocument (both of which implement IExportDocument) based on the format provided in the method parameter.
 
