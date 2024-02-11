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
 
 Hope fully the rest of the code will give a good understanding of my thought process with this assessement

