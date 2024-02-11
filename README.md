# Flowcentric Assessment

Project caters for importing on XML config file and saving it to SQL Database

## Web API

 - The api contains 1 controller for importing of config file that accepts a XML body 



  
## Deployment

To deploy this project Edit AppSettings.json and add ConnectionString for database.

Example:
```Example
 "ConnectionStrings": {
    "DefaultConnection": "server=Localhost;database=AssessmentDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
```

database Migrations should automatically create tables from data structure .


## Appendix

Custom Setting not importing 
 - Classes added 
 - Method added with comments 
 
 Hopefully the rest of the code will give a good understanding of my thought process with this assessement


## Notes

Just some notes 
- did not follow any code commiting standards (this is usually company specific) Example : story number - What changed etc
- code is in C# using code first with entity framework core for database migrations 


