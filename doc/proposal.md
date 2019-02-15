# Scrum Project Tracking System
## Project Proposal

Scrum, a subset of agile, is a software development framework with a focus on developing applications in an iterative, highly adaptive manner.  Commonly used across a wide variety of industries, scrum development generally consists of '93sprints'94 lasting 2-4 weeks during which products are designed, coded, and tested.  Because scrum development is very time sensitive and averse to mid-sprint changes, it is important for development teams to carefully and consistently prioritize, estimate, and monitor the status of project deliverables.  To this end, we propose the development of an application intended for use by a scrum development team that allows for detailed sprint planning and tracking.  

 Major features planned for this application include:
* The ability to plan development sprints, including associated backlog tasks 
* The ability to track the status of backlog deliverables during a sprint
* The ability for development team members to view sprint status and assignments in a dashboard-like interface
* The ability for business users to submit stories to the product backlog
* The ability for users to export sprint and project data to various file formats, including spreadsheet and PDF
* The ability to maintain user accounts
 
As scrum development requires consistent and efficient collaboration among several members of a development team, our project tracking application is intended for multi-user transactional activity.  Accordingly, it will utilize a SQL database backend for data storage.  The frontend will be written in C#, utilizing the Windows Forms (Winform) library for GUI development and Entity Framework for data access.
