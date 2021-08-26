# Equals Money Developer Technical Test

Welcome to the Equals Money Technical Test. Below you will find instructions on how to get set up with the test solution, along with a number of tasks to complete.

We would expect you to spend around an hour completing the main tasks, and any extension tasks that you have time for.

## Getting set up

To complete this test, you'll need an up to date version of Visual Studio 2019. The community edition can be found at this link: https://visualstudio.microsoft.com/downloads/

There are a few things you will need to do once you have cloned the repo down to your machine.

- Create a new branch to complete your tasks in. Please make sure you put your name somewhere in the branch name.
- Perform an 'Update-Database' command to generate the local database.
  - To do this, you'll need to open the 'Package Manager Console' in Visual Studio (View -> Other Windows -> Package Manager Console)
  - Ensure the project 'DevelopmentTechnicalTestBackend' is set as the start up project (Right click project in Solution Explorer -> Set as Start Up Project)
  - Type 'Update-Database' in the Package Manager Console and hit enter
  - An SQLite database will be created with default tables in your local AppData folder (\Users\*username*\AppData\Local) - EntityFramework is already set up to use this database.

If you wish to look in the tables of this database at any point, a portable version of 'sqlitebrowser' is included in this repo.

## Main Tasks

The main task of this technical test is taking the partially completed solution, and creating a product that takes in payment information from the front end form (this is already set up) and passing it along to the web API and storing it in the database using Entity Framework.

## Extension Tasks

If you finish the above main tasks, there are a number of additional extension tasks that you can undertake which are listed below in no particular order.

- Add a login page, and login functionality to the front end website
- Add API key authentication to the backend web API
- Add validation for both information that comes in via the front end form, and information that comes into the payment endpoints
- Add a way to re-use past payment information when making a payment. This is a fairy in depth extension task and will require changes across all parts of the solution:
  - A new drop down will be required on the front end payment page
  - The front end page will need to call a new endpoint in the web API
  - A new table will be required in the database to store the beneficiary information that can be reused (this should be done using a code-first approach with Entity Framework)
  - The existing payment POST endpoint will need tweaking to store the relevant information in the new table
