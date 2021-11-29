# Asp.Net Core Web API N-Tier

Asp.net Core Web API Project

## Setup

- You can change connection string from *appsettings.json* within *Gianteagle.Api*
- All database operation are in Gianteagle.
- It will create LOG folder and for each date it will have text log file.
 
## Layers

- Gianteagle.Api - Presentation Layer *.Net Core Web API project*.
- Gianteagle.BAL - All Business Logic  will be in this layer and it is responsible for data exchange between DAL and Presentation Layer.
- Gianteagle.DAL - Database Layer responsible for interacting database and Business Layer. *Generic repositories* are being used.
- Gianteagle.DTO - Modal Layer for EntityFramewrok. Data transfer objects or modals.
- Gianteagle.Entities - Entities which are being used in presentation and Business Layer.
- Gianteagle.IoC - Is it eesponsible for *dependency injection* it has ```DependencyInjection``` class and ```InjectDependencies``` method in it.
- Gianteagle.Test - This is unit test layer. Now it is empty I will be adding unit test and mocking code here.
- Gianteagle.Utilities - Here in this layer all custom utility methods like Extensions and other methods are there.

  
