# HPCShips

CRUD operations on ships data using React and .Net Core

# Setup the Application

## If you want to use Visual Studio
If you want to use Visual Studio (highly recommended) follow the following steps:
-   If you already have Visual Studio installed make sure you have .Net Core installed by running the "Visual Studio Installer" and making sure ".NET Core cross-platform development" is checked
-   If you need to install visual studio download it at https://www.microsoft.com/net/download/ (If you're using Windows you'll want to check "ASP.NET" and ".NET Core cross-platform development" on the workloads screen during installation.)
-   Open the .sln file in visual studio
-   To run the application simply press the Start Debug button (green arrow) or press F5
-   If you're using Visual Studio on Windows, to run tests open the Test menu, click Run, then click on Run all tests (results will show up in the Test Explorer)
-   If you're using Visual Studio on macOS, to run tests, select the StarChartTests Project, then go to the Run menu, then click on Run Unit Tests (results will show up in the Unit Tests panel)

(Note: All tests should fail at this point, this is by design. As you progress through the projects more and more tests will pass. All tests should pass upon completion of the project.)

## If you don't plan to use Visual studio
If you would rather use something other than Visual Studio
-   Install the .Net Core SDK from https://www.microsoft.com/net/download/core once that installation completes you're ready to roll!
-   To run the application go into the StarChart project folder and type `dotnet run`
-   To run the tests go into the StarChartTests project folder and type `dotnet test`

# Features 

- Creating a web service that provides access to data
- Using Material UI for developing data grid with sort, search, drga and drop columns and action buttons. 
- Actions to retrieve data from the database, Add data to the database, Update existing data, Remove data from the database

## Web Api (Run Api on Server)

- The project has been generated with .Net Core 5.0 as Web Api regarding to CRUD operations on server.
- The database is mocked up and all the data about the ships can be found in the ships.json file in the root folder of the project.
- Default url for running Api is https://localhost:5001, and application url as well as the port setings can be changed in launchSettings.json file.

## Client App

The frontend uses React app that exists in ClientApp folder.In this directory, you can run:

### `npm install`

Downloads required packages and it's dependencies.

### `npm start`

Runs the app in the development mode.<br />
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.<br />
You will also see any lint errors in the console.

### `npm test`

Launches the test runner in the interactive watch mode.<br />
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `npm run build`

Builds the app for production to the `build` folder.<br />
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.<br />
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

